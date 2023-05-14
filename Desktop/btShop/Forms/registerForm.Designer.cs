namespace tuningAtelier.Forms
{
    partial class registerForm
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
            this.timerAFK = new System.Windows.Forms.Timer(this.components);
            this.maskedTextBoxBirthday = new System.Windows.Forms.MaskedTextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelDirthday = new System.Windows.Forms.Label();
            this.labelSelectGender = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAcceptPassword = new System.Windows.Forms.Label();
            this.textBoxAcceptPassword = new System.Windows.Forms.TextBox();
            this.buttonLoadPhoto = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAFK
            // 
            this.timerAFK.Interval = 1000;
            this.timerAFK.Tick += new System.EventHandler(this.timerAFK_Tick);
            // 
            // maskedTextBoxBirthday
            // 
            this.maskedTextBoxBirthday.Location = new System.Drawing.Point(85, 178);
            this.maskedTextBoxBirthday.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maskedTextBoxBirthday.Mask = "00/00/0000";
            this.maskedTextBoxBirthday.Name = "maskedTextBoxBirthday";
            this.maskedTextBoxBirthday.Size = new System.Drawing.Size(87, 20);
            this.maskedTextBoxBirthday.TabIndex = 78;
            this.maskedTextBoxBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(8, 220);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(74, 34);
            this.labelPhoneNumber.TabIndex = 77;
            this.labelPhoneNumber.Text = "Номер \r\nтелефона";
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(85, 225);
            this.maskedTextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maskedTextBoxPhoneNumber.Mask = "8(999)000-0000";
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(87, 20);
            this.maskedTextBoxPhoneNumber.TabIndex = 76;
            // 
            // labelDirthday
            // 
            this.labelDirthday.AutoSize = true;
            this.labelDirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDirthday.Location = new System.Drawing.Point(8, 173);
            this.labelDirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDirthday.Name = "labelDirthday";
            this.labelDirthday.Size = new System.Drawing.Size(73, 34);
            this.labelDirthday.TabIndex = 75;
            this.labelDirthday.Text = "Дата\r\nрождения";
            // 
            // labelSelectGender
            // 
            this.labelSelectGender.AutoSize = true;
            this.labelSelectGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectGender.Location = new System.Drawing.Point(12, 274);
            this.labelSelectGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSelectGender.Name = "labelSelectGender";
            this.labelSelectGender.Size = new System.Drawing.Size(102, 17);
            this.labelSelectGender.TabIndex = 74;
            this.labelSelectGender.Text = "Выберите пол";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(16, 296);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(71, 17);
            this.radioButtonMale.TabIndex = 73;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Мужской";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(98, 296);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(72, 17);
            this.radioButtonFemale.TabIndex = 72;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Женский";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(9, 97);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 17);
            this.labelName.TabIndex = 71;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(8, 119);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(70, 17);
            this.labelSurname.TabIndex = 70;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.Location = new System.Drawing.Point(9, 142);
            this.labelPatronymic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(71, 17);
            this.labelPatronymic.TabIndex = 69;
            this.labelPatronymic.Text = "Отчество";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(85, 118);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxSurname.MaxLength = 50;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(87, 20);
            this.textBoxSurname.TabIndex = 68;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(85, 142);
            this.textBoxPatronymic.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxPatronymic.MaxLength = 50;
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(87, 20);
            this.textBoxPatronymic.TabIndex = 67;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(85, 97);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(87, 20);
            this.textBoxName.TabIndex = 66;
            // 
            // labelAcceptPassword
            // 
            this.labelAcceptPassword.AutoSize = true;
            this.labelAcceptPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAcceptPassword.Location = new System.Drawing.Point(7, 54);
            this.labelAcceptPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAcceptPassword.Name = "labelAcceptPassword";
            this.labelAcceptPassword.Size = new System.Drawing.Size(146, 17);
            this.labelAcceptPassword.TabIndex = 64;
            this.labelAcceptPassword.Text = "Подтвердите пароль";
            // 
            // textBoxAcceptPassword
            // 
            this.textBoxAcceptPassword.Location = new System.Drawing.Point(10, 72);
            this.textBoxAcceptPassword.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxAcceptPassword.MaxLength = 50;
            this.textBoxAcceptPassword.Name = "textBoxAcceptPassword";
            this.textBoxAcceptPassword.Size = new System.Drawing.Size(141, 20);
            this.textBoxAcceptPassword.TabIndex = 63;
            this.textBoxAcceptPassword.UseSystemPasswordChar = true;
            // 
            // buttonLoadPhoto
            // 
            this.buttonLoadPhoto.Location = new System.Drawing.Point(14, 355);
            this.buttonLoadPhoto.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonLoadPhoto.Name = "buttonLoadPhoto";
            this.buttonLoadPhoto.Size = new System.Drawing.Size(157, 26);
            this.buttonLoadPhoto.TabIndex = 61;
            this.buttonLoadPhoto.Text = "Загрузить фото";
            this.buttonLoadPhoto.UseVisualStyleBackColor = true;
            this.buttonLoadPhoto.Click += new System.EventHandler(this.buttonLoadPhoto_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(7, 33);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 17);
            this.labelPassword.TabIndex = 59;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(64, 32);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(87, 20);
            this.textBoxPassword.TabIndex = 58;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(98, 328);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(72, 25);
            this.buttonCancel.TabIndex = 57;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(7, 9);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(47, 17);
            this.labelLogin.TabIndex = 56;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(64, 7);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxLogin.MaxLength = 50;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(87, 20);
            this.textBoxLogin.TabIndex = 55;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(14, 328);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(81, 25);
            this.buttonRegister.TabIndex = 54;
            this.buttonRegister.Text = "Регистрация";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(176, 4);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(311, 376);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 62;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 385);
            this.Controls.Add(this.maskedTextBoxBirthday);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.Controls.Add(this.labelDirthday);
            this.Controls.Add(this.labelSelectGender);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAcceptPassword);
            this.Controls.Add(this.textBoxAcceptPassword);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.buttonLoadPhoto);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonRegister);
            this.Name = "registerForm";
            this.Text = "registerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.VisibleChanged += new System.EventHandler(this.RegisterForm_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterForm_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerAFK;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBirthday;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.Label labelDirthday;
        private System.Windows.Forms.Label labelSelectGender;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAcceptPassword;
        private System.Windows.Forms.TextBox textBoxAcceptPassword;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonLoadPhoto;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonRegister;
    }
}