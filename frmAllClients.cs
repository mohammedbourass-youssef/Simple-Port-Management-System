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
    public partial class frmAllClients : Form
    {
        public frmAllClients()
        {
            InitializeComponent();
        }
        void UploadClientsList()
        {

            Size buttonSize = new Size(812, 90); // Width x Height

            //Size deleteButtonSize = new Size(30, 50); // Width x Height of the delete button

            int verticalSpacing = 0; // Space between buttons

            // Starting position for the first button
            int yPosition = 74;

            DataTable olddata = clsTraveler.GetAllPassengers();
            foreach (DataRow row in olddata.Rows)
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
                pnlAllClients.Controls.Add(btn);
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
        private void frmAllClients_Load(object sender, EventArgs e)
        {
            UploadClientsList();
        }

        private void DGVAllClients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Passport number")
                textBox1.Text = "";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "Passport number";
        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "Passport number" || textBox1.Text !=string.Empty)
            {

                clsTraveler traveler = clsTraveler.Find(textBox1.Text);
                if(traveler != null)
                {
                    frmpassengerdetails frm = new frmpassengerdetails(traveler.TravelerId);
                    frm.ShowDialog();
                }
                else
                {
                    if (MessageBox.Show("Unvalid Passport Number OR this client Doest Exist !!,\n do you want to ADD this Client ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmProgressBar frmProgressBar = new frmProgressBar();
                        frmProgressBar.ShowDialog();
                        frmAddnewPassenger passenger = new frmAddnewPassenger();
                        passenger.ShowDialog();
                    }
                }
                textBox1.Text = "Passport number";

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
