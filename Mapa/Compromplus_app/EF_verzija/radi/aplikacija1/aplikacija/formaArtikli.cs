﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikacija
{
    public partial class formaArtikli : Form
    {
        public formaArtikli()
        {
            InitializeComponent();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
