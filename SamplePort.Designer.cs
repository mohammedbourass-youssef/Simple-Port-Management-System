namespace SamplePortProject
{
    partial class SamplePort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SamplePort));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTravellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btmMenu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlHOME = new System.Windows.Forms.Panel();
            this.pnlcolorline = new System.Windows.Forms.Panel();
            this.btmAboutUs = new System.Windows.Forms.Button();
            this.btmAvailableTravels = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btmAllClients = new System.Windows.Forms.Button();
            this.btm_addnewtravel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlbody = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlHOME.SuspendLayout();
            this.pnlbody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.addTravellerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 48);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            // 
            // addTravellerToolStripMenuItem
            // 
            this.addTravellerToolStripMenuItem.Name = "addTravellerToolStripMenuItem";
            this.addTravellerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addTravellerToolStripMenuItem.Text = "Add Traveller";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.button2);
            this.pnlTitle.Controls.Add(this.btmMenu);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(878, 52);
            this.pnlTitle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "CURRENT USER : ADMIN (SIR MOHAMMED YOUSSEF)";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(825, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 39);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btmMenu
            // 
            this.btmMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btmMenu.FlatAppearance.BorderSize = 2;
            this.btmMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmMenu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmMenu.ForeColor = System.Drawing.Color.White;
            this.btmMenu.Image = ((System.Drawing.Image)(resources.GetObject("btmMenu.Image")));
            this.btmMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmMenu.Location = new System.Drawing.Point(11, 7);
            this.btmMenu.Name = "btmMenu";
            this.btmMenu.Size = new System.Drawing.Size(107, 38);
            this.btmMenu.TabIndex = 4;
            this.btmMenu.Text = "HOME";
            this.btmMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmMenu.UseVisualStyleBackColor = true;
            this.btmMenu.Click += new System.EventHandler(this.btmMenu_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlHOME
            // 
            this.pnlHOME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.pnlHOME.Controls.Add(this.pnlcolorline);
            this.pnlHOME.Controls.Add(this.btmAboutUs);
            this.pnlHOME.Controls.Add(this.btmAvailableTravels);
            this.pnlHOME.Controls.Add(this.button3);
            this.pnlHOME.Controls.Add(this.btmAllClients);
            this.pnlHOME.Controls.Add(this.btm_addnewtravel);
            this.pnlHOME.Controls.Add(this.button4);
            this.pnlHOME.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHOME.Location = new System.Drawing.Point(0, 52);
            this.pnlHOME.Name = "pnlHOME";
            this.pnlHOME.Size = new System.Drawing.Size(219, 462);
            this.pnlHOME.TabIndex = 8;
            // 
            // pnlcolorline
            // 
            this.pnlcolorline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.pnlcolorline.Location = new System.Drawing.Point(0, 287);
            this.pnlcolorline.Name = "pnlcolorline";
            this.pnlcolorline.Size = new System.Drawing.Size(219, 3);
            this.pnlcolorline.TabIndex = 9;
            // 
            // btmAboutUs
            // 
            this.btmAboutUs.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btmAboutUs.FlatAppearance.BorderSize = 0;
            this.btmAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmAboutUs.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAboutUs.ForeColor = System.Drawing.Color.White;
            this.btmAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("btmAboutUs.Image")));
            this.btmAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmAboutUs.Location = new System.Drawing.Point(12, 416);
            this.btmAboutUs.Name = "btmAboutUs";
            this.btmAboutUs.Size = new System.Drawing.Size(201, 34);
            this.btmAboutUs.TabIndex = 7;
            this.btmAboutUs.Text = "About Us";
            this.btmAboutUs.UseVisualStyleBackColor = true;
            this.btmAboutUs.Click += new System.EventHandler(this.btmCheckTickets_Click);
            this.btmAboutUs.MouseEnter += new System.EventHandler(this.btmAvailableTravels_MouseEnter);
            this.btmAboutUs.MouseLeave += new System.EventHandler(this.btmAvailableTravels_MouseLeave);
            // 
            // btmAvailableTravels
            // 
            this.btmAvailableTravels.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btmAvailableTravels.FlatAppearance.BorderSize = 0;
            this.btmAvailableTravels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmAvailableTravels.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAvailableTravels.ForeColor = System.Drawing.Color.White;
            this.btmAvailableTravels.Image = ((System.Drawing.Image)(resources.GetObject("btmAvailableTravels.Image")));
            this.btmAvailableTravels.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmAvailableTravels.Location = new System.Drawing.Point(-5, 83);
            this.btmAvailableTravels.Name = "btmAvailableTravels";
            this.btmAvailableTravels.Size = new System.Drawing.Size(224, 34);
            this.btmAvailableTravels.TabIndex = 0;
            this.btmAvailableTravels.Text = "Available Travels";
            this.btmAvailableTravels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmAvailableTravels.UseVisualStyleBackColor = true;
            this.btmAvailableTravels.Click += new System.EventHandler(this.btmAvailableTravels_Click);
            this.btmAvailableTravels.MouseEnter += new System.EventHandler(this.btmAvailableTravels_MouseEnter);
            this.btmAvailableTravels.MouseLeave += new System.EventHandler(this.btmAvailableTravels_MouseLeave);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-9, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "ADD Ticket";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.btmAvailableTravels_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.btmAvailableTravels_MouseLeave);
            // 
            // btmAllClients
            // 
            this.btmAllClients.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btmAllClients.FlatAppearance.BorderSize = 0;
            this.btmAllClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmAllClients.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAllClients.ForeColor = System.Drawing.Color.White;
            this.btmAllClients.Image = ((System.Drawing.Image)(resources.GetObject("btmAllClients.Image")));
            this.btmAllClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmAllClients.Location = new System.Drawing.Point(-7, 253);
            this.btmAllClients.Name = "btmAllClients";
            this.btmAllClients.Size = new System.Drawing.Size(226, 34);
            this.btmAllClients.TabIndex = 6;
            this.btmAllClients.Text = "View All Clients";
            this.btmAllClients.UseVisualStyleBackColor = true;
            this.btmAllClients.Click += new System.EventHandler(this.btmAllClients_Click);
            this.btmAllClients.MouseEnter += new System.EventHandler(this.btmAvailableTravels_MouseEnter);
            this.btmAllClients.MouseLeave += new System.EventHandler(this.btmAvailableTravels_MouseLeave);
            // 
            // btm_addnewtravel
            // 
            this.btm_addnewtravel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btm_addnewtravel.FlatAppearance.BorderSize = 0;
            this.btm_addnewtravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_addnewtravel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_addnewtravel.ForeColor = System.Drawing.Color.White;
            this.btm_addnewtravel.Image = ((System.Drawing.Image)(resources.GetObject("btm_addnewtravel.Image")));
            this.btm_addnewtravel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_addnewtravel.Location = new System.Drawing.Point(-8, 124);
            this.btm_addnewtravel.Name = "btm_addnewtravel";
            this.btm_addnewtravel.Size = new System.Drawing.Size(227, 36);
            this.btm_addnewtravel.TabIndex = 1;
            this.btm_addnewtravel.Text = "ADD NEW TRAVEL";
            this.btm_addnewtravel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btm_addnewtravel.UseVisualStyleBackColor = true;
            this.btm_addnewtravel.Click += new System.EventHandler(this.btm_addnewtravel_Click);
            this.btm_addnewtravel.MouseEnter += new System.EventHandler(this.btmAvailableTravels_MouseEnter);
            this.btm_addnewtravel.MouseLeave += new System.EventHandler(this.btmAvailableTravels_MouseLeave);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.btmAvailableTravels_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.btmAvailableTravels_MouseLeave);
            // 
            // pnlbody
            // 
            this.pnlbody.Controls.Add(this.lblTitle);
            this.pnlbody.Controls.Add(this.pictureBox1);
            this.pnlbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlbody.Location = new System.Drawing.Point(219, 52);
            this.pnlbody.Name = "pnlbody";
            this.pnlbody.Size = new System.Drawing.Size(659, 462);
            this.pnlbody.TabIndex = 12;
            this.pnlbody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlbody_Paint_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Wide Latin", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(27, 181);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(609, 23);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "WELCOME,TO  AIRPORT SYSTEM ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 462);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SamplePort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(878, 514);
            this.ControlBox = false;
            this.Controls.Add(this.pnlbody);
            this.Controls.Add(this.pnlHOME);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SamplePort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SamplePort_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlHOME.ResumeLayout(false);
            this.pnlbody.ResumeLayout(false);
            this.pnlbody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTravellerToolStripMenuItem;
        private System.Windows.Forms.Button btmMenu;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlHOME;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btm_addnewtravel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlbody;
        private System.Windows.Forms.Button btmAllClients;
        private System.Windows.Forms.Button btmAboutUs;
        private System.Windows.Forms.Button btmAvailableTravels;
        private System.Windows.Forms.Panel pnlcolorline;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
    }
}

