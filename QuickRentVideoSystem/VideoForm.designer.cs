﻿namespace QuickRentVideoSystem
{
    partial class VideoForm
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
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.titleLbl = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.copyTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.langTxt = new System.Windows.Forms.TextBox();
            this.genreTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.yearPK = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.panel1);
            this.panel11.Controls.Add(this.enterBtn);
            this.panel11.Controls.Add(this.copyTxt);
            this.panel11.Controls.Add(this.priceTxt);
            this.panel11.Controls.Add(this.langTxt);
            this.panel11.Controls.Add(this.genreTxt);
            this.panel11.Controls.Add(this.nameTxt);
            this.panel11.Controls.Add(this.yearPK);
            this.panel11.Controls.Add(this.label18);
            this.panel11.Controls.Add(this.label13);
            this.panel11.Controls.Add(this.label17);
            this.panel11.Controls.Add(this.label14);
            this.panel11.Controls.Add(this.label15);
            this.panel11.Controls.Add(this.label16);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.ForeColor = System.Drawing.Color.Gray;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(650, 448);
            this.panel11.TabIndex = 20;
            this.panel11.TabStop = true;
            this.panel11.Tag = "629";
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
            this.panel1.TabIndex = 36;
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
            this.titleLbl.Size = new System.Drawing.Size(152, 38);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Add Video";
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
            this.enterBtn.Location = new System.Drawing.Point(184, 367);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(283, 51);
            this.enterBtn.TabIndex = 26;
            this.enterBtn.Text = "Save";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // copyTxt
            // 
            this.copyTxt.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.copyTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.copyTxt.Location = new System.Drawing.Point(436, 209);
            this.copyTxt.Name = "copyTxt";
            this.copyTxt.Size = new System.Drawing.Size(184, 61);
            this.copyTxt.TabIndex = 23;
            // 
            // priceTxt
            // 
            this.priceTxt.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.priceTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceTxt.Location = new System.Drawing.Point(436, 122);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(184, 61);
            this.priceTxt.TabIndex = 21;
            // 
            // langTxt
            // 
            this.langTxt.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.langTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.langTxt.Location = new System.Drawing.Point(35, 296);
            this.langTxt.Name = "langTxt";
            this.langTxt.Size = new System.Drawing.Size(371, 61);
            this.langTxt.TabIndex = 24;
            // 
            // genreTxt
            // 
            this.genreTxt.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.genreTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genreTxt.Location = new System.Drawing.Point(35, 209);
            this.genreTxt.Name = "genreTxt";
            this.genreTxt.Size = new System.Drawing.Size(371, 61);
            this.genreTxt.TabIndex = 22;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.nameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTxt.Location = new System.Drawing.Point(35, 122);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(371, 61);
            this.nameTxt.TabIndex = 20;
            // 
            // yearPK
            // 
            this.yearPK.CalendarFont = new System.Drawing.Font("Segoe UI", 20F);
            this.yearPK.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yearPK.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yearPK.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yearPK.CustomFormat = "yyyy";
            this.yearPK.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.yearPK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearPK.Location = new System.Drawing.Point(436, 296);
            this.yearPK.Name = "yearPK";
            this.yearPK.ShowUpDown = true;
            this.yearPK.Size = new System.Drawing.Size(184, 61);
            this.yearPK.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(436, 260);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(157, 36);
            this.label18.TabIndex = 14;
            this.label18.Text = "Release Year";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(436, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 36);
            this.label13.TabIndex = 14;
            this.label13.Text = "Copies";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(29, 260);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 36);
            this.label17.TabIndex = 13;
            this.label17.Text = "Language";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(29, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 36);
            this.label14.TabIndex = 13;
            this.label14.Text = "Genre";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(29, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 36);
            this.label15.TabIndex = 12;
            this.label15.Text = "Video Title";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(436, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 36);
            this.label16.TabIndex = 11;
            this.label16.Text = "Cost";
            // 
            // VideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 448);
            this.ControlBox = false;
            this.Controls.Add(this.panel11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.TextBox copyTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox langTxt;
        private System.Windows.Forms.TextBox genreTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.DateTimePicker yearPK;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton closeBtn;
        private System.Windows.Forms.Label titleLbl;
    }
}