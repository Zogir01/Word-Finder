using System.Collections.Generic;

namespace Word_Finder
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>

        private void InitializeComponent()
        {
            this.comboBox_langChoice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_FilesPathChoice = new System.Windows.Forms.TextBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.checkBox_useKeywords = new System.Windows.Forms.CheckBox();
            this.button_filesDirectoryPathSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_KeyWordsPathChoice = new System.Windows.Forms.TextBox();
            this.button_keyWordsPathSearch = new System.Windows.Forms.Button();
            this.buttonFilesSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAmountOfSelFiles = new System.Windows.Forms.Label();
            this.buttonClearChoosedFiles = new System.Windows.Forms.Button();
            this.flowLayoutPanel_FilesList = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox_selectFileDirectory = new System.Windows.Forms.CheckBox();
            this.buttonOpenResultsFile = new System.Windows.Forms.Button();
            this.buttonOpenSyserrFile = new System.Windows.Forms.Button();
            this.buttonOpenKeywordsFile = new System.Windows.Forms.Button();
            this.button_stopScript = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label_ScriptOutput = new System.Windows.Forms.Label();
            this.button_tesseractExePathSearch = new System.Windows.Forms.Button();
            this.textBox_tesseractExePathChoice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_tessdataPathSearch = new System.Windows.Forms.Button();
            this.textBox_tessdataPathChoice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_useTesseractPath = new System.Windows.Forms.CheckBox();
            this.checkBox_usePopplerPath = new System.Windows.Forms.CheckBox();
            this.textBox_popplerPathChoice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_popplerPathSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_useTessdataPath = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_linkToYoutube = new System.Windows.Forms.Button();
            this.button_linkToGitHub = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_langChoice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_langChoice
            // 
            this.comboBox_langChoice.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_langChoice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_langChoice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox_langChoice.FormattingEnabled = true;
            this.comboBox_langChoice.Location = new System.Drawing.Point(10, 191);
            this.comboBox_langChoice.Name = "comboBox_langChoice";
            this.comboBox_langChoice.Size = new System.Drawing.Size(143, 21);
            this.comboBox_langChoice.Sorted = true;
            this.comboBox_langChoice.TabIndex = 2;
            this.comboBox_langChoice.SelectedIndexChanged += new System.EventHandler(this.comboBox_langChoice_SelectedIndexChanged);
            this.comboBox_langChoice.TextChanged += new System.EventHandler(this.comboBox_langChoice_TextChanged);
            this.comboBox_langChoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_langChoice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(7, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose text language:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Choose path to files directory:";
            // 
            // textBox_FilesPathChoice
            // 
            this.textBox_FilesPathChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.textBox_FilesPathChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_FilesPathChoice.Enabled = false;
            this.textBox_FilesPathChoice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_FilesPathChoice.ForeColor = System.Drawing.Color.White;
            this.textBox_FilesPathChoice.Location = new System.Drawing.Point(6, 78);
            this.textBox_FilesPathChoice.Name = "textBox_FilesPathChoice";
            this.textBox_FilesPathChoice.Size = new System.Drawing.Size(289, 21);
            this.textBox_FilesPathChoice.TabIndex = 5;
            this.textBox_FilesPathChoice.Text = "Images/Matura - podstawa";
            // 
            // button_generate
            // 
            this.button_generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.button_generate.FlatAppearance.BorderSize = 0;
            this.button_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_generate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_generate.ForeColor = System.Drawing.Color.White;
            this.button_generate.Location = new System.Drawing.Point(375, 280);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(167, 46);
            this.button_generate.TabIndex = 6;
            this.button_generate.Text = "GENERATE";
            this.button_generate.UseVisualStyleBackColor = false;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // checkBox_useKeywords
            // 
            this.checkBox_useKeywords.AutoSize = true;
            this.checkBox_useKeywords.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_useKeywords.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_useKeywords.Location = new System.Drawing.Point(7, 106);
            this.checkBox_useKeywords.Name = "checkBox_useKeywords";
            this.checkBox_useKeywords.Size = new System.Drawing.Size(129, 17);
            this.checkBox_useKeywords.TabIndex = 7;
            this.checkBox_useKeywords.Text = "Search for key-words";
            this.checkBox_useKeywords.UseVisualStyleBackColor = true;
            this.checkBox_useKeywords.CheckedChanged += new System.EventHandler(this.checkBox_useKeywords_CheckedChanged);
            // 
            // button_filesDirectoryPathSearch
            // 
            this.button_filesDirectoryPathSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.button_filesDirectoryPathSearch.Enabled = false;
            this.button_filesDirectoryPathSearch.FlatAppearance.BorderSize = 0;
            this.button_filesDirectoryPathSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_filesDirectoryPathSearch.ForeColor = System.Drawing.Color.White;
            this.button_filesDirectoryPathSearch.Location = new System.Drawing.Point(301, 78);
            this.button_filesDirectoryPathSearch.Name = "button_filesDirectoryPathSearch";
            this.button_filesDirectoryPathSearch.Size = new System.Drawing.Size(48, 21);
            this.button_filesDirectoryPathSearch.TabIndex = 8;
            this.button_filesDirectoryPathSearch.Text = "search";
            this.button_filesDirectoryPathSearch.UseVisualStyleBackColor = false;
            this.button_filesDirectoryPathSearch.Click += new System.EventHandler(this.button_filesDirectoryPathSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(5, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose path to keywords.txt";
            // 
            // textBox_KeyWordsPathChoice
            // 
            this.textBox_KeyWordsPathChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.textBox_KeyWordsPathChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_KeyWordsPathChoice.Enabled = false;
            this.textBox_KeyWordsPathChoice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_KeyWordsPathChoice.ForeColor = System.Drawing.Color.White;
            this.textBox_KeyWordsPathChoice.Location = new System.Drawing.Point(7, 141);
            this.textBox_KeyWordsPathChoice.Name = "textBox_KeyWordsPathChoice";
            this.textBox_KeyWordsPathChoice.Size = new System.Drawing.Size(288, 21);
            this.textBox_KeyWordsPathChoice.TabIndex = 12;
            this.textBox_KeyWordsPathChoice.Text = "keywords.txt";
            // 
            // button_keyWordsPathSearch
            // 
            this.button_keyWordsPathSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.button_keyWordsPathSearch.Enabled = false;
            this.button_keyWordsPathSearch.FlatAppearance.BorderSize = 0;
            this.button_keyWordsPathSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_keyWordsPathSearch.ForeColor = System.Drawing.Color.White;
            this.button_keyWordsPathSearch.Location = new System.Drawing.Point(301, 141);
            this.button_keyWordsPathSearch.Name = "button_keyWordsPathSearch";
            this.button_keyWordsPathSearch.Size = new System.Drawing.Size(48, 21);
            this.button_keyWordsPathSearch.TabIndex = 13;
            this.button_keyWordsPathSearch.Text = "search";
            this.button_keyWordsPathSearch.UseVisualStyleBackColor = false;
            this.button_keyWordsPathSearch.Click += new System.EventHandler(this.button_keyWordsPathSearch_Click);
            // 
            // buttonFilesSearch
            // 
            this.buttonFilesSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.buttonFilesSearch.FlatAppearance.BorderSize = 0;
            this.buttonFilesSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilesSearch.ForeColor = System.Drawing.Color.White;
            this.buttonFilesSearch.Location = new System.Drawing.Point(375, 6);
            this.buttonFilesSearch.Name = "buttonFilesSearch";
            this.buttonFilesSearch.Size = new System.Drawing.Size(143, 24);
            this.buttonFilesSearch.TabIndex = 14;
            this.buttonFilesSearch.Text = "Choose Files";
            this.buttonFilesSearch.UseVisualStyleBackColor = false;
            this.buttonFilesSearch.Click += new System.EventHandler(this.buttonFilesSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(617, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Selected files:";
            // 
            // labelAmountOfSelFiles
            // 
            this.labelAmountOfSelFiles.AutoSize = true;
            this.labelAmountOfSelFiles.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAmountOfSelFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAmountOfSelFiles.Location = new System.Drawing.Point(688, 17);
            this.labelAmountOfSelFiles.Name = "labelAmountOfSelFiles";
            this.labelAmountOfSelFiles.Size = new System.Drawing.Size(13, 13);
            this.labelAmountOfSelFiles.TabIndex = 18;
            this.labelAmountOfSelFiles.Text = "0";
            // 
            // buttonClearChoosedFiles
            // 
            this.buttonClearChoosedFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.buttonClearChoosedFiles.FlatAppearance.BorderSize = 0;
            this.buttonClearChoosedFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearChoosedFiles.ForeColor = System.Drawing.Color.White;
            this.buttonClearChoosedFiles.Location = new System.Drawing.Point(524, 6);
            this.buttonClearChoosedFiles.Name = "buttonClearChoosedFiles";
            this.buttonClearChoosedFiles.Size = new System.Drawing.Size(87, 24);
            this.buttonClearChoosedFiles.TabIndex = 19;
            this.buttonClearChoosedFiles.Text = "Clear";
            this.buttonClearChoosedFiles.UseVisualStyleBackColor = false;
            this.buttonClearChoosedFiles.Click += new System.EventHandler(this.buttonClearChoosedFiles_Click);
            // 
            // flowLayoutPanel_FilesList
            // 
            this.flowLayoutPanel_FilesList.AutoScroll = true;
            this.flowLayoutPanel_FilesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.flowLayoutPanel_FilesList.Location = new System.Drawing.Point(373, 36);
            this.flowLayoutPanel_FilesList.Name = "flowLayoutPanel_FilesList";
            this.flowLayoutPanel_FilesList.Size = new System.Drawing.Size(328, 236);
            this.flowLayoutPanel_FilesList.TabIndex = 20;
            // 
            // checkBox_selectFileDirectory
            // 
            this.checkBox_selectFileDirectory.AutoSize = true;
            this.checkBox_selectFileDirectory.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_selectFileDirectory.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_selectFileDirectory.Location = new System.Drawing.Point(6, 42);
            this.checkBox_selectFileDirectory.Name = "checkBox_selectFileDirectory";
            this.checkBox_selectFileDirectory.Size = new System.Drawing.Size(340, 17);
            this.checkBox_selectFileDirectory.TabIndex = 23;
            this.checkBox_selectFileDirectory.Text = "Select folder containing files to generate (or choose files on right)";
            this.checkBox_selectFileDirectory.UseVisualStyleBackColor = true;
            this.checkBox_selectFileDirectory.CheckedChanged += new System.EventHandler(this.checkBox_selectFileDirectory_CheckedChanged);
            // 
            // buttonOpenResultsFile
            // 
            this.buttonOpenResultsFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.buttonOpenResultsFile.FlatAppearance.BorderSize = 0;
            this.buttonOpenResultsFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenResultsFile.ForeColor = System.Drawing.Color.White;
            this.buttonOpenResultsFile.Location = new System.Drawing.Point(7, 6);
            this.buttonOpenResultsFile.Name = "buttonOpenResultsFile";
            this.buttonOpenResultsFile.Size = new System.Drawing.Size(110, 24);
            this.buttonOpenResultsFile.TabIndex = 24;
            this.buttonOpenResultsFile.Text = "Open results";
            this.buttonOpenResultsFile.UseVisualStyleBackColor = false;
            this.buttonOpenResultsFile.Click += new System.EventHandler(this.buttonOpenResultsFile_Click);
            // 
            // buttonOpenSyserrFile
            // 
            this.buttonOpenSyserrFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.buttonOpenSyserrFile.FlatAppearance.BorderSize = 0;
            this.buttonOpenSyserrFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSyserrFile.ForeColor = System.Drawing.Color.White;
            this.buttonOpenSyserrFile.Location = new System.Drawing.Point(248, 6);
            this.buttonOpenSyserrFile.Name = "buttonOpenSyserrFile";
            this.buttonOpenSyserrFile.Size = new System.Drawing.Size(111, 24);
            this.buttonOpenSyserrFile.TabIndex = 25;
            this.buttonOpenSyserrFile.Text = "Open syserr";
            this.buttonOpenSyserrFile.UseVisualStyleBackColor = false;
            this.buttonOpenSyserrFile.Click += new System.EventHandler(this.buttonOpenSyserrFile_Click);
            // 
            // buttonOpenKeywordsFile
            // 
            this.buttonOpenKeywordsFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.buttonOpenKeywordsFile.FlatAppearance.BorderSize = 0;
            this.buttonOpenKeywordsFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenKeywordsFile.ForeColor = System.Drawing.Color.White;
            this.buttonOpenKeywordsFile.Location = new System.Drawing.Point(123, 6);
            this.buttonOpenKeywordsFile.Name = "buttonOpenKeywordsFile";
            this.buttonOpenKeywordsFile.Size = new System.Drawing.Size(119, 24);
            this.buttonOpenKeywordsFile.TabIndex = 26;
            this.buttonOpenKeywordsFile.Text = "Open keywords";
            this.buttonOpenKeywordsFile.UseVisualStyleBackColor = false;
            this.buttonOpenKeywordsFile.Click += new System.EventHandler(this.buttonOpenKeywordsFile_Click);
            // 
            // button_stopScript
            // 
            this.button_stopScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.button_stopScript.Enabled = false;
            this.button_stopScript.FlatAppearance.BorderSize = 0;
            this.button_stopScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stopScript.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_stopScript.ForeColor = System.Drawing.Color.White;
            this.button_stopScript.Location = new System.Drawing.Point(548, 280);
            this.button_stopScript.Name = "button_stopScript";
            this.button_stopScript.Size = new System.Drawing.Size(153, 46);
            this.button_stopScript.TabIndex = 27;
            this.button_stopScript.Text = "STOP";
            this.button_stopScript.UseVisualStyleBackColor = false;
            this.button_stopScript.Click += new System.EventHandler(this.button_stopScript_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(375, 354);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(326, 23);
            this.progressBar.TabIndex = 28;
            // 
            // label_ScriptOutput
            // 
            this.label_ScriptOutput.AutoSize = true;
            this.label_ScriptOutput.ForeColor = System.Drawing.Color.White;
            this.label_ScriptOutput.Location = new System.Drawing.Point(372, 338);
            this.label_ScriptOutput.Name = "label_ScriptOutput";
            this.label_ScriptOutput.Size = new System.Drawing.Size(52, 13);
            this.label_ScriptOutput.TabIndex = 31;
            this.label_ScriptOutput.Text = "Waiting...";
            // 
            // button_tesseractExePathSearch
            // 
            this.button_tesseractExePathSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.button_tesseractExePathSearch.Enabled = false;
            this.button_tesseractExePathSearch.FlatAppearance.BorderSize = 0;
            this.button_tesseractExePathSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tesseractExePathSearch.ForeColor = System.Drawing.Color.White;
            this.button_tesseractExePathSearch.Location = new System.Drawing.Point(311, 287);
            this.button_tesseractExePathSearch.Name = "button_tesseractExePathSearch";
            this.button_tesseractExePathSearch.Size = new System.Drawing.Size(48, 21);
            this.button_tesseractExePathSearch.TabIndex = 34;
            this.button_tesseractExePathSearch.Text = "search";
            this.button_tesseractExePathSearch.UseVisualStyleBackColor = false;
            this.button_tesseractExePathSearch.Click += new System.EventHandler(this.button_tesseractExePathSearch_Click);
            // 
            // textBox_tesseractExePathChoice
            // 
            this.textBox_tesseractExePathChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.textBox_tesseractExePathChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_tesseractExePathChoice.Enabled = false;
            this.textBox_tesseractExePathChoice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_tesseractExePathChoice.ForeColor = System.Drawing.Color.White;
            this.textBox_tesseractExePathChoice.Location = new System.Drawing.Point(17, 287);
            this.textBox_tesseractExePathChoice.Name = "textBox_tesseractExePathChoice";
            this.textBox_tesseractExePathChoice.Size = new System.Drawing.Size(288, 21);
            this.textBox_tesseractExePathChoice.TabIndex = 33;
            this.textBox_tesseractExePathChoice.Text = "Tesseract-OCR\\tesseract";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(15, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Choose path to file - tesseract.exe";
            // 
            // button_tessdataPathSearch
            // 
            this.button_tessdataPathSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.button_tessdataPathSearch.Enabled = false;
            this.button_tessdataPathSearch.FlatAppearance.BorderSize = 0;
            this.button_tessdataPathSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tessdataPathSearch.ForeColor = System.Drawing.Color.White;
            this.button_tessdataPathSearch.Location = new System.Drawing.Point(311, 353);
            this.button_tessdataPathSearch.Name = "button_tessdataPathSearch";
            this.button_tessdataPathSearch.Size = new System.Drawing.Size(48, 21);
            this.button_tessdataPathSearch.TabIndex = 37;
            this.button_tessdataPathSearch.Text = "search";
            this.button_tessdataPathSearch.UseVisualStyleBackColor = false;
            this.button_tessdataPathSearch.Click += new System.EventHandler(this.button_tessdataPathSearch_Click);
            // 
            // textBox_tessdataPathChoice
            // 
            this.textBox_tessdataPathChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.textBox_tessdataPathChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_tessdataPathChoice.Enabled = false;
            this.textBox_tessdataPathChoice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_tessdataPathChoice.ForeColor = System.Drawing.Color.White;
            this.textBox_tessdataPathChoice.Location = new System.Drawing.Point(17, 355);
            this.textBox_tessdataPathChoice.Name = "textBox_tessdataPathChoice";
            this.textBox_tessdataPathChoice.Size = new System.Drawing.Size(288, 21);
            this.textBox_tessdataPathChoice.TabIndex = 36;
            this.textBox_tessdataPathChoice.Text = "Tesseract-OCR\\tessdata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(15, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Choose path to directory - tesseract-OCR\\tessdata";
            // 
            // checkBox_useTesseractPath
            // 
            this.checkBox_useTesseractPath.AutoSize = true;
            this.checkBox_useTesseractPath.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_useTesseractPath.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_useTesseractPath.Location = new System.Drawing.Point(17, 251);
            this.checkBox_useTesseractPath.Name = "checkBox_useTesseractPath";
            this.checkBox_useTesseractPath.Size = new System.Drawing.Size(159, 17);
            this.checkBox_useTesseractPath.TabIndex = 38;
            this.checkBox_useTesseractPath.Text = "Include tesseract.exe path ";
            this.checkBox_useTesseractPath.UseVisualStyleBackColor = true;
            this.checkBox_useTesseractPath.CheckedChanged += new System.EventHandler(this.checkBox_useTesseractPath_CheckedChanged);
            // 
            // checkBox_usePopplerPath
            // 
            this.checkBox_usePopplerPath.AutoSize = true;
            this.checkBox_usePopplerPath.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_usePopplerPath.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_usePopplerPath.Location = new System.Drawing.Point(17, 382);
            this.checkBox_usePopplerPath.Name = "checkBox_usePopplerPath";
            this.checkBox_usePopplerPath.Size = new System.Drawing.Size(128, 17);
            this.checkBox_usePopplerPath.TabIndex = 41;
            this.checkBox_usePopplerPath.Text = "Include poppler path ";
            this.checkBox_usePopplerPath.UseVisualStyleBackColor = true;
            this.checkBox_usePopplerPath.CheckedChanged += new System.EventHandler(this.checkBox_usePopplerPath_CheckedChanged);
            // 
            // textBox_popplerPathChoice
            // 
            this.textBox_popplerPathChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.textBox_popplerPathChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_popplerPathChoice.Enabled = false;
            this.textBox_popplerPathChoice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_popplerPathChoice.ForeColor = System.Drawing.Color.White;
            this.textBox_popplerPathChoice.Location = new System.Drawing.Point(17, 417);
            this.textBox_popplerPathChoice.Name = "textBox_popplerPathChoice";
            this.textBox_popplerPathChoice.Size = new System.Drawing.Size(288, 21);
            this.textBox_popplerPathChoice.TabIndex = 40;
            this.textBox_popplerPathChoice.Text = "poppler-22.01.0\\Library\\bin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(15, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Choose path to directory -  poppler\\Library\\bin";
            // 
            // button_popplerPathSearch
            // 
            this.button_popplerPathSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.button_popplerPathSearch.Enabled = false;
            this.button_popplerPathSearch.FlatAppearance.BorderSize = 0;
            this.button_popplerPathSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_popplerPathSearch.ForeColor = System.Drawing.Color.White;
            this.button_popplerPathSearch.Location = new System.Drawing.Point(311, 416);
            this.button_popplerPathSearch.Name = "button_popplerPathSearch";
            this.button_popplerPathSearch.Size = new System.Drawing.Size(48, 21);
            this.button_popplerPathSearch.TabIndex = 42;
            this.button_popplerPathSearch.Text = "search";
            this.button_popplerPathSearch.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(5, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Optional, if you dont use enviromental variables:";
            // 
            // checkBox_useTessdataPath
            // 
            this.checkBox_useTessdataPath.AutoSize = true;
            this.checkBox_useTessdataPath.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_useTessdataPath.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_useTessdataPath.Location = new System.Drawing.Point(16, 319);
            this.checkBox_useTessdataPath.Name = "checkBox_useTessdataPath";
            this.checkBox_useTessdataPath.Size = new System.Drawing.Size(134, 17);
            this.checkBox_useTessdataPath.TabIndex = 44;
            this.checkBox_useTessdataPath.Text = "Include tessdata path ";
            this.checkBox_useTessdataPath.UseVisualStyleBackColor = true;
            this.checkBox_useTessdataPath.CheckedChanged += new System.EventHandler(this.checkBox_useTessdataPath_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(486, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "You can find me on:";
            // 
            // button_linkToYoutube
            // 
            this.button_linkToYoutube.BackgroundImage = global::Word_Finder.Properties.Resources.youtube_social_circle_red;
            this.button_linkToYoutube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_linkToYoutube.FlatAppearance.BorderSize = 0;
            this.button_linkToYoutube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_linkToYoutube.Location = new System.Drawing.Point(651, 389);
            this.button_linkToYoutube.Name = "button_linkToYoutube";
            this.button_linkToYoutube.Size = new System.Drawing.Size(40, 40);
            this.button_linkToYoutube.TabIndex = 48;
            this.button_linkToYoutube.UseVisualStyleBackColor = true;
            this.button_linkToYoutube.Click += new System.EventHandler(this.button_linkToYoutube_Click);
            // 
            // button_linkToGitHub
            // 
            this.button_linkToGitHub.BackgroundImage = global::Word_Finder.Properties.Resources.GitHub_Mark_64px;
            this.button_linkToGitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_linkToGitHub.FlatAppearance.BorderSize = 0;
            this.button_linkToGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_linkToGitHub.Location = new System.Drawing.Point(594, 389);
            this.button_linkToGitHub.Name = "button_linkToGitHub";
            this.button_linkToGitHub.Size = new System.Drawing.Size(40, 40);
            this.button_linkToGitHub.TabIndex = 46;
            this.button_linkToGitHub.UseVisualStyleBackColor = true;
            this.button_linkToGitHub.Click += new System.EventHandler(this.button_linkToGitHub_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(200)))), ((int)(((byte)(142)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.linkLabel1.Location = new System.Drawing.Point(295, 204);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(28, 13);
            this.linkLabel1.TabIndex = 50;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(159, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "your lang, download it from";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.Salmon;
            this.label12.Location = new System.Drawing.Point(159, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Not every lang in this list are installed!";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(159, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(208, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Check /tessdata folder, and if you missing";
            // 
            // label_langChoice
            // 
            this.label_langChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(92)))));
            this.label_langChoice.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_langChoice.Location = new System.Drawing.Point(10, 211);
            this.label_langChoice.Name = "label_langChoice";
            this.label_langChoice.Size = new System.Drawing.Size(146, 21);
            this.label_langChoice.TabIndex = 55;
            this.label_langChoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(715, 446);
            this.Controls.Add(this.label_langChoice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_linkToYoutube);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_linkToGitHub);
            this.Controls.Add(this.checkBox_useTessdataPath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_popplerPathSearch);
            this.Controls.Add(this.checkBox_usePopplerPath);
            this.Controls.Add(this.textBox_popplerPathChoice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox_useTesseractPath);
            this.Controls.Add(this.button_tessdataPathSearch);
            this.Controls.Add(this.textBox_tessdataPathChoice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_tesseractExePathSearch);
            this.Controls.Add(this.textBox_tesseractExePathChoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_ScriptOutput);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button_stopScript);
            this.Controls.Add(this.buttonOpenKeywordsFile);
            this.Controls.Add(this.buttonOpenSyserrFile);
            this.Controls.Add(this.buttonOpenResultsFile);
            this.Controls.Add(this.checkBox_selectFileDirectory);
            this.Controls.Add(this.flowLayoutPanel_FilesList);
            this.Controls.Add(this.buttonClearChoosedFiles);
            this.Controls.Add(this.labelAmountOfSelFiles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonFilesSearch);
            this.Controls.Add(this.button_keyWordsPathSearch);
            this.Controls.Add(this.textBox_KeyWordsPathChoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_filesDirectoryPathSearch);
            this.Controls.Add(this.checkBox_useKeywords);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.textBox_FilesPathChoice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_langChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Finder : Zigor36";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_langChoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_FilesPathChoice;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.CheckBox checkBox_useKeywords;
        private System.Windows.Forms.Button button_filesDirectoryPathSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_KeyWordsPathChoice;
        private System.Windows.Forms.Button button_keyWordsPathSearch;
        private System.Windows.Forms.Button buttonFilesSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAmountOfSelFiles;
        private System.Windows.Forms.Button buttonClearChoosedFiles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_FilesList;
        private System.Windows.Forms.CheckBox checkBox_selectFileDirectory;
        private System.Windows.Forms.Button buttonOpenResultsFile;
        private System.Windows.Forms.Button buttonOpenSyserrFile;
        private System.Windows.Forms.Button buttonOpenKeywordsFile;
        private System.Windows.Forms.Button button_stopScript;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label_ScriptOutput;
        private System.Windows.Forms.Button button_tesseractExePathSearch;
        private System.Windows.Forms.TextBox textBox_tesseractExePathChoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_tessdataPathSearch;
        private System.Windows.Forms.TextBox textBox_tessdataPathChoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_useTesseractPath;
        private System.Windows.Forms.CheckBox checkBox_usePopplerPath;
        private System.Windows.Forms.TextBox textBox_popplerPathChoice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_popplerPathSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_useTessdataPath;
        private System.Windows.Forms.Button button_linkToGitHub;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_linkToYoutube;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_langChoice;
    }
}

