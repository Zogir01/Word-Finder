using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using System.Runtime.InteropServices;

namespace Word_Finder
{
    public partial class MainForm : Form
    {
        Dictionary<string, string> langs = new Dictionary<string, string>()
        {
            {"afr", "Afrikaans"}, {"amh", "Amharic"}, {"ara", "Arabic"}, {"asm", "Assamese"}, {"aze", "Azerbaijani"}, {"aze_cyrl", "Azerbaijani - Cyrilic"}, {"bel", "Belarusian"}, {"ben", "Bengali"}, {"bod", "Tibetan"}, {"bos", "Bosnian"},
            {"bre", "Breton"}, {"bul", "Bulgarian"}, {"cat", "Catalan/Valencian"}, {"ceb", "Cebuano"}, {"ces", "Czech"}, {"chi_sim", "Chinese-Simplified"}, {"chi_tra", "Chinese-Traditional"}, {"chr", "Cherokee"}, {"cos", "Corsican"}, {"cym", "Welsh"},
            {"dan", "Danish"}, {"dan_frak", "Danish-Fraktur"}, {"deu", "German"}, {"deu_frak", "German-Fraktur"}, {"dzo", "Dzongkha"}, {"ell", "Greek-Modern"}, {"eng", "English"}, {"enm", "English-Middle"}, {"epo", "Esperanto"}, {"equ", "Math/equation-detection-module"},
            {"est", "Estonian"}, {"eus", "Basque"}, {"fao", "Faroese"}, {"fas", "Persian"}, {"fil", "Filipino(old-Tagalog)"}, {"fin", "Finnish"}, {"fra", "French"}, {"frk", "German-Fraktur"}, {"frm", "French-Middle"}, {"fry", "Western-Frisian"},
            {"gla", "Scottish-Gaelic"}, {"gle", "Irish"}, {"glg", "Galician"}, {"grc", "Greek-Ancient"}, {"guj", "Gujarati"}, {"hat", "Haitian/Haitian-Creole"}, {"heb", "Hebrew"}, {"hin", "Hindi"}, {"hrv", "Croatian"}, {"hun", "Hungarian"},
            {"hye", "Armenian"}, {"iku", "Inuktitut"}, {"ind", "Indonesian"}, {"isl", "Icelandic"}, {"ita", "Italian"}, {"ita_old", "Italian-Old"}, {"jav", "Javanese"}, {"jpn", "Japanese"}, {"kan", "Kannada"}, {"kat", "Georgian"},
            {"kat_old", "Georgian-Old"}, {"kaz", "Kazakh"}, {"khm", "Central-Khmer"}, {"kir", "Kirghiz/Kyrgyz"}, {"kmr", "Kurmanji(Kurdish-Latin Script)"}, {"kor", "Korean"}, {"kor_vert", "Korean(vertical)"}, {"lao", "Lao"}, {"lat", "Latin"}, {"lav", "Latvian"},
            {"lit", "Lithuanian"}, {"ltz", "Luxembourgish"}, {"mal", "Malayalam"}, {"mar", "Marathi"}, {"mkd", "Macedonian"}, {"mlt", "Maltese"}, {"mon", "Mongolian"}, {"mri", "Maori"}, {"msa", "Malay"}, {"mya", "Burmese"},
            {"nep", "Nepali"}, {"nld", "Dutch/Flemish"}, {"nor", "Norwegian"}, {"oci", "Occitan(post-1500)"}, {"ori", "Oriya"}, {"osd", "Orientation-and-script-detection-module"}, {"pan", "Panjabi/Punjabi"}, {"pol", "Polish"}, {"por", "Portuguese"}, {"pus", "Pushto/Pashto"},
            {"que", "Quechua"}, {"ron", "Romanian/Moldavian/Moldovan"}, {"rus", "Russian"}, {"san", "Sanskrit"}, {"sin", "Sinhala/Sinhalese"}, {"slk", "Slovak"}, {"slk_frak", "Slovak-Fraktur(contrib)"}, {"slv", "Slovenian"}, {"snd", "Sindhi"}, {"spa", "Spanish/Castilian"},
            {"spa_old", "Spanish/Castilian-Old"}, {"sqi", "Albanian"}, {"srp", "Serbian"}, {"srp_latn", "Serbian-Latin"}, {"sun", "Sundanese"}, {"swa", "Swahili"}, {"swe", "Swedish"}, {"syr", "Syriac"}, {"tam", "Tamil"}, {"tat", "Tatar"},
            {"tel", "Telugu"}, {"tgk", "Tajik"}, {"tgl", "Tagalog(new-Filipino)"}, {"tha", "Thai"}, {"tir", "Tigrinya"}, {"ton", "Tonga"}, {"tur", "Turkish"}, {"uig", "Uighur/Uyghur"}, {"ukr", "Ukrainian"}, {"urd", "Urdu"},
            {"uzb", "Uzbek"}, {"uzb_cyrl", "Uzbek-Cyrilic"}, {"vie", "Vietnamese"}, {"yid", "Yiddish"}, {"yor", "Yoruba"}
        };

