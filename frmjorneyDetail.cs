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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SamplePortProject
{
    public partial class frmjorneyDetail : Form
    {
        int _ID = 0;
        
        ClsJorney jorney = new ClsJorney();
        public frmjorneyDetail(int ID)
        {
            _ID = ID;
            InitializeComponent();
        }
        public frmjorneyDetail(ClsJorney jorney)
        {
             this.jorney = jorney;
            InitializeComponent();
        }
      
        void _Upload()
        {
             
            if (jorney == null) {

                MessageBox.Show("this Jorney Didnt exist");
                this.Close();
                return;
            }
            Size buttonSize = new Size(812, 90); // Width x Height

            //Size deleteButtonSize = new Size(30, 50); // Width x Height of the delete button

            int verticalSpacing = 0; // Space between buttons

            // Starting position for the first button
            int yPosition = 74;


            DataTable db = jorney.GetAllPassengers();
           
            foreach (DataRow row in db.Rows) {
                
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
                pnlbody.Controls.Add(btn);
                yPosition += verticalSpacing + btn.Height;
                btn.Tag = row["TravelerId"];
                btn.Click += delegate
                {
                    int ID = Convert.ToInt32(btn.Tag);
                    clsTraveler traveler = clsTraveler.Find(ID);
                    frmpassengerdetails passengerdetails = new frmpassengerdetails(traveler.TravelerId);
                   
                    passengerdetails.ShowDialog();
                };

            }










        }
        void RefreshLeftTime()
        {
            TimeSpan time = jorney.Takeof_Time - DateTime.Now;
            lblHoursLeft.Text = time.Hours.ToString();
            lblDayleft.Text = time.Days.ToString();
            lblMenuteLeft.Text = time.Minutes.ToString();
            
        }
        void _UploadTravelInfo()
        {
            lblJorneyName.Text = jorney.TravelName;
            lblTime.Text = jorney.Takeof_Time.ToString();
            lblcountry.Text = ClsCountry.FindByID(jorney.CountryDirectID);
            lblCapacity.Text = jorney.PlacesCapacity.ToString();
            lblPrice.Text = jorney.TravelPrice.ToString();
            RefreshLeftTime();
        }

        private void frmjorneyDetail_Load(object sender, EventArgs e)
        {
            
            if (jorney == null && _ID != 0)
            {
                jorney = ClsJorney.Find(_ID);
               
            }
            _Upload();
            _UploadTravelInfo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshLeftTime();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbTime_Enter(object sender, EventArgs e)
        {

        }
    }
}
