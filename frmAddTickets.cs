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
    public partial class frmAddTickets : Form
    {
        ClsPAyements _payements=null;
        ClsJorney _jorney=null;
        clsTraveler _traveler=null;
        clsTikets _tikets=null;
        int _CurrentPlace =0;
        public int ID { get; set; }
        
        public frmAddTickets()
        {
            InitializeComponent();
        }
        
        void FillCountries()
        {
            DataTable dt = ClsCountry.GetAllCountries();
            foreach (DataRow dr in dt.Rows)
            {
                cmboxCountry.Items.Add(dr["CountryName"]);
                
            }
            dt = ClsJorney.GetAllJourneys();
            string CountryName = "";
            foreach (DataRow dr in dt.Rows)
            {
                CountryName = ClsCountry.FindByID((int)dr["CountryDirect"]);
               
                cmDerection.Items.Add(CountryName);

            }
            
        }
        void LoadAddClientPage()
        {
           
            _traveler = new clsTraveler();
           _traveler.TravelerName=tbTravellerName.Text;
           _traveler.PassportNumber=tbPassportNumber.Text;
           _traveler.CountryID = ClsCountry.FindByName(cmboxCountry.Text);
           _traveler.TripID=_jorney.TravelID;
            if (_traveler.Save())
            {
                _traveler = clsTraveler.Find(_traveler.PassportNumber);
            }
        }
        void UploadTheJorneyDetails()
        {
            _jorney = ClsJorney.Find(cmAvailableTravels.Text);
            if (_jorney == null)
            {

                MessageBox.Show("this Jorney Didnt exist");

                return;
            }
            tbPrice.Text = _jorney.TravelPrice.ToString();
            pnlTripInfo.Visible = true;
            lblCapacity.Text = _jorney.PlacesCapacity.ToString();
            lblTime.Text = _jorney.Takeof_Time.ToString();
           
            Size buttonSize = new Size(812, 90); // Width x Height

            //Size deleteButtonSize = new Size(30, 50); // Width x Height of the delete button

            int verticalSpacing = 0; // Space between buttons

            // Starting position for the first button
            int yPosition = 74;
            DataTable db = _jorney.GetAllPassengers();
                pnlBody.Controls.Clear();
                foreach (DataRow row in db.Rows)
                {
                   
                Button btn = new Button
                {
                    Text = $"{row["PassportNumber"]}\n{row["TravelerName"]}\n{ClsCountry.FindByID((int)row["CountryID"])}",
                    Size = buttonSize,
                    Dock = DockStyle.Top,
                    Location = new Point(10, yPosition), // Set the location of the button
                    Margin = new Padding(10), // Space around the button
                    TextAlign = ContentAlignment.MiddleLeft, // Align text to the left
                    BackColor = Color.FromArgb(1, 38, 70),   // Button background color
                    ForeColor = Color.White, // Button text color
                    Font = new Font("Segoe UI", 14, FontStyle.Bold), // Font for the button text
                    FlatStyle = FlatStyle.Flat, // Remove button border
                    FlatAppearance = { BorderSize = 0 }, // Remove button border
                    

                };
                pnlBody.Controls.Add(btn);
                yPosition += verticalSpacing + btn.Height;
                btn.Tag = row["TravelerId"];
                btn.Click += delegate
                {
                    int ID = Convert.ToInt32(btn.Tag);
                    clsTraveler traveler = clsTraveler.Find(ID);
                    frmpassengerdetails passengerdetails = new frmpassengerdetails(traveler.TravelerId);
                    passengerdetails.ShowDialog();
                };
                _CurrentPlace++;
            }
                
            
        }
        void RefreshAvailableTravels()
        {
            int Country = ClsCountry.FindByName(cmDerection.Text);
            DataTable dt = ClsJorney.GetAllJourneys();
            cmAvailableTravels.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                if ((int)dr["CountryDirect"] == Country)
                {
                    bool Found = false;
                    foreach (string dr2 in cmAvailableTravels.Items)
                    {
                        if ((string)dr["TravelName"] == dr2)
                        {
                            Found = true;
                            break;
                        }
                    }
                    if (!Found)
                    {
                        cmAvailableTravels.Items.Add((string)dr["TravelName"]);
                    }
                }

            }
            cmAvailableTravels.SelectedIndex= 0;
            
        }
       
        private void frmAddTickets_Load(object sender, EventArgs e)
        {
            pnlTripInfo.Visible = false;
            FillCountries();
            
        }
        private void tbTravellerName_MouseEnter(object sender, EventArgs e)
        {
            if (tbTravellerName.Text == "Name Here")
                tbTravellerName.Text = string.Empty;
        }

        private void tbTravellerName_MouseLeave(object sender, EventArgs e)
        {
            if (tbTravellerName.Text == string.Empty)
                tbTravellerName.Text = "Name Here";
        }
        private void tbPassportNumber_MouseEnter(object sender, EventArgs e)
        {
            if (tbPassportNumber.Text == "Passport Number")
                tbPassportNumber.Text = string.Empty;
        }

        private void tbPassportNumber_MouseLeave(object sender, EventArgs e)
        {
            if (tbPassportNumber.Text == string.Empty)
                tbPassportNumber.Text = "Passport Number";
        }

        private void cmDerection_TextChanged(object sender, EventArgs e)
        {
            
            RefreshAvailableTravels();
        }

        private void btmSave_Click(object sender, EventArgs e)
        {
            if (btmPay.Enabled||tbPassportNumber.Text== "Passport Number"|| tbPassportNumber.Text == String.Empty||tbTravellerName.Text== "Name Here"||
                tbTravellerName.Text == string.Empty)
            {
                MessageBox.Show("Many Information unvalid,Check again");
            }
            else
            {
                LoadAddClientPage();
                _tikets = new clsTikets();
                _tikets.TravelerID = _traveler.TravelerId;
                _tikets.Payement = _payements.PayementID;
                _tikets.TripID = _jorney.TravelID;
                _tikets.PlaceNumber = _CurrentPlace+1;
                int identity = 0;
                if (_tikets.SaveInfo(ref identity))
                {
                    frmProgressBar frm = new frmProgressBar("Please Wait to generate a TICKET");
                    
                    frm.ShowDialog();
                    frmTicketInfo info = new frmTicketInfo(identity);
                    info.ShowDialog();
                    btmSave.Enabled = false;
                    btmSave.Text = "Thanks for your confidence!";
                    btmSave.Image = Image.FromFile("C:\\Users\\USER\\Downloads\\icons8-filled-bookmark-ribbon-40.png");
                }
                else
                    MessageBox.Show("ERROR 404!!!");
            }
        }

        private void cmAvailableTravels_TextChanged(object sender, EventArgs e)
        {
            UploadTheJorneyDetails();
          
               
        }

        private void cmDerection_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
            RefreshAvailableTravels();
        }

        private void btmPay_Click(object sender, EventArgs e)
        {
            if (tbPrice.Text != string.Empty)
            {
                _payements = new ClsPAyements();
                _payements.Amount = Convert.ToDouble(tbPrice.Text);
                int lastID = _payements.Save();
              
               _payements = ClsPAyements.Find(lastID);
                btmPay.Enabled = false;
                pbCorrect.Visible = true;
                pbpay.Visible = false;
            }

        }

        private void frmAddTickets_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void cmAvailableTravels_SelectedIndexChanged(object sender, EventArgs e)
        {
            UploadTheJorneyDetails();
        }
    }
}
