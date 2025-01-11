namespace SamplePortProject
{
    partial class frmAllClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllClients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btmSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlAllClients = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btmSearch);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 35);
            this.panel1.TabIndex = 0;
            // 
            // btmSearch
            // 
            this.btmSearch.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btmSearch.FlatAppearance.BorderSize = 0;
            this.btmSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSearch.Image = ((System.Drawing.Image)(resources.GetObject("btmSearch.Image")));
            this.btmSearch.Location = new System.Drawing.Point(832, -2);
            this.btmSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(31, 30);
            this.btmSearch.TabIndex = 1;
            this.btmSearch.UseVisualStyleBackColor = true;
            this.btmSearch.Click += new System.EventHandler(this.btmSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.textBox1.Font = new System.Drawing.Font("Wide Latin", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(589, 3);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Passport number";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // pnlAllClients
            // 
            this.pnlAllClients.AutoScroll = true;
            this.pnlAllClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.pnlAllClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAllClients.Location = new System.Drawing.Point(0, 35);
            this.pnlAllClients.Name = "pnlAllClients";
            this.pnlAllClients.Size = new System.Drawing.Size(864, 385);
            this.pnlAllClients.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Available Travel ";
            // 
            // frmAllClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(864, 420);
            this.ControlBox = false;
            this.Controls.Add(this.pnlAllClients);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAllClients";
            this.Load += new System.EventHandler(this.frmAllClients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btmSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlAllClients;
        private System.Windows.Forms.Label label1;
    }
}