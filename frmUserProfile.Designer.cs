
namespace DBPROJECT
{
    partial class frmUserProfile
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSMTPHOST = new System.Windows.Forms.TextBox();
            this.txtSMTPport = new System.Windows.Forms.TextBox();
            this.pkrBirthdate = new System.Windows.Forms.DateTimePicker();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoadPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SMTP Host";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "SMTP Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Birthdate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gender";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(189, 332);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.ReadOnly = true;
            this.txtLoginName.Size = new System.Drawing.Size(273, 20);
            this.txtLoginName.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 362);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(273, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtSMTPHOST
            // 
            this.txtSMTPHOST.Location = new System.Drawing.Point(189, 390);
            this.txtSMTPHOST.Name = "txtSMTPHOST";
            this.txtSMTPHOST.Size = new System.Drawing.Size(273, 20);
            this.txtSMTPHOST.TabIndex = 10;
            // 
            // txtSMTPport
            // 
            this.txtSMTPport.Location = new System.Drawing.Point(189, 420);
            this.txtSMTPport.Name = "txtSMTPport";
            this.txtSMTPport.Size = new System.Drawing.Size(273, 20);
            this.txtSMTPport.TabIndex = 11;
            // 
            // pkrBirthdate
            // 
            this.pkrBirthdate.CustomFormat = "MM/dd/yyyy";
            this.pkrBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pkrBirthdate.Location = new System.Drawing.Point(189, 454);
            this.pkrBirthdate.Name = "pkrBirthdate";
            this.pkrBirthdate.Size = new System.Drawing.Size(121, 20);
            this.pkrBirthdate.TabIndex = 12;
            this.pkrBirthdate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "FEMALE",
            "MALE"});
            this.cbxGender.Location = new System.Drawing.Point(189, 485);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(121, 21);
            this.cbxGender.TabIndex = 13;
            this.cbxGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // picBoxUser
            // 
            this.picBoxUser.Image = global::DBPROJECT.Properties.Resources.group_png_3236;
            this.picBoxUser.Location = new System.Drawing.Point(197, 14);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(255, 269);
            this.picBoxUser.TabIndex = 17;
            this.picBoxUser.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::DBPROJECT.Properties.Resources.REFRESH1___Copy__2_;
            this.btnRefresh.Location = new System.Drawing.Point(387, 520);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.Image = global::DBPROJECT.Properties.Resources.forgot_password_icon_18359___5x5___Copy;
            this.btnChangePwd.Location = new System.Drawing.Point(110, 520);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(149, 23);
            this.btnChangePwd.TabIndex = 15;
            this.btnChangePwd.Text = "Change UserPasswrord";
            this.btnChangePwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePwd.UseVisualStyleBackColor = true;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DBPROJECT.Properties.Resources.save_icon_5402___Small;
            this.btnSave.Location = new System.Drawing.Point(306, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Image = global::DBPROJECT.Properties.Resources.close_button_png_30227___5x5;
            this.btnClear.Location = new System.Drawing.Point(359, 287);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 39);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear Photo";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnLoadPhoto
            // 
            this.btnLoadPhoto.Image = global::DBPROJECT.Properties.Resources.ACCOUNT;
            this.btnLoadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadPhoto.Location = new System.Drawing.Point(189, 287);
            this.btnLoadPhoto.Name = "btnLoadPhoto";
            this.btnLoadPhoto.Size = new System.Drawing.Size(121, 39);
            this.btnLoadPhoto.TabIndex = 0;
            this.btnLoadPhoto.Text = "Load New Photo";
            this.btnLoadPhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadPhoto.UseVisualStyleBackColor = true;
            this.btnLoadPhoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 617);
            this.Controls.Add(this.picBoxUser);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnChangePwd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.pkrBirthdate);
            this.Controls.Add(this.txtSMTPport);
            this.Controls.Add(this.txtSMTPHOST);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoadPhoto);
            this.Name = "frmUserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Profile";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPhoto;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSMTPHOST;
        private System.Windows.Forms.TextBox txtSMTPport;
        private System.Windows.Forms.DateTimePicker pkrBirthdate;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChangePwd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox picBoxUser;
    }
}