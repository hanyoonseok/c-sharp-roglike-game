﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void Form12_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
