
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtNationCode = new System.Windows.Forms.TextBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.rdbMan = new System.Windows.Forms.RadioButton();
            this.rdbWoman = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Vazir", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(169, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "ثبت اطلاعات فرد";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir", 9F);
            this.label2.Location = new System.Drawing.Point(285, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام و نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazir", 9F);
            this.label3.Location = new System.Drawing.Point(285, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "شماره همراه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazir", 9F);
            this.label4.Location = new System.Drawing.Point(285, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "کد ملی";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazir", 9F);
            this.label5.Location = new System.Drawing.Point(285, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "جنسیت";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(12, 100);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(262, 26);
            this.txtFullName.TabIndex = 1;
            // 
            // txtNationCode
            // 
            this.txtNationCode.Location = new System.Drawing.Point(12, 149);
            this.txtNationCode.Name = "txtNationCode";
            this.txtNationCode.Size = new System.Drawing.Size(262, 26);
            this.txtNationCode.TabIndex = 2;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(12, 197);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(262, 26);
            this.txtMobileNumber.TabIndex = 3;
            // 
            // rdbMan
            // 
            this.rdbMan.AutoSize = true;
            this.rdbMan.Checked = true;
            this.rdbMan.Font = new System.Drawing.Font("Vazir", 9F);
            this.rdbMan.Location = new System.Drawing.Point(231, 248);
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
            this.rdbWoman.Location = new System.Drawing.Point(140, 248);
            this.rdbWoman.Name = "rdbWoman";
            this.rdbWoman.Size = new System.Drawing.Size(41, 23);
            this.rdbWoman.TabIndex = 5;
            this.rdbWoman.Text = "زن";
            this.rdbWoman.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Vazir", 14.25F);
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Image = global::Code_First_Practice.Properties.Resources.add35;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.Location = new System.Drawing.Point(12, 291);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(101, 45);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "ثبت";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Code_First_Practice.Properties.Resources.register50;
            this.pictureBox1.Location = new System.Drawing.Point(338, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // lblWarning
            // 
            this.lblWarning.Location = new System.Drawing.Point(119, 291);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(273, 45);
            this.lblWarning.TabIndex = 9;
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.rdbWoman);
            this.Controls.Add(this.rdbMan);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.txtNationCode);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Vazir", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
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