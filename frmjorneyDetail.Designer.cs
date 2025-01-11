namespace SamplePortProject
{
    partial class frmjorneyDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmjorneyDetail));
            this.lblJorneyName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlbody = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnltitle = new System.Windows.Forms.Panel();
            this.pnlMiddletitle = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDayleft = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMenuteLeft = new System.Windows.Forms.Label();
            this.lblHoursLeft = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcountry = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnltitle.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJorneyName
            // 
            this.lblJorneyName.AutoSize = true;
            this.lblJorneyName.Font = new System.Drawing.Font("Arial", 24.192F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblJorneyName.ForeColor = System.Drawing.Color.White;
            this.lblJorneyName.Location = new System.Drawing.Point(263, 7);
            this.lblJorneyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJorneyName.Name = "lblJorneyName";
            this.lblJorneyName.Size = new System.Drawing.Size(230, 38);
            this.lblJorneyName.TabIndex = 0;
            this.lblJorneyName.Text = "Jorney Name ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.pnlbody);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 522);
            this.panel1.TabIndex = 17;
            // 
            // pnlbody
            // 
            this.pnlbody.AutoScroll = true;
            this.pnlbody.Location = new System.Drawing.Point(214, 71);
            this.pnlbody.Name = "pnlbody";
            this.pnlbody.Size = new System.Drawing.Size(519, 443);
            this.pnlbody.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 21.888F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(396, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Passengers";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(11, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 35);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnltitle
            // 
            this.pnltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.pnltitle.Controls.Add(this.lblJorneyName);
            this.pnltitle.Controls.Add(this.button1);
            this.pnltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltitle.Location = new System.Drawing.Point(0, 0);
            this.pnltitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnltitle.Name = "pnltitle";
            this.pnltitle.Size = new System.Drawing.Size(736, 58);
            this.pnltitle.TabIndex = 19;
            // 
            // pnlMiddletitle
            // 
            this.pnlMiddletitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.pnlMiddletitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddletitle.Location = new System.Drawing.Point(0, 58);
            this.pnlMiddletitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMiddletitle.Name = "pnlMiddletitle";
            this.pnlMiddletitle.Size = new System.Drawing.Size(736, 8);
            this.pnlMiddletitle.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 514);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(736, 8);
            this.panel8.TabIndex = 22;
            // 
            // gbTime
            // 
            this.gbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.gbTime.Controls.Add(this.label8);
            this.gbTime.Controls.Add(this.panel11);
            this.gbTime.Controls.Add(this.panel10);
            this.gbTime.Controls.Add(this.panel5);
            this.gbTime.Controls.Add(this.panel3);
            this.gbTime.Controls.Add(this.panel4);
            this.gbTime.Controls.Add(this.panel9);
            this.gbTime.Controls.Add(this.lblPrice);
            this.gbTime.Controls.Add(this.label4);
            this.gbTime.Controls.Add(this.lblCapacity);
            this.gbTime.Controls.Add(this.label2);
            this.gbTime.Controls.Add(this.lblcountry);
            this.gbTime.Controls.Add(this.lblTime);
            this.gbTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTime.Location = new System.Drawing.Point(0, 66);
            this.gbTime.Margin = new System.Windows.Forms.Padding(2);
            this.gbTime.Name = "gbTime";
            this.gbTime.Padding = new System.Windows.Forms.Padding(2);
            this.gbTime.Size = new System.Drawing.Size(200, 448);
            this.gbTime.TabIndex = 24;
            this.gbTime.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bernard MT Condensed", 16.128F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 26);
            this.label8.TabIndex = 22;
            this.label8.Text = "Passengers >";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel11.Location = new System.Drawing.Point(-1, 68);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(201, 8);
            this.panel11.TabIndex = 21;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.lblDayleft);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.pictureBox1);
            this.panel10.Controls.Add(this.lblMenuteLeft);
            this.panel10.Controls.Add(this.lblHoursLeft);
            this.panel10.Location = new System.Drawing.Point(30, 298);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(139, 115);
            this.panel10.TabIndex = 20;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel14.Location = new System.Drawing.Point(0, 88);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(179, 3);
            this.panel14.TabIndex = 29;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 112);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(139, 3);
            this.panel13.TabIndex = 30;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel12.Location = new System.Drawing.Point(0, 60);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(179, 3);
            this.panel12.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Time Left ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Minutes    : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Days          : ";
            // 
            // lblDayleft
            // 
            this.lblDayleft.AutoSize = true;
            this.lblDayleft.Font = new System.Drawing.Font("Engravers MT", 9.792F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayleft.ForeColor = System.Drawing.Color.White;
            this.lblDayleft.Location = new System.Drawing.Point(100, 42);
            this.lblDayleft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDayleft.Name = "lblDayleft";
            this.lblDayleft.Size = new System.Drawing.Size(27, 16);
            this.lblDayleft.TabIndex = 24;
            this.lblDayleft.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Hours        : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lblMenuteLeft
            // 
            this.lblMenuteLeft.AutoSize = true;
            this.lblMenuteLeft.Font = new System.Drawing.Font("Engravers MT", 9.792F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuteLeft.ForeColor = System.Drawing.Color.White;
            this.lblMenuteLeft.Location = new System.Drawing.Point(100, 70);
            this.lblMenuteLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenuteLeft.Name = "lblMenuteLeft";
            this.lblMenuteLeft.Size = new System.Drawing.Size(27, 16);
            this.lblMenuteLeft.TabIndex = 19;
            this.lblMenuteLeft.Text = "00";
            // 
            // lblHoursLeft
            // 
            this.lblHoursLeft.AutoSize = true;
            this.lblHoursLeft.Font = new System.Drawing.Font("Engravers MT", 9.792F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursLeft.ForeColor = System.Drawing.Color.White;
            this.lblHoursLeft.Location = new System.Drawing.Point(100, 94);
            this.lblHoursLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoursLeft.Name = "lblHoursLeft";
            this.lblHoursLeft.Size = new System.Drawing.Size(27, 16);
            this.lblHoursLeft.TabIndex = 18;
            this.lblHoursLeft.Text = "00";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel5.Location = new System.Drawing.Point(0, 163);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(208, 8);
            this.panel5.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel3.Location = new System.Drawing.Point(0, 214);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 8);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel4.Location = new System.Drawing.Point(0, 109);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 8);
            this.panel4.TabIndex = 18;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel9.Location = new System.Drawing.Point(0, 262);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 8);
            this.panel9.TabIndex = 18;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Bernard MT Condensed", 16.128F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(76, 179);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 26);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "USD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 16.128F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price : ";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Bernard MT Condensed", 16.128F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.ForeColor = System.Drawing.Color.White;
            this.lblCapacity.Location = new System.Drawing.Point(95, 128);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(24, 26);
            this.lblCapacity.TabIndex = 5;
            this.lblCapacity.Text = "0";
            this.lblCapacity.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 16.128F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Capacity : ";
            // 
            // lblcountry
            // 
            this.lblcountry.AutoSize = true;
            this.lblcountry.Font = new System.Drawing.Font("Bernard MT Condensed", 16.128F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcountry.ForeColor = System.Drawing.Color.White;
            this.lblcountry.Location = new System.Drawing.Point(4, 78);
            this.lblcountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcountry.Name = "lblcountry";
            this.lblcountry.Size = new System.Drawing.Size(83, 26);
            this.lblcountry.TabIndex = 3;
            this.lblcountry.Text = "country";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Bernard MT Condensed", 16.128F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(4, 229);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(107, 26);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time here";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(200, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 448);
            this.panel2.TabIndex = 25;
            // 
            // frmjorneyDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(736, 522);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbTime);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pnlMiddletitle);
            this.Controls.Add(this.pnltitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmjorneyDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmjorneyDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnltitle.ResumeLayout(false);
            this.pnltitle.PerformLayout();
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJorneyName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnltitle;
        private System.Windows.Forms.Panel pnlMiddletitle;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcountry;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblMenuteLeft;
        private System.Windows.Forms.Label lblHoursLeft;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDayleft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlbody;
    }
}