namespace SamplePortProject
{
    partial class FrmAddNewTravel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddNewTravel));
            this.tbTravelName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmCountries = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PlaneCapacity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.btmSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlanes = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneCapacity)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTravelName
            // 
            this.tbTravelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.tbTravelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTravelName.ForeColor = System.Drawing.Color.White;
            this.tbTravelName.Location = new System.Drawing.Point(240, 39);
            this.tbTravelName.Multiline = true;
            this.tbTravelName.Name = "tbTravelName";
            this.tbTravelName.Size = new System.Drawing.Size(344, 47);
            this.tbTravelName.TabIndex = 0;
            this.tbTravelName.Text = "TRAVEL NAME";
            this.tbTravelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTravelName.MouseEnter += new System.EventHandler(this.tbTravelName_MouseEnter);
            this.tbTravelName.MouseLeave += new System.EventHandler(this.tbTravelName_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "PRICE : ";
            // 
            // Price
            // 
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.Price.Location = new System.Drawing.Point(97, 65);
            this.Price.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Price.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(136, 24);
            this.Price.TabIndex = 7;
            this.Price.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(428, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 162);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payement Details";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(389, 127);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 29);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(355, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 25);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(389, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "USD",
            "KSA real ",
            "MAD ",
            "Dt",
            "DA",
            "FRANK",
            "CD ",
            "EURO"});
            this.comboBox1.Location = new System.Drawing.Point(253, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 26);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "USD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmCountries);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PlaneCapacity);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.StartDate);
            this.groupBox2.Location = new System.Drawing.Point(10, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 162);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Derection : ";
            // 
            // cmCountries
            // 
            this.cmCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.cmCountries.FormattingEnabled = true;
            this.cmCountries.Location = new System.Drawing.Point(132, 99);
            this.cmCountries.Name = "cmCountries";
            this.cmCountries.Size = new System.Drawing.Size(229, 21);
            this.cmCountries.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Plane Capacity : ";
            // 
            // PlaneCapacity
            // 
            this.PlaneCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.PlaneCapacity.Location = new System.Drawing.Point(165, 59);
            this.PlaneCapacity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.PlaneCapacity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PlaneCapacity.Name = "PlaneCapacity";
            this.PlaneCapacity.Size = new System.Drawing.Size(196, 20);
            this.PlaneCapacity.TabIndex = 14;
            this.PlaneCapacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Start Date : ";
            // 
            // StartDate
            // 
            this.StartDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.StartDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.StartDate.CalendarTitleForeColor = System.Drawing.Color.White;
            this.StartDate.Location = new System.Drawing.Point(132, 19);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(229, 20);
            this.StartDate.TabIndex = 12;
            // 
            // btmSave
            // 
            this.btmSave.BackColor = System.Drawing.Color.Transparent;
            this.btmSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btmSave.FlatAppearance.BorderSize = 2;
            this.btmSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btmSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btmSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.824F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSave.ForeColor = System.Drawing.Color.White;
            this.btmSave.Image = ((System.Drawing.Image)(resources.GetObject("btmSave.Image")));
            this.btmSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmSave.Location = new System.Drawing.Point(349, 303);
            this.btmSave.Name = "btmSave";
            this.btmSave.Size = new System.Drawing.Size(208, 44);
            this.btmSave.TabIndex = 11;
            this.btmSave.Text = "SAVE";
            this.btmSave.UseVisualStyleBackColor = false;
            this.btmSave.Click += new System.EventHandler(this.btmSave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 412);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 23);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // lblPlanes
            // 
            this.lblPlanes.AutoSize = true;
            this.lblPlanes.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanes.ForeColor = System.Drawing.Color.White;
            this.lblPlanes.Location = new System.Drawing.Point(857, 9);
            this.lblPlanes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlanes.Name = "lblPlanes";
            this.lblPlanes.Size = new System.Drawing.Size(895, 17);
            this.lblPlanes.TabIndex = 1;
            this.lblPlanes.Text = "Hawker Hurricane ||  U-2 spy plane || B-52 Stratofortress  ||  F-16 Fighting Falc" +
    "on|| MiG-21 fighter || Tupolev Tu-95 bomber";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(355, 127);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 29);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // FrmAddNewTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(878, 435);
            this.ControlBox = false;
            this.Controls.Add(this.lblPlanes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btmSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbTravelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddNewTravel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmAddNewTravel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneCapacity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTravelName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmCountries;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PlaneCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Button btmSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlanes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}