        private PythonProcess pythonProcess;
        private List<Button> buttons = new List<Button>();

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            generate_comboBox_langChoice();
        }
        private void generate_comboBox_langChoice()
        {
            //comboBox_langChoice.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //comboBox_langChoice.AutoCompleteSource = AutoCompleteSource.ListItems;
            foreach (var item in langs)
                comboBox_langChoice.Items.Add(item.Value);
        }
        public void button_generate_Click(object sender, EventArgs e)
        {
            button_stopScript.Enabled = true;
            button_generate.Enabled = false;
            bool config_succes = setConfigFile();

            if (config_succes == true)
            {
                label_ScriptOutput.Text = "Waiting...";
                pythonProcess = new PythonProcess(progressBar, label_ScriptOutput);

                try
                {
                    pythonProcess.start(python_process_Exited);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error with running script", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                button_stopScript.Enabled = false; 
                button_generate.Enabled = true;
            }
        }
        private void button_stopScript_Click(object sender, EventArgs e)
        {
            pythonProcess.stop();
            label_ScriptOutput.Text = "Stopped by user";
        }
        private bool setConfigFile()
        {
            var ConfigFile = new IniFile("Config.ini");
            if (checkBox_selectFileDirectory.Checked == true)
            {
                if(textBox_FilesPathChoice.Text != "")
                {
                    ConfigFile.Write("file-path", textBox_FilesPathChoice.Text, "ScriptConfig");
                }
                else
                {
                    MessageBox.Show("You need to enter data!");
                    return false;
                }
            }
            else
            {
                if(buttons.Count > 0)
                {
                    ConfigFile.Write("file-path", "null", "ScriptConfig");
                    StreamWriter filespaths_txt = new StreamWriter("filespaths.txt");
                    foreach (var btn in buttons)
                    {
                        //btn.Tag is full length path to file
                        filespaths_txt.WriteLine(btn.Tag);
                    }
                    filespaths_txt.Close();
                }
                else
                {
                    MessageBox.Show("You need to enter data!");
                    return false;
                }
            }

            if (checkBox_useKeywords.Checked == true)
            {
                if (textBox_KeyWordsPathChoice.Text != "")
                {
                    ConfigFile.Write("key-words", "True", "ScriptConfig");
                    ConfigFile.Write("key-words-path", textBox_KeyWordsPathChoice.Text, "ScriptConfig");
                }
                else
                {
                    MessageBox.Show("You need to enter data!");
                    return false;
                }
            }
            else
            {
                ConfigFile.Write("use-key-words", "False", "ScriptConfig");
                ConfigFile.Write("key-words-path", "null", "ScriptConfig");
            }


            if (comboBox_langChoice.Text != "")
            {
                bool lang_founded = false;
                foreach (var item in langs)
                {
                    if (comboBox_langChoice.Text == item.Value)
                    {
                        ConfigFile.Write("tesseract-lang", item.Key.ToString(), "TesseractConfig");
                        lang_founded = true;
                    }
                }
                    
                if(!lang_founded)
                {
                    MessageBox.Show("Selected language does not exists");
                    return false;
                }
                        
            }
            else
            {
                MessageBox.Show("You need to enter data!");
                return false;
            }

            if (textBox_tessdataPathChoice.Text != "")
            {
                ConfigFile.Write("tesseract-tessdata-path", textBox_tessdataPathChoice.Text.Replace(@"\", @"\\"), "TesseractConfig");
            }
            else
            {
                MessageBox.Show("You need to enter data!");
                return false;
            }
            if(checkBox_useTesseractPath.Checked == true)
            {
                if(textBox_tesseractExePathChoice.Text != "")
                    ConfigFile.Write("tesseract-executable-path", textBox_tesseractExePathChoice.Text.Replace(@"\", @"\\"), "TesseractConfig");
                else
                {
                    MessageBox.Show("You need to enter data!");
                    return false;
                }
            }
            else ConfigFile.Write("tesseract-executable-path", "null", "TesseractConfig");

            if (checkBox_useTessdataPath.Checked == true)
            {
                if (textBox_tessdataPathChoice.Text != "")
                    ConfigFile.Write("tesseract-tessdata-path", textBox_tessdataPathChoice.Text.Replace(@"\", @"\\"), "TesseractConfig");
                else
                {
                    MessageBox.Show("You need to enter data!");
                    return false;
                }
            }
            else ConfigFile.Write("tesseract-tessdata-path", "null", "TesseractConfig");

            if(checkBox_usePopplerPath.Checked == true)
            {
                if (textBox_popplerPathChoice.Text != "")
                    ConfigFile.Write("poppler-bin-path", textBox_popplerPathChoice.Text, "PopplerConfig");
                else
                {
                    MessageBox.Show("You need to enter data!");
                    return false;
                }
            }
            else ConfigFile.Write("poppler-bin-path", "null", "PopplerConfig");

            return true;
        }
        private void python_process_Exited(object sender, System.EventArgs e)
        {
            button_stopScript.Invoke(new Action(() => button_stopScript.Enabled = false));
            button_generate.Invoke(new Action(() => button_generate.Enabled = true));
            progressBar.Invoke(new Action(() => progressBar.Value = 0));
        }
        private void button_filesDirectoryPathSearch_Click(object sender, EventArgs e)
        {
            string path = search_directory();
            if(path != null) textBox_FilesPathChoice.Text = path;
        }
        private void button_keyWordsPathSearch_Click(object sender, EventArgs e)
        {
            string path = search_file(true, "txt files (*.txt)|*.txt|All files (*.*)|*.*");
            if (path != null) textBox_KeyWordsPathChoice.Text = path;
        }
        private void button_tesseractExePathSearch_Click(object sender, EventArgs e)
        {
            string path = search_file(false, "files |*.exe");
            if (path != null) textBox_tesseractExePathChoice.Text = path;
        }
        private void button_tessdataPathSearch_Click(object sender, EventArgs e)
        {
            string path = search_directory();
            if (path != null) textBox_tessdataPathChoice.Text = path;
        }
        private void buttonFilesSearch_Click(object sender, EventArgs e)
        {
            string[] paths = search_files(true, "files |*.pdf;*.png;*.jpg;*.jpeg");
            if (paths != null) 
            {
                //creating file buttons in flowlayoutpanel
                foreach (var (value, i) in paths.Select((value, i) => (value, i)))
                {
                    bool file_repeat = false;

                    //checking is file repeat
                    foreach (var btn in buttons)
                    {
                        if (value == btn.Tag.ToString())
                        {
                            file_repeat = true;
                        }
                    }

                    if (file_repeat == false)
                    {
                        Button button = new Button();
                        button.Text = System.IO.Path.GetFileName(value);
                        button.Size = new Size(305, 22);
                        button.TextAlign = ContentAlignment.MiddleLeft;
                        button.Tag = value;
                        button.BackColor = Color.FromArgb(45, 56, 61);
                        button.Margin = new Padding(2, 1, 2, 1);
                        button.FlatAppearance.BorderSize = 0;
                        button.FlatStyle = FlatStyle.Flat;
                        button.ForeColor = Color.White;
                        button.Click += new System.EventHandler(this.file_button_click);
                        buttons.Add(button);
                        flowLayoutPanel_FilesList.Controls.Add(button);
                    }
                }
                labelAmountOfSelFiles.Text = buttons.Count.ToString();
            }
        }
        private string search_file(bool addExt, string filter)
        {
            OpenFileDialog browser = new OpenFileDialog();
            if(addExt == true) browser.AddExtension = true;
            browser.Filter = filter;

            if (browser.ShowDialog() == DialogResult.OK)
            {
                return browser.FileName;
            }
            else return null;
        }
        private string [] search_files(bool addExt, string filter)
        {
            OpenFileDialog browser = new OpenFileDialog();
            if (addExt == true) browser.AddExtension = true;
            browser.Multiselect = true;
            browser.Filter = filter;

            if (browser.ShowDialog() == DialogResult.OK)
            {
                return browser.FileNames;
            }
            else return null;
        }
        private string search_directory()
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            if (browser.ShowDialog() == DialogResult.OK)
            {
                return browser.SelectedPath;
            }
            else return null;
        }
        private void file_button_click(object sender, EventArgs e)
        {
            var button = sender as Button;

            flowLayoutPanel_FilesList.Controls.Remove(button);
            buttons.Remove(button);
            labelAmountOfSelFiles.Text = buttons.Count.ToString();
        }
        private void buttonClearChoosedFiles_Click(object sender, EventArgs e)
        {
            labelAmountOfSelFiles.Text = "0";
            flowLayoutPanel_FilesList.Controls.Clear();
            buttons.Clear();
        }
        private void checkBox_selectFileDirectory_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_selectFileDirectory.Checked)
            {
                buttonFilesSearch.Enabled = false;
                buttonClearChoosedFiles.Enabled = false;
                flowLayoutPanel_FilesList.Enabled = false;
                textBox_FilesPathChoice.Enabled = true;
                button_filesDirectoryPathSearch.Enabled = true;
            }
            else
            {
                buttonFilesSearch.Enabled = true;
                buttonClearChoosedFiles.Enabled = true;
                flowLayoutPanel_FilesList.Enabled = true;
                textBox_FilesPathChoice.Enabled = false;
                button_filesDirectoryPathSearch.Enabled = false;
            }
        }
        private void checkBox_useKeywords_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_useKeywords.Checked)
            {
                textBox_KeyWordsPathChoice.Enabled = true;
                button_keyWordsPathSearch.Enabled = true;
            }
            else
            {
                textBox_KeyWordsPathChoice.Enabled = false;
                button_keyWordsPathSearch.Enabled = false;
            }
        }
        private void checkBox_useTesseractPath_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_useTesseractPath.Checked)
            {
                textBox_tesseractExePathChoice.Enabled = true;
                button_tesseractExePathSearch.Enabled = true;
            }
            else
            {
                textBox_tesseractExePathChoice.Enabled = false;
                button_tesseractExePathSearch.Enabled = false;
            }
        }
        private void checkBox_useTessdataPath_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_useTessdataPath.Checked == true)
            {
                textBox_tessdataPathChoice.Enabled = true;
                button_tessdataPathSearch.Enabled = true;
            }
            else
            {
                textBox_tessdataPathChoice.Enabled = false;
                button_tessdataPathSearch.Enabled = false;
            }
        }

        private void checkBox_usePopplerPath_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_usePopplerPath.Checked == true)
            {
                textBox_popplerPathChoice.Enabled = true;
                button_popplerPathSearch.Enabled = true;
            }
            else
            {
                textBox_popplerPathChoice.Enabled = false;
                button_popplerPathSearch.Enabled = false;
            }
        }
        private void buttonOpenResultsFile_Click(object sender, EventArgs e)
        {
            open_file("results.txt");
        }
        private void buttonOpenKeywordsFile_Click(object sender, EventArgs e)
        {
            open_file(textBox_KeyWordsPathChoice.Text);
        }
        private void buttonOpenSyserrFile_Click(object sender, EventArgs e)
        {
            open_file("syserr.txt");
        }
        private void open_file(string path)
        {
            try
            {
                Process.Start(path);
            }
            catch(System.ComponentModel.Win32Exception)
            {
                MessageBox.Show(("Cannot find file. Check is file exist."));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occured with openning file.");    
            }
        }
        private void Main_FormClosed(Object sender, FormClosedEventArgs e)
        {
            pythonProcess.stop();
            Application.Exit();
            Environment.Exit(Environment.ExitCode);
        }
        private void button_linkToGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Zigor36");
        }
        private void button_linkToYoutube_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCAi4N38B5ekpv6Tcwjli2hA");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/tesseract-ocr/tessdata");
        }

        private void comboBox_langChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*
            comboBox_langChoice.AutoCompleteMode

            if (comboBox_langChoice.SelectedIndex == 0)
            {
                generate_comboBox_langChoice();
            }
            else if(comboBox_langChoice.SelectedIndex > 0)
            {
                comboBox_langChoice.Items.Clear();
                foreach (var item in langs)
                {
                    if(item.Value == comboBox_langChoice.Text)
                    {
                        comboBox_langChoice.Items.Add(item.Value);
                    }
                }

            }
            */
        }
        private void comboBox_langChoice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label_langChoice.Text = comboBox_langChoice.Items[comboBox_langChoice.FindString(comboBox_langChoice.Text)].ToString();
            }
            catch
            {
                
            }
            if (comboBox_langChoice.Text == label_langChoice.Text)
                label_langChoice.Text = "";

            if (comboBox_langChoice.Text == "")
                label_langChoice.Text = "";
        }
        private void comboBox_langChoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                comboBox_langChoice.Text = label_langChoice.Text;
                comboBox_langChoice.SelectionStart = comboBox_langChoice.Text.Length;
            }
        }
    }
}