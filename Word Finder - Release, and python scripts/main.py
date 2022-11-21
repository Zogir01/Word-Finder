import sys
import traceback

import PIL
import os
import time
import datetime

from configparser import ConfigParser
from PipeClient import PipeClient

import pytesseract
import pdf2image

output_pipeClient = PipeClient("OutputData")

def main():
    start_script_time = time.time()
    output_pipeClient.connect()

    config = ConfigParser()
    try:
        config.read('config.ini')
        file_path = '{}'.format(config.get('ScriptConfig', 'file-path'))
        keywords_path = '{}'.format(config.get('ScriptConfig', 'key-words-path'))

        if ('{}'.format(config.get('ScriptConfig', 'key-words')) == 'True'):
            use_keywords = True
        else:
            use_keywords = False

        lang = '{}'.format(config.get('TesseractConfig', 'tesseract-lang'))
        tessdata_path = '{}'.format(config.get('TesseractConfig', 'tesseract-tessdata-path'))
        tesseract_exe_path = '{}'.format(config.get('TesseractConfig', 'tesseract-executable-path'))
        poppler_bin_path = '{}'.format(config.get('PopplerConfig', 'poppler-bin-path'))
    except:
        writeError("Error occured while reading config.ini.")  

    if tessdata_path != 'null':
        tessdata_dir_config = '--tessdata-dir "{}"'.format(tessdata_path)
    else:
        tessdata_dir_config = '' 

    if tesseract_exe_path != 'null':
            pytesseract.pytesseract.tesseract_cmd = tesseract_exe_path

    if (pytesseract.get_languages(tessdata_dir_config).count(lang) == 0):
        writeError("The specified language was not installed.")

    keywords = list
    if use_keywords == True:
        keywords = loadKeywordsFromTxt(keywords_path)

    correct_files = loadFilesAndCheckFileFormat(file_path)

    words = generateWordsFromImg(correct_files, keywords, use_keywords, lang, tessdata_dir_config, poppler_bin_path)

    saveResultsToFile(words)

    end_script_time = time.time()
    script_time_seconds = end_script_time - start_script_time
    script_time_minutes = 0

    while(script_time_seconds >= 60):
        script_time_seconds -= 60
        script_time_minutes += 1

    final_time = "{}".format(script_time_minutes) + " min, " + "{:.2f}".format(script_time_seconds) + " sec."
    output_pipeClient.write("COMPLETE, check results.txt file " + "| Time: " + (str)(final_time))
    sys.exit()

def loadKeywordsFromTxt(keywords_path):
    try:
        keywords_txt = open(keywords_path, "r")
    except: 
        writeError("Error occured with keywords file. Check is keyword path correct.")

    keywords = list()
    for line in keywords_txt.readlines():
        size = len(line)
        keywords.append(line[:size - 1])
    keywords_txt.close()

    return keywords

def saveResultsToFile(words):
    try:
        with open('results.txt', 'w', encoding="utf-8") as file:
            for key, value in words.items():
                file.write(str(key) + ':'+ str(value) + '\n\n')
    except:
        writeError("Error occured while saving results to file results.txt.")


def loadFilesAndCheckFileFormat(dir_path):
    correct_files = dict()
    files_paths = list()

    #specified files selected
    if(dir_path == "null"):
        try:
            filespaths_txt = open("filespaths.txt", "r", encoding="utf-8")    
        except: 
            writeError("Error occured with filespaths file.")

        for line in filespaths_txt.readlines():
            size = len(line)
            files_paths.append(line[:size - 1])
        filespaths_txt.close()
    #entire folder search selected
    else:
        try:
            files_names = os.listdir(dir_path)
        except:
            writeError("Error occured while loading files. Check is file path correct.", dir_path)

        for file_name in files_names:
            files_paths.append(os.path.join(dir_path, file_name))

    #check files extensions are correct
    for path in files_paths:
        if path.endswith('.png') or path.endswith('.jpg') or path.endswith('.jpeg'):
            correct_files[path] = 'img'
        elif path.endswith('.pdf'):
            correct_files[path] = 'pdf'
        else:
            print(path, "- wrong file format")

    return correct_files

def generateWordsFromImg(files, keywords, use_keywords, lang, tessdata_dir_config, poppler_bin_path):
    text = ""
    counter = 0
    imgs_counter = 0
    words_founded = list()
    words_counts = dict()
    images = list()

    #get amount of files
    for file, ext in files.items():
        if ext == 'img':
            imgs_counter += 1
        if ext == 'pdf':
            try:
                if poppler_bin_path != 'null':
                    info = pdf2image.pdfinfo_from_path(file, poppler_path=poppler_bin_path)
                else: 
                    info = pdf2image.pdfinfo_from_path(file)
            except:
                writeError("Error occured while loading file. Check is file path correct.", file)
            imgs_counter += info['Pages']
    
    output_pipeClient.write((str)(imgs_counter) + " images loaded succesfully")
    time.sleep(0.5)

    progressBarInfo_pipeClient = PipeClient("ProgressBarInfo")
    progressBarInfo_pipeClient.connect()
    #sending imgs count to c# (required in progress bar - maximum)
    progressBarInfo_pipeClient.write((str)(imgs_counter))

    #generating words
    for file, ext in files.items():
        if ext == 'img':
            try:
                images.append(PIL.Image.open(file))
            except:
                writeError("Error occured while loading file. Check is file path correct.", file)

        elif ext == 'pdf':
            try:
                if poppler_bin_path != 'null':
                    images.extend((pdf2image.convert_from_path(file, poppler_path=poppler_bin_path)))
                else:
                    images.extend((pdf2image.convert_from_path(file)))
            except:
                writeError("Error occured while loading file. Check is file path correct.", file)

        for image in images:
            counter += 1
            
            #sending current img counter to c# (required in progress bar - value)
            progressBarInfo_pipeClient.write((str)(counter))

            progress_percent = "{:.2f}".format(counter * (100.0 / imgs_counter))
            output_pipeClient.write("generating image (" + (str)(counter) + "/" + (str)(imgs_counter) + ") : progress:" + (str)(progress_percent) + "%")

            text += pytesseract.image_to_string(image, lang=lang, config=tessdata_dir_config)

            if(use_keywords == False):
                words_founded.extend(text.split()) 
        images.clear()

    if (use_keywords == True):
        for keyword in keywords:
            if(text.lower().count(keyword.lower())):
                words_counts[keyword] = (text.lower().count(keyword.lower()))

    else:
        for word in words_founded:
            if word in words_counts:
                words_counts[word] += 1
            else:
                words_counts[word] = 1
        
    words_counts_sorted = dict(sorted(words_counts.items(), key=lambda item: item[1]))
    progressBarInfo_pipeClient.disconnect()
    return words_counts_sorted

def writeError(err_description, file = ""):
    output_pipeClient.write(err_description  + "Details in file syserr.txt")

    with open('syserr.txt', 'a') as syserr: 
        syserr.write("----------------------------------------------------------------------------------------" + "\n")
        syserr.write("- Error description: " + err_description + "\n")
        syserr.write("- Possible damaged or missing file/filefolder: " + file + "\n")
        syserr.write("- Date: " + (str)(datetime.now()) + "\n")
        syserr.write("- More Details: ")
        e_type, e_val, e_tb = sys.exc_info()
        traceback.print_exception(e_type, e_val, e_tb, file=syserr)

    sys.exit()

if __name__ == "__main__":  
    main()
    '''try:
        main()
    except(Exception):
        writeError("exc")'''
        