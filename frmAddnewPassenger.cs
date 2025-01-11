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
using System.Windows.Forms.VisualStyles;

namespace SamplePortProject
{
    public partial class frmAddnewPassenger : Form
    {
        int _ID = 0;
        int _TicketID= 0;   
        ClsJorney jorney=null;
        public frmAddnewPassenger()
        {
            
            InitializeComponent();
        }
        public frmAddnewPassenger(ClsJorney jorney)
        {
           this.jorney = jorney;
            InitializeComponent();
        }
        bool _SaveInfo()
        {
            clsTraveler traveler = new clsTraveler();
            traveler.TravelerName = tbTravellerName.Text;
            traveler.PassportNumber = tbPassportNumber.Text;
            traveler.CountryID = ClsCountry.FindByName(cmboxCountry.Text);
            traveler.TripID = jorney.TravelID;

            traveler.Save();
            traveler = clsTraveler.Find(tbPassportNumber.Text);
            ClsPAyements ayements = new ClsPAyements();
            ayements.Amount = jorney.TravelPrice;
            int ID=ayements.Save();
            ayements =  ClsPAyements.Find(ID);
            clsTikets Tiket = new clsTikets(); 
            Tiket.TripID = jorney.TravelID;
            Tiket.Payement = ayements.PayementID;
            Tiket.TravelerID = traveler.TravelerId;
            DataTable dt = jorney.GetAllPassengers();
            Tiket.PlaceNumber = dt.Rows.Count;
            
            return Tiket.SaveInfo(ref _TicketID);
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void frmAddnewPassenger_Load(object sender, EventArgs e)
        {
            
            if (jorney == null || _ID != 0)
            {
                jorney = ClsJorney.Find(_ID);
            }
                
            else
            {
                lblTitle.Text = jorney.TravelName;
                cbArriveCountry.Text = ClsCountry.FindByID(jorney.CountryDirectID);
                DataTable dt = ClsCountry.GetAllCountries();
                foreach (DataRow dr in dt.Rows)
                {
                    cmboxCountry.Items.Add(dr["CountryName"]);
                  
                }
            }
        }

        private void btmSave_Click(object sender, EventArgs e)
        {
            if(cmboxCountry.Text != string.Empty || tbTravellerName.Text != "Name Here" || tbPassportNumber.Text !=string.Empty)
            {
                if (MessageBox.Show("do you want to save this infomation", "Waring", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmProgressBar frmr = new frmProgressBar();
                    frmr.ShowDialog();
                    if (_SaveInfo())
                    {
                        MessageBox.Show("Traveller Saved Succefully");
                       
                        frmProgressBar progressBar = new frmProgressBar("Wait , System Generate Your Tickets");
                        progressBar.ShowDialog();
                        frmTicketInfo info = new frmTicketInfo(_TicketID);
                        info.ShowDialog();
                        
                    }
                    else
                        MessageBox.Show("SORRY , SomeThing Wrong,Its Not You Its US ,Please Wait us to fix it");
                }
            }
                
        }

        private void tbTravellerName_MouseEnter(object sender, EventArgs e)
        {
            if(tbTravellerName.Text == "Name Here")
                tbTravellerName.Text = string.Empty;
        }

        private void tbTravellerName_MouseLeave(object sender, EventArgs e)
        {
            if (tbTravellerName.Text == string.Empty)
                tbTravellerName.Text = "Name Here";
        }

        private void tbPassportNumber_MouseEnter(object sender, EventArgs e)
        {
            if( tbPassportNumber.Text == "Passport Number")
                tbPassportNumber.Text = string.Empty;
        }

        private void tbPassportNumber_MouseLeave(object sender, EventArgs e)
        {
            if (tbPassportNumber.Text == string.Empty)
                tbPassportNumber.Text = "Passport Number";
        }

        private void tbTravellerName_Click(object sender, EventArgs e)
        {
            TextBox text= (TextBox)sender;  
            pnlcolor.Left = text.Left;
            pnlcolor.Top = text.Bottom;
            pnlcolor.BackColor = Color.White;

        }
    }
}
