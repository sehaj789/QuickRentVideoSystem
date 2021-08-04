namespace QuickRentVideoSystem
{
    partial class RentalForm
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.titleLbl = new System.Windows.Forms.Label();
            this.vidCB = new System.Windows.Forms.ComboBox();
            this.custCB = new System.Windows.Forms.ComboBox();
            this.endDatePK = new System.Windows.Forms.DateTimePicker();
            this.startDatePK = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.vidCB);
            this.panel5.Controls.Add(this.custCB);
            this.panel5.Controls.Add(this.endDatePK);
            this.panel5.Controls.Add(this.startDatePK);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.enterBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.ForeColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(650, 376);
            this.panel5.TabIndex = 20;
            this.panel5.Tag = "603";
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
            this.panel1.TabIndex = 34;
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
            this.titleLbl.Size = new System.Drawing.Size(162, 38);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Issue Video";
            // 
            // vidCB
            // 
            this.vidCB.BackColor = System.Drawing.Color.White;
            this.vidCB.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.vidCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vidCB.FormattingEnabled = true;
            this.vidCB.Location = new System.Drawing.Point(42, 228);
            this.vidCB.Name = "vidCB";
            this.vidCB.Size = new System.Drawing.Size(353, 62);
            this.vidCB.TabIndex = 33;
            this.vidCB.SelectedIndexChanged += new System.EventHandler(this.vidCB_SelectedIndexChanged);
            // 
            // custCB
            // 
            this.custCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.custCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.custCB.BackColor = System.Drawing.Color.White;
            this.custCB.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.custCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.custCB.FormattingEnabled = true;
            this.custCB.Location = new System.Drawing.Point(42, 126);
            this.custCB.Name = "custCB";
            this.custCB.Size = new System.Drawing.Size(353, 62);
            this.custCB.TabIndex = 33;
            this.custCB.SelectedIndexChanged += new System.EventHandler(this.custCB_SelectedIndexChanged);
            // 
            // endDatePK
            // 
            this.endDatePK.CalendarFont = new System.Drawing.Font("Segoe UI", 20F);
            this.endDatePK.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.endDatePK.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.endDatePK.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.endDatePK.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.endDatePK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePK.Location = new System.Drawing.Point(423, 227);
            this.endDatePK.Name = "endDatePK";
            this.endDatePK.Size = new System.Drawing.Size(183, 61);
            this.endDatePK.TabIndex = 31;
            // 
            // startDatePK
            // 
            this.startDatePK.CalendarFont = new System.Drawing.Font("Segoe UI", 20F);
            this.startDatePK.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.startDatePK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePK.Location = new System.Drawing.Point(423, 126);
            this.startDatePK.Name = "startDatePK";
            this.startDatePK.Size = new System.Drawing.Size(184, 61);
            this.startDatePK.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(423, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "Due Date ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(423, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "Booking Date ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(42, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(42, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Video Title";
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.enterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enterBtn.FlatAppearance.BorderSize = 0;
            this.enterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBtn.ForeColor = System.Drawing.Color.White;
            this.enterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enterBtn.Location = new System.Drawing.Point(196, 299);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(259, 51);
            this.enterBtn.TabIndex = 32;
            this.enterBtn.Text = "Save";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 376);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentalForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker endDatePK;
        private System.Windows.Forms.DateTimePicker startDatePK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.ComboBox vidCB;
        private System.Windows.Forms.ComboBox custCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLbl;
        private FontAwesome.Sharp.IconButton closeBtn;
    }
}