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
    public partial class frmpassengerdetails : Form
    {
        int _ID = 0;
        public frmpassengerdetails(int ID)
        {
            _ID = ID;
            InitializeComponent();
        }
        void UploadAllInforamatiom()
        {
            clsTraveler traveler = clsTraveler.Find(_ID);
            if (traveler != null)
            {
                ClsJorney clsJorney = ClsJorney.Find(traveler.TripID);
                lblCountry.Text = ClsCountry.FindByID(traveler.CountryID);
                lblCountryDerct.Text = ClsCountry.FindByID(clsJorney.CountryDirectID);
                lblID.Text = traveler.TravelerId.ToString();
                lblName.Text = traveler.TravelerName.ToString();
                lblPassportNumber.Text = traveler.PassportNumber.ToString();
                lblTravelName.Text = clsJorney.TravelName.ToString();
            }

        }
        private void frmpassengerdetails_Load(object sender, EventArgs e)
        {
            UploadAllInforamatiom();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
