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
    public partial class frmMessage : Form
    {
        
        string _btnmessage = "Relogin";
        string _lblmessage = "You Try To refresh All Travels Time ,\r\nThat An Admin Permitions,Please RElogin";
        public frmMessage(string butonMessage,string lblmessage)
        {

            _btnmessage = butonMessage;
            _lblmessage = lblmessage;
            InitializeComponent();

        }
        public frmMessage()
        {
            
            InitializeComponent();
        }
        private void frmMessage_Load(object sender, EventArgs e)
        {
           
                button1.Text = _btnmessage;
                label1.Text = _lblmessage;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(1, 12, 24);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor= Color.White;
            button1.BackColor = Color.FromArgb(1, 12, 24);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
