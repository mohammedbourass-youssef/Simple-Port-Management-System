using BusnessLayer;
using PdfSharp;
using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using PdfSharp.UniversalAccessibility.Drawing;

namespace SamplePortProject
{
    public partial class frmTicketInfo : Form
    {
        int TicketNumber = 0;
        clsTikets _tiket = null;
        public frmTicketInfo(int iD)
        {
            TicketNumber = iD;
            InitializeComponent();
           
        }
        void UploadTravellerInformation()
        {
            clsTraveler traveler = clsTraveler.Find(_tiket.TravelerID);
            lblPassportNumber.Text = traveler.PassportNumber;
            lblName.Text = traveler.TravelerName;
            SystemSounds.Beep.Play();
        }
        void UploadTravelName()
        {
            ClsJorney jorney = ClsJorney.Find(_tiket.TripID);
            lblTravelNAme.Text = jorney.TravelName;
            lblDirection.Text = ClsCountry.FindByID(jorney.CountryDirectID);
            lblStartTime.Text = jorney.Takeof_Time.ToString();
        }
        void UploadPayement()
        {
            ClsPAyements payement = ClsPAyements.Find(_tiket.Payement);
            lblamount.Text = payement.Amount.ToString();
            
        }
        private void frmTicketInfo_Load(object sender, EventArgs e)
        {
           lblticketID.Text = TicketNumber.ToString();
            _tiket = clsTikets.Find(TicketNumber);
            UploadTravellerInformation();
            UploadTravelName();
            UploadPayement();
            lblPNumber.Text = _tiket.PlaceNumber.ToString();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.ShowBalloonTip(1000, "File Dowloaded sccefully", "Tap To view", ToolTipIcon.Info);
           
        }
        //by mohammed bourass 
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(1, 38, 70);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(1, 12, 24);
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Formatted Ticket Information";

            // Create an empty page
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Set up fonts
            XFont textFont = new XFont("Verdana", 12);

            // Simulate your message with tabs and new lines
            string msj = "\t\t\t\tTicketID : " + lblticketID + "\tFull Name : " + lblName + "\tPassport Number : " + lblPassportNumber
            + "\nTravel Name : " + lblTravelNAme + "\tStart Time : " + lblStartTime + "\tAmount : " + lblamount +
            "\n\tPlace Number : " + lblPNumber + "\n\n\n\tBy Mohammed Bourass";


            double yPoint = 80;

            XPen pen = new XPen(XColor.FromArgb(0, 0, 0), 5);

            gfx.DrawString("App Devlopped by BOURASS MOHAMMED", textFont, XBrushes.Black, new XPoint(200, 30));
            gfx.DrawLine(pen,0,44,600,44);
            gfx.DrawString("TicketID        : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblticketID.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Full Name       : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblName.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            
            
            yPoint += 20;
            gfx.DrawString("Passport Number : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblPassportNumber.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Travel Name     : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblTravelNAme.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Start Time      : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblStartTime.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Amount    ¨     : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblamount.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            yPoint += 20;
            gfx.DrawString("Place Number     : ", textFont, XBrushes.Black, new XPoint(10, yPoint));
            gfx.DrawString(lblPNumber.Text, textFont, XBrushes.Black, new XPoint(160, yPoint));
            

            string imagePath = @"C:\Users\USER\Pictures\Screenshots\Screenshot 2024-09-14 183028.png";
            XImage img = XImage.FromFile(imagePath);
            gfx.DrawImage(img, 300,60, 300, 150);
            gfx.DrawLine(pen, 0, 220, 600, 220);
            // Save the document
            string filename = "C:\\Users\\USER\\Downloads\\TicketOfClientNumber" + lblticketID.Text+ ".pdf";
            document.Save(filename);
            
            // Open the created PDF (optional)
            Process.Start(filename);
        }
    }
}
