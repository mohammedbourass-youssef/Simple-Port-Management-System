using BusnessLayer;
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
    public partial class SamplePort : Form
    {
        public SamplePort()
        {
            InitializeComponent();
        }

        Size ScolledSize = new Size(215, 462);
        Size statedsize = new Size(0, 462);

        private void SamplePort_Load(object sender, EventArgs e)
        {
            //pnlHOME.Size = new Size(0, 522);
            //statedsize = new Size(0, 522);
            pnlHOME.Size = ScolledSize;
        }

        private void btmAvailableTravels_Click(object sender, EventArgs e)
        {
           
            pnlHOME.Size = statedsize;
            pnlbody.Controls.Clear();
            FrmAvailableTravel frm = new FrmAvailableTravel();
            frm.TopLevel = false;
            pnlbody.Controls.Add(frm);
            frm.Dock= DockStyle.Fill;
            frm.Show();
            
           

        }

       

        private void btmMenu_Click(object sender, EventArgs e)
        {
           
            if(pnlHOME.Size == statedsize)
                pnlHOME.Size = ScolledSize;
            else
                pnlHOME.Size = statedsize;
        }
    
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int red = random.Next(0, 255);
            int green = random.Next(0,255);
            int blue = random.Next(0, 255);
            lblTitle.ForeColor = Color.FromArgb(red, green, blue);
            
        }

        private void btm_addnewtravel_Click(object sender, EventArgs e)
        {
            pnlHOME.Size = statedsize;
            pnlbody.Controls.Clear();
            FrmAddNewTravel frm = new FrmAddNewTravel();
            frm.TopLevel = false;
            pnlbody.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void pnlbody_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMessage frmMessage = new frmMessage();
            frmMessage.ShowDialog();
            frmLogin frmlogine = new frmLogin(true);
            pnlHOME.Size = statedsize;
            pnlbody.Controls.Clear();
            
            
           if(frmlogine.ShowDialog() != DialogResult.Cancel)
            {
                ClsJorney.RefreshAll();
                frmMessage = new frmMessage("OK", "Refreshed Succefully");
                frmMessage.ShowDialog();
            }
            else
            {
                frmMessage = new frmMessage("OK", "Login,Failled-refresh failled- !!!\r\nview Available travel");
                frmMessage.ShowDialog();
            }
            //after this line , will go to Available trravel
            pnlHOME.Size = statedsize;
            pnlbody.Controls.Clear();
            FrmAvailableTravel frm = new FrmAvailableTravel();
            frm.TopLevel = false;
            pnlbody.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show ("Do you want to quit Port system ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btmAllClients_Click(object sender, EventArgs e)
        {
            pnlHOME.Size = statedsize;
            pnlbody.Controls.Clear();
            frmAllClients frm = new frmAllClients();
            frm.TopLevel = false;
            pnlbody.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void pnlbody_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlHOME.Size = statedsize;
            pnlbody.Controls.Clear();
            frmAddTickets frm = new frmAddTickets();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlbody.Controls.Add(frm);
            
            frm.Show();
            
            
        }

        private void btmAvailableTravels_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            pnlcolorline.Top = btn.Bottom;
            pnlcolorline.Left = btn.Left;
            pnlcolorline.BackColor = Color.White;
            
            btn.BackColor = Color.FromArgb(1, 38, 70);
        }

        private void btmAvailableTravels_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            pnlcolorline.Top = btn.Bottom;
            pnlcolorline.Left = btn.Left;
            pnlcolorline.BackColor = Color.FromArgb(0, 12, 24);
            btn.BackColor = Color.FromArgb(0, 12, 24);
        }

        private void btmCheckTickets_Click(object sender, EventArgs e)
        {
         
            pnlHOME.Size = statedsize;
            pnlbody.Controls.Clear();
            FrmAboutUs frm = new FrmAboutUs();
            frm.TopLevel = false;
            pnlbody.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
