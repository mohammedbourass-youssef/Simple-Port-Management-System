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
    public partial class FrmAddNewTravel : Form
    {
        public FrmAddNewTravel()
        {
            InitializeComponent();
        }
        bool _Save()
        {
            ClsJorney jorney = new ClsJorney();
            jorney.CountryDirectID = ClsCountry.FindByName(cmCountries.Text);
            jorney.TravelPrice = (double)Price.Value;
            jorney.TravelName = tbTravelName.Text;
            jorney.PlacesCapacity =(int)PlaneCapacity.Value;
            jorney.Takeof_Time = StartDate.Value;
           return jorney.Save();
        }
        void _UploadAllCountries()
        {
            DataTable data = ClsCountry.GetAllCountries();
            foreach (DataRow row in data.Rows)
            {
                cmCountries.Items.Add(row[1]);
            }
        }
        private void FrmAddNewTravel_Load(object sender, EventArgs e)
        {
          _UploadAllCountries();

        }

        private void btmSave_Click(object sender, EventArgs e)
        {
            
            if(cmCountries.Text==string.Empty || tbTravelName.Text == string.Empty || StartDate.Value==DateTime.Now || PlaneCapacity.Value ==0 || Price.Value ==0 )
                MessageBox.Show("Some domain or more are unvalid","Something Wrong",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            else
            {
                if (MessageBox.Show("Do you want save this new travel", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                    frmProgressBar frmProgress = new frmProgressBar();
                    frmProgress.ShowDialog();
                    
                   
                   
                    if (_Save())
                    {
                        MessageBox.Show("Saved Succefully");
                    }
                    else
                    {
                        MessageBox.Show("End with some failare");
                    }

                }
            }
        }

        private void tbTravelName_MouseEnter(object sender, EventArgs e)
        {
            if (tbTravelName.Text == "TRAVEL NAME")
                tbTravelName.Text = "";
        }
        int location=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (location > 1100) 
            {
                timer1.Interval = 1;
                lblPlanes.Location = new Point(-700, 10);
                location = -700;
            }
            else
            {
                timer1.Interval = 10;
                lblPlanes.Location = new Point(location, 10);
                
                    location += 1;
            }
        }

        private void tbTravelName_MouseLeave(object sender, EventArgs e)
        {
            if (tbTravelName.Text == "")
                tbTravelName.Text = "TRAVEL NAME";
        }
    }
}
