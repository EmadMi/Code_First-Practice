
namespace Code_First_Practice
{
    partial class Register
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtNationCode = new System.Windows.Forms.TextBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.rdbMan = new System.Windows.Forms.RadioButton();
            this.rdbWoman = new System.Windows.Forms.RadioButton();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.imgTitle = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Vazir", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(118, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(163, 50);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ثبت اطلاعات فرد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazir", 9F);
            this.label5.Location = new System.Drawing.Point(285, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "جنسیت";
            // 
            // txtFullName
            // 
            this.txtFullName.AccessibleName = "نام و نام خانوادگی";
            this.txtFullName.Location = new System.Drawing.Point(13, 103);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(325, 26);
            this.txtFullName.TabIndex = 1;
            // 
            // txtNationCode
            // 
            this.txtNationCode.AccessibleName = "کد ملی";
            this.txtNationCode.Location = new System.Drawing.Point(13, 163);
            this.txtNationCode.Name = "txtNationCode";
            this.txtNationCode.Size = new System.Drawing.Size(325, 26);
            this.txtNationCode.TabIndex = 2;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.AccessibleName = "شماره همراه";
            this.txtMobileNumber.Location = new System.Drawing.Point(13, 223);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(325, 26);
            this.txtMobileNumber.TabIndex = 3;
            // 
            // rdbMan
            // 
            this.rdbMan.AutoSize = true;
            this.rdbMan.Checked = true;
            this.rdbMan.Font = new System.Drawing.Font("Vazir", 9F);
            this.rdbMan.Location = new System.Drawing.Point(285, 312);
            this.rdbMan.Name = "rdbMan";
            this.rdbMan.Size = new System.Drawing.Size(43, 23);
            this.rdbMan.TabIndex = 4;
            this.rdbMan.TabStop = true;
            this.rdbMan.Text = "مرد";
            this.rdbMan.UseVisualStyleBackColor = true;
            // 
            // rdbWoman
            // 
            this.rdbWoman.AutoSize = true;
            this.rdbWoman.Font = new System.Drawing.Font("Vazir", 9F);
            this.rdbWoman.Location = new System.Drawing.Point(194, 312);
            this.rdbWoman.Name = "rdbWoman";
            this.rdbWoman.Size = new System.Drawing.Size(41, 23);
            this.rdbWoman.TabIndex = 5;
            this.rdbWoman.Text = "زن";
            this.rdbWoman.UseVisualStyleBackColor = true;
            // 
            // lblWarning
            // 
            this.lblWarning.Location = new System.Drawing.Point(132, 343);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(205, 45);
            this.lblWarning.TabIndex = 9;
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Vazir", 14.25F);
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Image = global::Code_First_Practice.Properties.Resources.add35;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.Location = new System.Drawing.Point(12, 343);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(114, 45);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "ثبت";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // imgTitle
            // 
            this.imgTitle.Image = global::Code_First_Practice.Properties.Resources.register50;
            this.imgTitle.Location = new System.Drawing.Point(287, 12);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(50, 50);
            this.imgTitle.TabIndex = 1;
            this.imgTitle.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Code_First_Practice.Properties.Resources.close35;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.rdbWoman);
            this.Controls.Add(this.rdbMan);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.imgTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.txtNationCode);
            this.Font = new System.Drawing.Font("Vazir", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox imgTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtNationCode;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.RadioButton rdbMan;
        private System.Windows.Forms.RadioButton rdbWoman;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblWarning;
    }
}