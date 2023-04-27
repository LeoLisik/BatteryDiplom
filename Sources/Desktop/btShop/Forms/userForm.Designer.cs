namespace tuningAtelier.Forms
{
    partial class userForm
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
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelDirthday = new System.Windows.Forms.Label();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxBirthday = new System.Windows.Forms.MaskedTextBox();
            this.buttonChangeImage = new System.Windows.Forms.Button();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.pictureBoxProfileImage = new System.Windows.Forms.PictureBox();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabPageGoods = new System.Windows.Forms.TabPage();
            this.pictureBoxBucket = new System.Windows.Forms.PictureBox();
            this.pictureBoxList = new System.Windows.Forms.PictureBox();
            this.pictureBoxGrid = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelGoods = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageBucket = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAtelier = new System.Windows.Forms.ComboBox();
            this.labelVeryTotalPrice = new System.Windows.Forms.Label();
            this.buttonCanceldetailOrder = new System.Windows.Forms.Button();
            this.buttonAceptdetailOrder = new System.Windows.Forms.Button();
            this.labelDishDescriptionBucket = new System.Windows.Forms.Label();
            this.labelDishPriceBucket = new System.Windows.Forms.Label();
            this.labelDishNameBucket = new System.Windows.Forms.Label();
            this.flowLayoutPanelBucket = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxListBucket = new System.Windows.Forms.PictureBox();
            this.pictureBoxGridBucket = new System.Windows.Forms.PictureBox();
            this.pictureBoxDishBucket = new System.Windows.Forms.PictureBox();
            this.timerAFK = new System.Windows.Forms.Timer(this.components);
            this.tabPageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).BeginInit();
            this.tabPage.SuspendLayout();
            this.tabPageGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBucket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrid)).BeginInit();
            this.tabPageBucket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxListBucket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGridBucket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDishBucket)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(13, 210);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(74, 34);
            this.labelPhoneNumber.TabIndex = 41;
            this.labelPhoneNumber.Text = "Номер \r\nтелефона";
            // 
            // labelDirthday
            // 
            this.labelDirthday.AutoSize = true;
            this.labelDirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDirthday.Location = new System.Drawing.Point(13, 164);
            this.labelDirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDirthday.Name = "labelDirthday";
            this.labelDirthday.Size = new System.Drawing.Size(73, 34);
            this.labelDirthday.TabIndex = 40;
            this.labelDirthday.Text = "Дата\r\nрождения";
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Enabled = false;
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(97, 224);
            this.maskedTextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maskedTextBoxPhoneNumber.Mask = "8(999)000-0000";
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPhoneNumber.TabIndex = 39;
            // 
            // maskedTextBoxBirthday
            // 
            this.maskedTextBoxBirthday.Enabled = false;
            this.maskedTextBoxBirthday.Location = new System.Drawing.Point(97, 178);
            this.maskedTextBoxBirthday.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maskedTextBoxBirthday.Mask = "00/00/0000";
            this.maskedTextBoxBirthday.Name = "maskedTextBoxBirthday";
            this.maskedTextBoxBirthday.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxBirthday.TabIndex = 38;
            this.maskedTextBoxBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // buttonChangeImage
            // 
            this.buttonChangeImage.BackColor = System.Drawing.Color.Transparent;
            this.buttonChangeImage.Enabled = false;
            this.buttonChangeImage.Location = new System.Drawing.Point(10, 337);
            this.buttonChangeImage.Name = "buttonChangeImage";
            this.buttonChangeImage.Size = new System.Drawing.Size(213, 27);
            this.buttonChangeImage.TabIndex = 37;
            this.buttonChangeImage.Text = "Поменять фото";
            this.buttonChangeImage.UseVisualStyleBackColor = false;
            this.buttonChangeImage.Click += new System.EventHandler(this.buttonChangeImage_Click);
            // 
            // textBoxRole
            // 
            this.textBoxRole.Enabled = false;
            this.textBoxRole.Location = new System.Drawing.Point(97, 138);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(100, 20);
            this.textBoxRole.TabIndex = 36;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Enabled = false;
            this.textBoxLogin.Location = new System.Drawing.Point(97, 11);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 31;
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(97, 63);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 30;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Enabled = false;
            this.textBoxSurname.Location = new System.Drawing.Point(97, 89);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 29;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Enabled = false;
            this.textBoxPatronymic.Location = new System.Drawing.Point(97, 112);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(100, 20);
            this.textBoxPatronymic.TabIndex = 28;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Location = new System.Drawing.Point(97, 37);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 21;
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.Transparent;
            this.buttonAccept.Enabled = false;
            this.buttonAccept.Location = new System.Drawing.Point(117, 289);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(106, 42);
            this.buttonAccept.TabIndex = 35;
            this.buttonAccept.Text = "Подтвердить";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Enabled = false;
            this.radioButtonFemale.Location = new System.Drawing.Point(125, 266);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(72, 17);
            this.radioButtonFemale.TabIndex = 34;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Женский";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Enabled = false;
            this.radioButtonMale.Location = new System.Drawing.Point(53, 266);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(71, 17);
            this.radioButtonMale.TabIndex = 33;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Мужской";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(13, 139);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(81, 17);
            this.labelRole.TabIndex = 27;
            this.labelRole.Text = "Должность";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(13, 266);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(34, 17);
            this.labelGender.TabIndex = 26;
            this.labelGender.Text = "Пол";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.Location = new System.Drawing.Point(20, 115);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(71, 17);
            this.labelPatronymic.TabIndex = 25;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(21, 89);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(70, 17);
            this.labelSurname.TabIndex = 24;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(37, 63);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 17);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Имя";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(37, 37);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 17);
            this.labelPassword.TabIndex = 22;
            this.labelPassword.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(37, 11);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(47, 17);
            this.labelLogin.TabIndex = 19;
            this.labelLogin.Text = "Логин";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit.Location = new System.Drawing.Point(10, 289);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(101, 42);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.BackColor = System.Drawing.Color.Transparent;
            this.tabPageProfile.Controls.Add(this.labelPhoneNumber);
            this.tabPageProfile.Controls.Add(this.labelDirthday);
            this.tabPageProfile.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.tabPageProfile.Controls.Add(this.maskedTextBoxBirthday);
            this.tabPageProfile.Controls.Add(this.buttonChangeImage);
            this.tabPageProfile.Controls.Add(this.textBoxRole);
            this.tabPageProfile.Controls.Add(this.textBoxLogin);
            this.tabPageProfile.Controls.Add(this.textBoxName);
            this.tabPageProfile.Controls.Add(this.textBoxSurname);
            this.tabPageProfile.Controls.Add(this.textBoxPatronymic);
            this.tabPageProfile.Controls.Add(this.textBoxPassword);
            this.tabPageProfile.Controls.Add(this.buttonAccept);
            this.tabPageProfile.Controls.Add(this.radioButtonFemale);
            this.tabPageProfile.Controls.Add(this.radioButtonMale);
            this.tabPageProfile.Controls.Add(this.labelRole);
            this.tabPageProfile.Controls.Add(this.labelGender);
            this.tabPageProfile.Controls.Add(this.labelPatronymic);
            this.tabPageProfile.Controls.Add(this.labelSurname);
            this.tabPageProfile.Controls.Add(this.labelName);
            this.tabPageProfile.Controls.Add(this.labelPassword);
            this.tabPageProfile.Controls.Add(this.pictureBoxProfileImage);
            this.tabPageProfile.Controls.Add(this.labelLogin);
            this.tabPageProfile.Controls.Add(this.buttonEdit);
            this.tabPageProfile.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfile.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageProfile.Size = new System.Drawing.Size(817, 560);
            this.tabPageProfile.TabIndex = 1;
            this.tabPageProfile.Text = "Профиль";
            this.tabPageProfile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabPage_MouseMove);
            // 
            // pictureBoxProfileImage
            // 
            this.pictureBoxProfileImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfileImage.Location = new System.Drawing.Point(229, 11);
            this.pictureBoxProfileImage.Name = "pictureBoxProfileImage";
            this.pictureBoxProfileImage.Size = new System.Drawing.Size(354, 353);
            this.pictureBoxProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfileImage.TabIndex = 20;
            this.pictureBoxProfileImage.TabStop = false;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabPageProfile);
            this.tabPage.Controls.Add(this.tabPageGoods);
            this.tabPage.Controls.Add(this.tabPageBucket);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.Location = new System.Drawing.Point(0, 0);
            this.tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(825, 586);
            this.tabPage.TabIndex = 3;
            this.tabPage.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabPage_Selected);
            this.tabPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabPage_KeyDown);
            // 
            // tabPageGoods
            // 
            this.tabPageGoods.BackColor = System.Drawing.Color.Transparent;
            this.tabPageGoods.Controls.Add(this.pictureBoxBucket);
            this.tabPageGoods.Controls.Add(this.pictureBoxList);
            this.tabPageGoods.Controls.Add(this.pictureBoxGrid);
            this.tabPageGoods.Controls.Add(this.flowLayoutPanelGoods);
            this.tabPageGoods.Location = new System.Drawing.Point(4, 22);
            this.tabPageGoods.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageGoods.Name = "tabPageGoods";
            this.tabPageGoods.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageGoods.Size = new System.Drawing.Size(817, 560);
            this.tabPageGoods.TabIndex = 2;
            this.tabPageGoods.Text = "Меню";
            this.tabPageGoods.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabPage_MouseMove);
            // 
            // pictureBoxBucket
            // 
            this.pictureBoxBucket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBucket.Image = global::tuningAtelier.Properties.Resources.bucket;
            this.pictureBoxBucket.Location = new System.Drawing.Point(769, 94);
            this.pictureBoxBucket.Name = "pictureBoxBucket";
            this.pictureBoxBucket.Size = new System.Drawing.Size(42, 38);
            this.pictureBoxBucket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBucket.TabIndex = 9;
            this.pictureBoxBucket.TabStop = false;
            this.pictureBoxBucket.Visible = false;
            this.pictureBoxBucket.Click += new System.EventHandler(this.pictureBoxBucket_Click);
            // 
            // pictureBoxList
            // 
            this.pictureBoxList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxList.Image = global::tuningAtelier.Properties.Resources.list;
            this.pictureBoxList.Location = new System.Drawing.Point(769, 6);
            this.pictureBoxList.Name = "pictureBoxList";
            this.pictureBoxList.Size = new System.Drawing.Size(42, 38);
            this.pictureBoxList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxList.TabIndex = 8;
            this.pictureBoxList.TabStop = false;
            this.pictureBoxList.Click += new System.EventHandler(this.pictureBoxList_Click);
            // 
            // pictureBoxGrid
            // 
            this.pictureBoxGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGrid.Image = global::tuningAtelier.Properties.Resources.grid;
            this.pictureBoxGrid.Location = new System.Drawing.Point(769, 50);
            this.pictureBoxGrid.Name = "pictureBoxGrid";
            this.pictureBoxGrid.Size = new System.Drawing.Size(42, 38);
            this.pictureBoxGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGrid.TabIndex = 7;
            this.pictureBoxGrid.TabStop = false;
            this.pictureBoxGrid.Click += new System.EventHandler(this.pictureBoxGrid_Click);
            // 
            // flowLayoutPanelGoods
            // 
            this.flowLayoutPanelGoods.AutoScroll = true;
            this.flowLayoutPanelGoods.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelGoods.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelGoods.Name = "flowLayoutPanelGoods";
            this.flowLayoutPanelGoods.Size = new System.Drawing.Size(763, 559);
            this.flowLayoutPanelGoods.TabIndex = 0;
            // 
            // tabPageBucket
            // 
            this.tabPageBucket.BackColor = System.Drawing.Color.Transparent;
            this.tabPageBucket.Controls.Add(this.label1);
            this.tabPageBucket.Controls.Add(this.comboBoxAtelier);
            this.tabPageBucket.Controls.Add(this.labelVeryTotalPrice);
            this.tabPageBucket.Controls.Add(this.buttonCanceldetailOrder);
            this.tabPageBucket.Controls.Add(this.buttonAceptdetailOrder);
            this.tabPageBucket.Controls.Add(this.labelDishDescriptionBucket);
            this.tabPageBucket.Controls.Add(this.labelDishPriceBucket);
            this.tabPageBucket.Controls.Add(this.labelDishNameBucket);
            this.tabPageBucket.Controls.Add(this.flowLayoutPanelBucket);
            this.tabPageBucket.Controls.Add(this.pictureBoxListBucket);
            this.tabPageBucket.Controls.Add(this.pictureBoxGridBucket);
            this.tabPageBucket.Controls.Add(this.pictureBoxDishBucket);
            this.tabPageBucket.Location = new System.Drawing.Point(4, 22);
            this.tabPageBucket.Name = "tabPageBucket";
            this.tabPageBucket.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBucket.Size = new System.Drawing.Size(817, 560);
            this.tabPageBucket.TabIndex = 5;
            this.tabPageBucket.Text = "Корзина";
            this.tabPageBucket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabPage_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(617, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Выберите магазин";
            // 
            // comboBoxAtelier
            // 
            this.comboBoxAtelier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAtelier.FormattingEnabled = true;
            this.comboBoxAtelier.Location = new System.Drawing.Point(621, 29);
            this.comboBoxAtelier.Name = "comboBoxAtelier";
            this.comboBoxAtelier.Size = new System.Drawing.Size(188, 28);
            this.comboBoxAtelier.TabIndex = 19;
            this.comboBoxAtelier.SelectedIndexChanged += new System.EventHandler(this.comboBoxAtelier_SelectedIndexChanged);
            // 
            // labelVeryTotalPrice
            // 
            this.labelVeryTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVeryTotalPrice.AutoSize = true;
            this.labelVeryTotalPrice.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVeryTotalPrice.Location = new System.Drawing.Point(406, 332);
            this.labelVeryTotalPrice.Name = "labelVeryTotalPrice";
            this.labelVeryTotalPrice.Size = new System.Drawing.Size(0, 26);
            this.labelVeryTotalPrice.TabIndex = 18;
            // 
            // buttonCanceldetailOrder
            // 
            this.buttonCanceldetailOrder.BackColor = System.Drawing.Color.Transparent;
            this.buttonCanceldetailOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCanceldetailOrder.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCanceldetailOrder.Location = new System.Drawing.Point(531, 517);
            this.buttonCanceldetailOrder.Name = "buttonCanceldetailOrder";
            this.buttonCanceldetailOrder.Size = new System.Drawing.Size(248, 35);
            this.buttonCanceldetailOrder.TabIndex = 17;
            this.buttonCanceldetailOrder.Text = "Отменить заказ";
            this.buttonCanceldetailOrder.UseVisualStyleBackColor = false;
            this.buttonCanceldetailOrder.Click += new System.EventHandler(this.buttonCanceldetailOrder_Click);
            // 
            // buttonAceptdetailOrder
            // 
            this.buttonAceptdetailOrder.BackColor = System.Drawing.Color.Transparent;
            this.buttonAceptdetailOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAceptdetailOrder.Enabled = false;
            this.buttonAceptdetailOrder.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptdetailOrder.Location = new System.Drawing.Point(531, 470);
            this.buttonAceptdetailOrder.Name = "buttonAceptdetailOrder";
            this.buttonAceptdetailOrder.Size = new System.Drawing.Size(248, 41);
            this.buttonAceptdetailOrder.TabIndex = 16;
            this.buttonAceptdetailOrder.Text = "Подтвердить заказ";
            this.buttonAceptdetailOrder.UseVisualStyleBackColor = false;
            this.buttonAceptdetailOrder.Click += new System.EventHandler(this.buttonAceptdetailOrder_Click);
            // 
            // labelDishDescriptionBucket
            // 
            this.labelDishDescriptionBucket.AutoSize = true;
            this.labelDishDescriptionBucket.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelDishDescriptionBucket.Location = new System.Drawing.Point(537, 330);
            this.labelDishDescriptionBucket.Name = "labelDishDescriptionBucket";
            this.labelDishDescriptionBucket.Size = new System.Drawing.Size(71, 18);
            this.labelDishDescriptionBucket.TabIndex = 12;
            this.labelDishDescriptionBucket.Text = "Описание";
            this.labelDishDescriptionBucket.Visible = false;
            // 
            // labelDishPriceBucket
            // 
            this.labelDishPriceBucket.AutoSize = true;
            this.labelDishPriceBucket.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelDishPriceBucket.Location = new System.Drawing.Point(689, 304);
            this.labelDishPriceBucket.Name = "labelDishPriceBucket";
            this.labelDishPriceBucket.Size = new System.Drawing.Size(49, 21);
            this.labelDishPriceBucket.TabIndex = 11;
            this.labelDishPriceBucket.Text = "Цена";
            this.labelDishPriceBucket.Visible = false;
            // 
            // labelDishNameBucket
            // 
            this.labelDishNameBucket.AutoSize = true;
            this.labelDishNameBucket.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelDishNameBucket.Location = new System.Drawing.Point(537, 304);
            this.labelDishNameBucket.Name = "labelDishNameBucket";
            this.labelDishNameBucket.Size = new System.Drawing.Size(103, 18);
            this.labelDishNameBucket.TabIndex = 10;
            this.labelDishNameBucket.Text = "Наименование";
            this.labelDishNameBucket.Visible = false;
            // 
            // flowLayoutPanelBucket
            // 
            this.flowLayoutPanelBucket.AutoScroll = true;
            this.flowLayoutPanelBucket.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelBucket.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelBucket.Name = "flowLayoutPanelBucket";
            this.flowLayoutPanelBucket.Size = new System.Drawing.Size(515, 559);
            this.flowLayoutPanelBucket.TabIndex = 1;
            // 
            // pictureBoxListBucket
            // 
            this.pictureBoxListBucket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxListBucket.Image = global::tuningAtelier.Properties.Resources.list;
            this.pictureBoxListBucket.Location = new System.Drawing.Point(569, 5);
            this.pictureBoxListBucket.Name = "pictureBoxListBucket";
            this.pictureBoxListBucket.Size = new System.Drawing.Size(42, 38);
            this.pictureBoxListBucket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxListBucket.TabIndex = 15;
            this.pictureBoxListBucket.TabStop = false;
            this.pictureBoxListBucket.Click += new System.EventHandler(this.pictureBoxListBucket_Click);
            // 
            // pictureBoxGridBucket
            // 
            this.pictureBoxGridBucket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGridBucket.Image = global::tuningAtelier.Properties.Resources.grid;
            this.pictureBoxGridBucket.Location = new System.Drawing.Point(521, 5);
            this.pictureBoxGridBucket.Name = "pictureBoxGridBucket";
            this.pictureBoxGridBucket.Size = new System.Drawing.Size(42, 38);
            this.pictureBoxGridBucket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGridBucket.TabIndex = 14;
            this.pictureBoxGridBucket.TabStop = false;
            this.pictureBoxGridBucket.Click += new System.EventHandler(this.pictureBoxGridBucket_Click);
            // 
            // pictureBoxDishBucket
            // 
            this.pictureBoxDishBucket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDishBucket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxDishBucket.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxDishBucket.Location = new System.Drawing.Point(531, 77);
            this.pictureBoxDishBucket.Name = "pictureBoxDishBucket";
            this.pictureBoxDishBucket.Size = new System.Drawing.Size(248, 205);
            this.pictureBoxDishBucket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDishBucket.TabIndex = 9;
            this.pictureBoxDishBucket.TabStop = false;
            this.pictureBoxDishBucket.Visible = false;
            // 
            // timerAFK
            // 
            this.timerAFK.Interval = 1000;
            this.timerAFK.Tick += new System.EventHandler(this.timerAFK_Tick);
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 586);
            this.Controls.Add(this.tabPage);
            this.Name = "userForm";
            this.Text = "userFrom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.VisibleChanged += new System.EventHandler(this.UserForm_VisibleChanged);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).EndInit();
            this.tabPage.ResumeLayout(false);
            this.tabPageGoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBucket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrid)).EndInit();
            this.tabPageBucket.ResumeLayout(false);
            this.tabPageBucket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxListBucket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGridBucket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDishBucket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelDirthday;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBirthday;
        private System.Windows.Forms.Button buttonChangeImage;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.PictureBox pictureBoxProfileImage;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TabPage tabPageProfile;
        internal System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabPageGoods;
        private System.Windows.Forms.PictureBox pictureBoxList;
        private System.Windows.Forms.PictureBox pictureBoxGrid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGoods;
        internal System.Windows.Forms.TabPage tabPageBucket;
        internal System.Windows.Forms.Label labelVeryTotalPrice;
        internal System.Windows.Forms.Button buttonCanceldetailOrder;
        internal System.Windows.Forms.Button buttonAceptdetailOrder;
        internal System.Windows.Forms.Label labelDishDescriptionBucket;
        internal System.Windows.Forms.Label labelDishPriceBucket;
        internal System.Windows.Forms.Label labelDishNameBucket;
        private System.Windows.Forms.PictureBox pictureBoxListBucket;
        private System.Windows.Forms.PictureBox pictureBoxGridBucket;
        internal System.Windows.Forms.PictureBox pictureBoxDishBucket;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBucket;
        private System.Windows.Forms.Timer timerAFK;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAtelier;
        internal System.Windows.Forms.PictureBox pictureBoxBucket;
    }
}