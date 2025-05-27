namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            domainUpDown1 = new DomainUpDown();
            richTextBox1 = new RichTextBox();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(315, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Enter text here: ";
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Location = new Point(487, 169);
            button2.Name = "button2";
            button2.Size = new Size(235, 129);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 255);
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(111, 189);
            button3.Name = "button3";
            button3.Size = new Size(119, 33);
            button3.TabIndex = 4;
            button3.Text = "Go to Form 2";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(692, 406);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(94, 42);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // domainUpDown1
            // 
            domainUpDown1.BackColor = Color.FromArgb(192, 192, 255);
            domainUpDown1.Font = new Font("Stencil", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            domainUpDown1.Location = new Point(241, 117);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(127, 28);
            domainUpDown1.TabIndex = 0;
            domainUpDown1.Text = "Domain";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(221, 257);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(125, 120);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 42);
            label1.Name = "label1";
            label1.Size = new Size(436, 40);
            label1.TabIndex = 7;
            label1.Text = "this is a label im gonna type more text to see what it does out of\r\ncuriosity there was anew line there :D\r\n";
            label1.Click += label1_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(domainUpDown1);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button1;
        private DomainUpDown domainUpDown1;
        private RichTextBox richTextBox1;
        private ErrorProvider errorProvider1;
        private Label label1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
