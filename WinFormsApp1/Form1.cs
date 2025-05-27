using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            domainUpDown1.Items.Add("Item numero uno");
            domainUpDown1.Items.Add("heres smthg else");
            domainUpDown1.Items.Add("object 3");

            //button2.Visible = false; //make adjustments here

            //domainUpDown1.SelectedIndex = 0;
            //MessageBox.Show(domainUpDown1.Items[domainUpDown1.SelectedIndex].ToString());



            //interactive design resize buttons
            InitializeComponent();
            this.Resize += new EventHandler(Form1_Resize);
            AdjustButtonSize();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustButtonSize();
        }

        private void AdjustButtonSize()
        {
            //20% of forms width and height
            button1.Width = (int)(this.ClientSize.Width * 0.2);
            button1.Height = (int)(this.ClientSize.Height * 0.2);

            // Center the button
            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
            button1.Top = (this.ClientSize.Height - button1.Height) / 2;
        }

        //paint event from button:
        private void button1_Paint(object sender, PaintEventArgs e)
        {
            float fontSize = NewFontSize(e.Graphics, button1.Size, button1.Font, button1.Text);

            // set font with Font Class and the returned Size from NewFontSize();
            Font f = new Font("Arial", fontSize, FontStyle.Bold);
            button1.Font = f;
        }

        // method to calculate the size for the font:
        public static float NewFontSize(Graphics graphics, Size size, Font font, string str)
        {
            SizeF stringSize = graphics.MeasureString(str, font);
            float wRatio = size.Width / stringSize.Width;
            float hRatio = size.Height / stringSize.Height;
            float ratio = Math.Min(hRatio, wRatio);
            return font.Size * ratio;
        }


        //public string userInput()
        //{

        //    string textBoxContents = textBox1.Text;

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the button");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox1 = new TextBox();
            textBox1.BackColor = Color.Red;
            textBox1.Multiline = true;
            textBox1.AppendText("Appended text");

            //In a Multiline TextBox control, you need to press CTRL+ENTER to create a new line. The AcceptsReturn property sets TextBox control to move to a new line by simply pressing ENTER key. By default, the AcceptsReturn property of a TextBox control is false

            textBox1.AcceptsReturn = true;
            textBox1.WordWrap = true;

            string textBoxContents = textBox1.Text;

            if (textBoxContents.Contains("\n"))
            {
                MessageBox.Show(textBoxContents);
                textBox1.Clear();
            }
        }

        public void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1 = new TextBox();
            textBox1.Clear();
            textBox1.BackColor = Color.Red;
            textBox1.Multiline = true;


            //In a Multiline TextBox control, you need to press CTRL+ENTER to create a new line. The AcceptsReturn property sets TextBox control to move to a new line by simply pressing ENTER key. By default, the AcceptsReturn property of a TextBox control is false

            textBox1.AcceptsReturn = true;
            textBox1.WordWrap = true;
            string textBoxContents = textBox1.Text;

            if (textBoxContents.Contains("\n"))
            {
                MessageBox.Show(textBoxContents);
                textBox1.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var message = "Yes or No?";
            var title = "Hey!";
            var result = MessageBox.Show(
                message,                  // the message to show
                title,                    // the title for the dialog box
                MessageBoxButtons.YesNo,  // show two buttons: Yes and No
                MessageBoxIcon.Question); // show a question mark icon

            // the following can be handled as if/else statements as well
            switch (result)
            {
                case DialogResult.Yes:   // Yes button pressed
                    MessageBox.Show("You pressed Yes!");
                    break;
                case DialogResult.No:    // No button pressed
                    MessageBox.Show("You pressed No!");
                    break;
                default:                 // Neither Yes nor No pressed (just in case)
                    MessageBox.Show("What did you press?");
                    break;
            }




            MessageBox.Show("smthg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        //private void CreateButton()
        //{
        //    button1 = new Button();
        //    button1.FlatAppearance.BorderSize = 0;
        //    button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
        //    button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
        //    button1.FlatStyle = FlatStyle.Flat;
        //    button1.ForeColor = BackColor;
        //    button1.Location = new Point(197, 226); //Give your own location as needed
        //    button1.Name = "button1";
        //    button1.Size = new Size(75, 23);
        //    button1.TabIndex = 0;
        //    button1.Text = "button1";
        //    button1.UseVisualStyleBackColor = true;
        //    button1.Click += this.button1_Click;
        //    Controls.Add(button1);
        //}
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("clicked");
        //}



    }
}
