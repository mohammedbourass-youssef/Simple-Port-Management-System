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
    public partial class FrmAvailableTravel : Form
    {
        public FrmAvailableTravel()
        {
            InitializeComponent();
        }
        void UploadJourneys()
        {
            Size buttonSize = new Size(812, 63); // Width x Height

            //Size deleteButtonSize = new Size(30, 50); // Width x Height of the delete button

            int verticalSpacing = 0; // Space between buttons

            // Starting position for the first button
            int yPosition = 74;

            DataTable olddata = ClsJorney.GetAllJourneys();

            // Loop through dtTrips and create a button for each trip
            foreach (DataRow row in olddata.Rows)
            {
                // Create a button for each trip
                Button btn = new Button
                {
                    Text = $"{row["TravelName"]}\nStart Date: {Convert.ToDateTime(row["Takeof_Time"]).ToString("D")}",
                    Size = buttonSize,
                    Dock = DockStyle.Top,
                    Location = new Point(10, yPosition), // Set the location of the button
                    Margin = new Padding(10), // Space around the button
                    TextAlign = ContentAlignment.MiddleLeft, // Align text to the left
                    BackColor = Color.FromArgb(1, 38, 70),   // Button background color
                    ForeColor = Color.White, // Button text color
                    Font = new Font("Segoe UI", 14, FontStyle.Bold), // Font for the button text
                    FlatStyle = FlatStyle.Flat, // Remove button border
                    FlatAppearance = { BorderSize = 0}, // Remove button border
                    ContextMenuStrip = contextMenuStrip1,
                    
                };
                pnlAvailable.Controls.Add(btn);
                yPosition += verticalSpacing + btn.Height;
                btn.Tag = row["TravelID"];
                btn.Click += delegate
                {
                    int ID = Convert.ToInt32(btn.Tag);
                    ClsJorney jorney = ClsJorney.Find(ID);
                    frmjorneyDetail detail = new frmjorneyDetail(jorney);
                    detail.ShowDialog();
                };
                btn.MouseUp += delegate
                {
                    contextMenuStrip1.Tag = btn.Tag;
                };

            }
        }
        private void FrmAvailableTravel_Load(object sender, EventArgs e)
        {
            UploadJourneys();
           
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            int ID = Convert.ToInt32(contextMenuStrip1.Tag);
            ClsJorney jorney = ClsJorney.Find(ID);
            frmjorneyDetail detail = new frmjorneyDetail(jorney);
            detail.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            int ID = Convert.ToInt32(contextMenuStrip1.Tag);
            ClsJorney jorney = ClsJorney.Find(ID);
            frmAddnewPassenger newTravel = new frmAddnewPassenger(jorney);
            
            newTravel.ShowDialog();
            

        }

        

        private void SmallTitle_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Name")
                textBox1.Text = "";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "Name";
        }
        private void btmSearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Passport number" || textBox1.Text != string.Empty)
            {
                ClsJorney jorney = ClsJorney.Find(textBox1.Text);
                if (jorney != null)
                {
                    frmProgressBar frmProgressBar = new frmProgressBar();
                    frmProgressBar.ShowDialog();
                    frmjorneyDetail detail = new frmjorneyDetail(jorney);
                    detail.ShowDialog();
                }
                else
                    MessageBox.Show("Unvalid Name OR this Travel Doest Exist  ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                textBox1.Text = "Name";
            }
        }
    }
}
