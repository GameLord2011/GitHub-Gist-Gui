namespace GitHub_Gist_Gui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            isPublic = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            addFiles = new Button();
            filesList = new ListBox();
            pat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            createGist = new Button();
            SuspendLayout();
            // 
            // isPublic
            // 
            isPublic.AutoSize = true;
            isPublic.Location = new Point(12, 12);
            isPublic.Name = "isPublic";
            isPublic.Size = new Size(59, 19);
            isPublic.TabIndex = 0;
            isPublic.Text = "Public";
            isPublic.UseVisualStyleBackColor = true;
            isPublic.CheckedChanged += isPublic_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "files";
            // 
            // addFiles
            // 
            addFiles.Location = new Point(12, 37);
            addFiles.Name = "addFiles";
            addFiles.Size = new Size(75, 23);
            addFiles.TabIndex = 1;
            addFiles.Text = "Add File(s)";
            addFiles.UseVisualStyleBackColor = true;
            addFiles.Click += addFiles_Click;
            // 
            // filesList
            // 
            filesList.FormattingEnabled = true;
            filesList.ItemHeight = 15;
            filesList.Location = new Point(12, 66);
            filesList.Name = "filesList";
            filesList.Size = new Size(776, 124);
            filesList.TabIndex = 2;
            // 
            // pat
            // 
            pat.Location = new Point(138, 196);
            pat.Name = "pat";
            pat.Size = new Size(650, 23);
            pat.TabIndex = 3;
            pat.TextChanged += pat_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 204);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 4;
            label1.Text = "Personal Acess Token";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 231);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 258);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Description";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(731, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 255);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(703, 23);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // createGist
            // 
            createGist.Location = new Point(12, 392);
            createGist.Name = "createGist";
            createGist.Size = new Size(102, 46);
            createGist.TabIndex = 9;
            createGist.Text = "Create Gist";
            createGist.UseVisualStyleBackColor = true;
            createGist.Click += createGist_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createGist);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pat);
            Controls.Add(filesList);
            Controls.Add(addFiles);
            Controls.Add(isPublic);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox isPublic;
        private OpenFileDialog openFileDialog1;
        private Button addFiles;
        private ListBox filesList;
        private TextBox pat;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button createGist;
    }
}
