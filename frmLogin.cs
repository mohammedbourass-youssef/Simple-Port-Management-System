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
    public partial class frmLogin : Form
    {
        bool _IsInterierur=false;
        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(bool not)
        {
            _IsInterierur=not;
            InitializeComponent();
        }
        private void tbUsername_Click(object sender, EventArgs e)
        {
            TextBox Text = (TextBox)sender;
            pnlWorker.Top = Text.Bottom;
            pnlWorker.BackColor = Color.White;
           
            pnlWorker.Top = Text.Bottom;
            pnlWorker.BackColor = Color.White;
            if (Text.Text == "USERNAME" || Text.Text == "Password")
                Text.Text = string.Empty;
        }
        //You can use this Code When You want to cancel error provider
        private void tbUsername_MouseLeave(object sender, EventArgs e)
        {

            //TextBox Text = (TextBox)sender;
            //if (Text.Text == string.Empty)
            //{
            //  Text.Text = Text.Tag.ToString();
            //}


           // pnlWorker.BackColor = Color.FromArgb(1, 30, 70);
        }

        private void pnlWorker_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            btmLogin.BackColor = Color.White;
            btmLogin.ForeColor = Color.FromArgb(1, 30, 70);
        }

        private void btmLogin_MouseLeave(object sender, EventArgs e)
        {
            btmLogin.ForeColor = Color.White;
            btmLogin.BackColor = Color.FromArgb(1, 30, 70);
        }
        bool Cancel = false;
        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            errorProvider1 = null;
            Cancel = true;
            this.Close();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (!chShowPassword.Checked&&tbPassword.Text!=tbPassword.Tag.ToString())
            {
                tbPassword.PasswordChar = '*';
            }
            
        }

        private void chShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!chShowPassword.Checked)
            {
                tbPassword.PasswordChar = '*';
            }
            else
                tbPassword.PasswordChar='\0';
        }

        private void btmLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
            frmProgressBar frmProgressBar = new frmProgressBar("Loading");
            frmProgressBar.ShowDialog();
            if (tbPassword.Text == "Admin" && tbUsername.Text == "Admin")
            {
                if (_IsInterierur)
                {
                    this.Close();
                }
                else
                {
                    this.Hide();
                    SamplePort port = new SamplePort();
                    port.ShowDialog();
                    this.Close();
                }
                
            }
            else
            {
                if (MessageBox.Show("Password/UserName Incorrect !!,\nTry Again ?", "Login Failled", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                }
                else
                    this.Close();
            }
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            TextBox Text = (TextBox)sender;
            if (!Cancel)
            {
                if (Text.Text == "USERNAME" || Text.Text == "Password" || string.IsNullOrWhiteSpace(Text.Text))
                {
                    e.Cancel = true;
                    Text.Focus();
                    errorProvider1.SetError(Text, "Required Information");
                }

            }
            
                
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            TextBox Text = (TextBox)sender;
            pnlWorker.Top = Text.Bottom;
            pnlWorker.BackColor = Color.White;

            pnlWorker.Top = Text.Bottom;
            pnlWorker.BackColor = Color.White;
            if (Text.Text == "USERNAME" || Text.Text == "Password")
                Text.Text = string.Empty;
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            TextBox Text = (TextBox)sender;
            if (Text.Text == string.Empty)
            {
                Text.Text = Text.Tag.ToString();
            }
        }

        private void pass_MouseLeave(object sender, EventArgs e)
        {
            TextBox Text = (TextBox)sender;
            if (Text.Text == string.Empty&&tbUsername.Text=="")
            {
                Text.PasswordChar = '\0';
                Text.Text = Text.Tag.ToString();
            }
        }
    }
}
