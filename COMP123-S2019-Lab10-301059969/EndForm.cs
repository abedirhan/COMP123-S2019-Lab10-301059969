﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301059969
{
    public partial class EndForm : Form
    {
        public Form Parent { get; set; }
        public EndForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm mainReturn = new MainForm();
            mainReturn.Show();
            this.Hide();
            //            
            //           Program.mainForm.Show();
            //            Program.endForm.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackEndButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.MAIN_FORM].Show();
            this.Hide();

        }
    }
}
