﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compromplus_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

         
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Form1 browseOrdersFrom = new Form1();
            browseOrdersFrom.MdiParent = this; //postavlja prozor kao djete od frmMain
            browseOrdersFrom.WindowState = FormWindowState.Maximized;
            browseOrdersFrom.Show();
        }
    }
}