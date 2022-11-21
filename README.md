# Word-Finder
A tool for finding specified keywords from images or pdf's <br />

main tools to install: <br /> 
- Poppler - to convert pdf's to image format. [https://github.com/oschwartz10612/poppler-windows/releases/] <br />
- Pytesseract - a python wrapper for Google Tesseract-OCR [https://github.com/madmaze/pytesseract] <br />

For more install info - look at installation tutorials of this tools above. <br />

python libs:
- sys
- traceback
- PIL
- os
- time
- datetime
- configParser
- win32file
- win32pipe
- pytesseract
- pdf2image

The look of program:

![Przechwytywanie](https://user-images.githubusercontent.com/33838656/203017649-9d5813be-5432-49eb-b3af-1493bde925ee.PNG) <br />

The main reason of creating Word-Finder is create convenient tool to search specified words in any images. The program has a gui, where we can select over data in easy way. <br />

- Important note! - We don't have to type tesseract, and poppler paths in gui manually. We can use environmental variables. <br />

In Word-Finder there is a link between C# gui and python script. Python Script and C# GUI uses Pipes to transfer data between these processes. And for example in this way the script sends information about progress bar to c# GUI <br />
