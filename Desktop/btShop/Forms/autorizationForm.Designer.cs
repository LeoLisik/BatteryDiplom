namespace tuningAtelier
{
    partial class autorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.pictureBoxRefreshCaptcha = new System.Windows.Forms.PictureBox();
            this.labelCaptcha = new System.Windows.Forms.Label();
            this.textBoxCaptcha = new System.Windows.Forms.TextBox();
            this.pictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.checkBoxMemorize = new System.Windows.Forms.CheckBox();
            this.pictureBoxEye = new System.Windows.Forms.PictureBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.timerAFK = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefreshCaptcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.Location = new System.Drawing.Point(3, 231);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(156, 25);
            this.buttonExit.TabIndex = 57;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistration.Location = new System.Drawing.Point(77, 204);
            this.buttonRegistration.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(82, 25);
            this.buttonRegistration.TabIndex = 56;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnter.Location = new System.Drawing.Point(3, 205);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(70, 25);
            this.buttonEnter.TabIndex = 55;
            this.buttonEnter.Text = "Вход";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // pictureBoxRefreshCaptcha
            // 
            this.pictureBoxRefreshCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxRefreshCaptcha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRefreshCaptcha.Image = global::tuningAtelier.Properties.Resources.refresh;
            this.pictureBoxRefreshCaptcha.Location = new System.Drawing.Point(138, 136);
            this.pictureBoxRefreshCaptcha.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBoxRefreshCaptcha.Name = "pictureBoxRefreshCaptcha";
            this.pictureBoxRefreshCaptcha.Size = new System.Drawing.Size(20, 18);
            this.pictureBoxRefreshCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefreshCaptcha.TabIndex = 54;
            this.pictureBoxRefreshCaptcha.TabStop = false;
            this.pictureBoxRefreshCaptcha.Visible = false;
            this.pictureBoxRefreshCaptcha.Click += new System.EventHandler(this.pictureBoxRefreshCaptcha_Click);
            // 
            // labelCaptcha
            // 
            this.labelCaptcha.AutoSize = true;
            this.labelCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCaptcha.Location = new System.Drawing.Point(4, 156);
            this.labelCaptcha.Name = "labelCaptcha";
            this.labelCaptcha.Size = new System.Drawing.Size(159, 15);
            this.labelCaptcha.TabIndex = 53;
            this.labelCaptcha.Text = "Введите текст с картинки";
            this.labelCaptcha.Visible = false;
            // 
            // textBoxCaptcha
            // 
            this.textBoxCaptcha.Location = new System.Drawing.Point(6, 175);
            this.textBoxCaptcha.MaxLength = 4;
            this.textBoxCaptcha.Name = "textBoxCaptcha";
            this.textBoxCaptcha.Size = new System.Drawing.Size(152, 20);
            this.textBoxCaptcha.TabIndex = 52;
            this.textBoxCaptcha.Visible = false;
            // 
            // pictureBoxCaptcha
            // 
            this.pictureBoxCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxCaptcha.Location = new System.Drawing.Point(6, 91);
            this.pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            this.pictureBoxCaptcha.Size = new System.Drawing.Size(152, 63);
            this.pictureBoxCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCaptcha.TabIndex = 51;
            this.pictureBoxCaptcha.TabStop = false;
            this.pictureBoxCaptcha.Visible = false;
            // 
            // checkBoxMemorize
            // 
            this.checkBoxMemorize.AutoSize = true;
            this.checkBoxMemorize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMemorize.Location = new System.Drawing.Point(38, 68);
            this.checkBoxMemorize.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkBoxMemorize.Name = "checkBoxMemorize";
            this.checkBoxMemorize.Size = new System.Drawing.Size(125, 19);
            this.checkBoxMemorize.TabIndex = 50;
            this.checkBoxMemorize.Text = "Запомнить меня";
            this.checkBoxMemorize.UseVisualStyleBackColor = true;
            // 
            // pictureBoxEye
            // 
            this.pictureBoxEye.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEye.Image = global::tuningAtelier.Properties.Resources.eyeVisible;
            this.pictureBoxEye.Location = new System.Drawing.Point(138, 46);
            this.pictureBoxEye.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBoxEye.Name = "pictureBoxEye";
            this.pictureBoxEye.Size = new System.Drawing.Size(16, 18);
            this.pictureBoxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEye.TabIndex = 49;
            this.pictureBoxEye.TabStop = false;
            this.pictureBoxEye.Click += new System.EventHandler(this.pictureBoxEye_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(64, 46);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(92, 20);
            this.textBoxPassword.TabIndex = 48;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(4, 46);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 17);
            this.labelPassword.TabIndex = 47;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(64, 13);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxLogin.MaxLength = 50;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(90, 20);
            this.textBoxLogin.TabIndex = 46;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(4, 13);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(47, 17);
            this.labelLogin.TabIndex = 45;
            this.labelLogin.Text = "Логин";
            // 
            // timerAFK
            // 
            this.timerAFK.Interval = 1000;
            this.timerAFK.Tick += new System.EventHandler(this.TimerAFK_Tick);
            // 
            // autorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 266);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.pictureBoxRefreshCaptcha);
            this.Controls.Add(this.labelCaptcha);
            this.Controls.Add(this.textBoxCaptcha);
            this.Controls.Add(this.pictureBoxCaptcha);
            this.Controls.Add(this.checkBoxMemorize);
            this.Controls.Add(this.pictureBoxEye);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "autorizationForm";
            this.Text = "Форма входа";
            this.Load += new System.EventHandler(this.enterRegisterForm_Load);
            this.VisibleChanged += new System.EventHandler(this.enterRegisterForm_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterRegisterForm_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.enterRegisterForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefreshCaptcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.PictureBox pictureBoxRefreshCaptcha;
        private System.Windows.Forms.Label labelCaptcha;
        private System.Windows.Forms.TextBox textBoxCaptcha;
        private System.Windows.Forms.PictureBox pictureBoxCaptcha;
        private System.Windows.Forms.CheckBox checkBoxMemorize;
        private System.Windows.Forms.PictureBox pictureBoxEye;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Timer timerAFK;
    }
}

