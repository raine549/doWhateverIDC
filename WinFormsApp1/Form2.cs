﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void checkBox1_checkChanged(object sender, EventArgs e)
        {
            MessageBox.Show("elo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button clicked");
        }

        //private void Form2_Load()
        //{

        //}
    }



}




