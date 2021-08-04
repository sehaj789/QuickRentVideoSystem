namespace QuickRentVideoSystem
{
    partial class CustomerForm
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.titleLbl = new System.Windows.Forms.Label();
            this.contactTxt = new System.Windows.Forms.TextBox();
            this.addTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.joinPK = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Controls.Add(this.contactTxt);
            this.panel9.Controls.Add(this.addTxt);
            this.panel9.Controls.Add(this.nameTxt);
            this.panel9.Controls.Add(this.joinPK);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.enterBtn);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.ForeColor = System.Drawing.Color.Gray;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(650, 376);
            this.panel9.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 57);
            this.panel1.TabIndex = 35;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 45;
            this.closeBtn.Location = new System.Drawing.Point(598, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(45, 45);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(15, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(200, 38);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Add Customer";
            // 
            // contactTxt
            // 
            this.contactTxt.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.contactTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contactTxt.Location = new System.Drawing.Point(425, 123);
            this.contactTxt.Name = "contactTxt";
            this.contactTxt.Size = new System.Drawing.Size(194, 61);
            this.contactTxt.TabIndex = 11;
            // 
            // addTxt
            // 
            this.addTxt.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.addTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addTxt.Location = new System.Drawing.Point(32, 229);
            this.addTxt.Name = "addTxt";
            this.addTxt.Size = new System.Drawing.Size(364, 61);
            this.addTxt.TabIndex = 12;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.nameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTxt.Location = new System.Drawing.Point(32, 123);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(364, 61);
            this.nameTxt.TabIndex = 10;
            // 
            // joinPK
            // 
            this.joinPK.CalendarFont = new System.Drawing.Font("Segoe UI", 14F);
            this.joinPK.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.joinPK.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.joinPK.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.joinPK.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.joinPK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.joinPK.Location = new System.Drawing.Point(425, 229);
            this.joinPK.Name = "joinPK";
            this.joinPK.Size = new System.Drawing.Size(194, 61);
            this.joinPK.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(425, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Join Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(32, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 36);
            this.label9.TabIndex = 13;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(32, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 36);
            this.label10.TabIndex = 12;
            this.label10.Text = "Customer Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(425, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 36);
            this.label11.TabIndex = 11;
            this.label11.Text = "Contact No.";
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.enterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enterBtn.FlatAppearance.BorderSize = 0;
            this.enterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.enterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enterBtn.Location = new System.Drawing.Point(185, 294);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(280, 51);
            this.enterBtn.TabIndex = 14;
            this.enterBtn.Text = "Add";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 376);
            this.ControlBox = false;
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox contactTxt;
        private System.Windows.Forms.TextBox addTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.DateTimePicker joinPK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton closeBtn;
        private System.Windows.Forms.Label titleLbl;
    }
}