namespace Sims2HTMLExporter
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
            fileSystemWatcher1 = new FileSystemWatcher();
            openFileDialog1 = new OpenFileDialog();
            selectButton = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button3 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            button4 = new Button();
            textBox4 = new TextBox();
            button5 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectButton
            // 
            selectButton.Location = new Point(59, 68);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(102, 23);
            selectButton.TabIndex = 0;
            selectButton.Text = "ExportedSims";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectSimButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 50);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 1;
            label1.Text = "✔️";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(139, 226);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(286, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 229);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 3;
            label2.Text = "Neighborhood Name";
            // 
            // button1
            // 
            button1.Location = new Point(139, 255);
            button1.Name = "button1";
            button1.Size = new Size(286, 57);
            button1.TabIndex = 4;
            button1.Text = "Generate!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += generateButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(196, 21);
            label3.TabIndex = 5;
            label3.Text = "The Sims 2: HTML Exporter";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(139, 197);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(286, 23);
            textBox2.TabIndex = 6;
            // 
            // button2
            // 
            button2.ImageAlign = ContentAlignment.TopRight;
            button2.Location = new Point(22, 196);
            button2.Name = "button2";
            button2.Size = new Size(102, 23);
            button2.TabIndex = 7;
            button2.Text = "Export Folder...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ImageAlign = ContentAlignment.TopRight;
            button3.Location = new Point(8, 97);
            button3.Name = "button3";
            button3.Size = new Size(132, 23);
            button3.TabIndex = 8;
            button3.Text = "SimImage Folder...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(146, 97);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(279, 23);
            textBox3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 6F);
            label4.Location = new Point(8, 304);
            label4.Name = "label4";
            label4.Size = new Size(116, 11);
            label4.TabIndex = 10;
            label4.Text = "Created by HatfulBob 26/08/24";
            // 
            // button4
            // 
            button4.Location = new Point(258, 68);
            button4.Name = "button4";
            button4.Size = new Size(113, 23);
            button4.TabIndex = 11;
            button4.Text = "ExportedLots";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(146, 126);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(279, 23);
            textBox4.TabIndex = 13;
            // 
            // button5
            // 
            button5.ImageAlign = ContentAlignment.TopRight;
            button5.Location = new Point(8, 126);
            button5.Name = "button5";
            button5.Size = new Size(132, 23);
            button5.TabIndex = 12;
            button5.Text = "LotImage Folder...";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 50);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 14;
            label5.Text = "✔️";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 324);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(selectButton);
            Name = "Form1";
            Text = "The Sims 2 HTML Exporter";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Button selectButton;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button2;
        private TextBox textBox2;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox3;
        private Button button3;
        private Label label4;
        private Button button4;
        private TextBox textBox4;
        private Button button5;
        private Label label5;
    }
}
