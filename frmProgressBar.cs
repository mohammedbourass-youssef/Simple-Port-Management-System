using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamplePortProject
{
    public partial class frmProgressBar : Form
    {
        
        public frmProgressBar()
        {
            
            InitializeComponent();
        }
        public frmProgressBar(string Message)
        {
           
            InitializeComponent();
            label1.Text = Message;
        }
        int x = 19;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x == 99)
                this.Close();
            else
            {
                x += 20;
                progressBar1.Value = x;
            }
           
           
            
        }

        private void frmProgressBar_Load(object sender, EventArgs e)
        {
            
        }
    }
}
