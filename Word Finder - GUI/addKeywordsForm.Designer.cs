namespace Word_Finder
{
    partial class addKeywordsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_FilesPathChoice = new System.Windows.Forms.TextBox();
            this.buttonFileFolderSearch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel_FilesList = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_FilesPathChoice
            // 
            this.textBox_FilesPathChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.textBox_FilesPathChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_FilesPathChoice.Enabled = false;
            this.textBox_FilesPathChoice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_FilesPathChoice.ForeColor = System.Drawing.Color.White;
            this.textBox_FilesPathChoice.Location = new System.Drawing.Point(12, 55);
            this.textBox_FilesPathChoice.Name = "textBox_FilesPathChoice";
            this.textBox_FilesPathChoice.Size = new System.Drawing.Size(160, 21);
            this.textBox_FilesPathChoice.TabIndex = 6;
            // 
            // buttonFileFolderSearch
            // 
            this.buttonFileFolderSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.buttonFileFolderSearch.Enabled = false;
            this.buttonFileFolderSearch.FlatAppearance.BorderSize = 0;
            this.buttonFileFolderSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileFolderSearch.ForeColor = System.Drawing.Color.White;
            this.buttonFileFolderSearch.Location = new System.Drawing.Point(178, 55);
            this.buttonFileFolderSearch.Name = "buttonFileFolderSearch";
            this.buttonFileFolderSearch.Size = new System.Drawing.Size(47, 21);
            this.buttonFileFolderSearch.TabIndex = 9;
            this.buttonFileFolderSearch.Text = "add";
            this.buttonFileFolderSearch.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(15, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 24);
            this.button3.TabIndex = 27;
            this.button3.Text = "Open keywords";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel_FilesList
            // 
            this.flowLayoutPanel_FilesList.AutoScroll = true;
            this.flowLayoutPanel_FilesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.flowLayoutPanel_FilesList.Location = new System.Drawing.Point(12, 101);
            this.flowLayoutPanel_FilesList.Name = "flowLayoutPanel_FilesList";
            this.flowLayoutPanel_FilesList.Size = new System.Drawing.Size(213, 138);
            this.flowLayoutPanel_FilesList.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last added:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(121, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 24);
            this.button1.TabIndex = 29;
            this.button1.Text = "Clear keywords file";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // addKeywordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(238, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel_FilesList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonFileFolderSearch);
            this.Controls.Add(this.textBox_FilesPathChoice);
            this.Name = "addKeywordsForm";
            this.Text = "Add keyword";
            this.Load += new System.EventHandler(this.addKeywordsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FilesPathChoice;
        private System.Windows.Forms.Button buttonFileFolderSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_FilesList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}