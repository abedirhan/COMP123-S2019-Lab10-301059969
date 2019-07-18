using System;
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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

//        private void NextButton_Click(object sender, EventArgs e)
//        {EndForm endForm =new EndForm();
//            endForm.Show();
//            this.Hide();
//;
//        }
//
//        private void CloseButton_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms["StartForm"].Show();
            this.Hide();
        }

        private void NextButton1_Click(object sender, EventArgs e)
        {
            Program.Forms["EndForm"].Show();
            this.Hide();
        }
    }
}
