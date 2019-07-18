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
    public partial class StartForm : Form
    {
      //  public Form Parent { get; set; }
        public StartForm()
        {
            InitializeComponent();

        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;

        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.Forms[FormName.MAIN_FORM].Show();
            this.Hide();


            //            MainForm mainForm=new MainForm();
            //            mainForm.Show();
            //            this.Hide();

//            Program.mainForm.Show();
//            Program.startForm.Hide();
        }

        //        private void NextButton_Click(object sender, EventArgs e)
        //        {
        //            Program.Forms[FormName.MAIN_FORM].Show();
        //            this.Hide();
        //        }
    }
}
