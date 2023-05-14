namespace tuningAtelier.Controls
{
    partial class listItem
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxBucket = new System.Windows.Forms.PictureBox();
            this.labelDetailPrice = new System.Windows.Forms.Label();
            this.labelDetailName = new System.Windows.Forms.Label();
            this.pictureBoxDetailPhoto = new System.Windows.Forms.PictureBox();
            this.labelDetailDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBucket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetailPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBucket
            // 
            this.pictureBoxBucket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBucket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBucket.Image = global::tuningAtelier.Properties.Resources.bucket;
            this.pictureBoxBucket.Location = new System.Drawing.Point(196, 15);
            this.pictureBoxBucket.Name = "pictureBoxBucket";
            this.pictureBoxBucket.Size = new System.Drawing.Size(35, 27);
            this.pictureBoxBucket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBucket.TabIndex = 15;
            this.pictureBoxBucket.TabStop = false;
            this.pictureBoxBucket.Click += new System.EventHandler(this.pictureBoxBucket_Click);
            // 
            // labelDetailPrice
            // 
            this.labelDetailPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDetailPrice.AutoSize = true;
            this.labelDetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDetailPrice.Location = new System.Drawing.Point(127, 134);
            this.labelDetailPrice.Name = "labelDetailPrice";
            this.labelDetailPrice.Size = new System.Drawing.Size(47, 18);
            this.labelDetailPrice.TabIndex = 14;
            this.labelDetailPrice.Text = "Цена";
            // 
            // labelDetailName
            // 
            this.labelDetailName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDetailName.AutoSize = true;
            this.labelDetailName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDetailName.Location = new System.Drawing.Point(3, 136);
            this.labelDetailName.Name = "labelDetailName";
            this.labelDetailName.Size = new System.Drawing.Size(118, 16);
            this.labelDetailName.TabIndex = 13;
            this.labelDetailName.Text = "Наименование";
            // 
            // pictureBoxDetailPhoto
            // 
            this.pictureBoxDetailPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDetailPhoto.Image = global::tuningAtelier.Properties.Resources.photo;
            this.pictureBoxDetailPhoto.Location = new System.Drawing.Point(19, 15);
            this.pictureBoxDetailPhoto.Name = "pictureBoxDetailPhoto";
            this.pictureBoxDetailPhoto.Size = new System.Drawing.Size(171, 116);
            this.pictureBoxDetailPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetailPhoto.TabIndex = 12;
            this.pictureBoxDetailPhoto.TabStop = false;
            // 
            // labelDetailDescription
            // 
            this.labelDetailDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDetailDescription.AutoSize = true;
            this.labelDetailDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDetailDescription.Location = new System.Drawing.Point(16, 184);
            this.labelDetailDescription.Name = "labelDetailDescription";
            this.labelDetailDescription.Size = new System.Drawing.Size(80, 16);
            this.labelDetailDescription.TabIndex = 16;
            this.labelDetailDescription.Text = "Описание";
            // 
            // listItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.labelDetailDescription);
            this.Controls.Add(this.pictureBoxBucket);
            this.Controls.Add(this.labelDetailPrice);
            this.Controls.Add(this.labelDetailName);
            this.Controls.Add(this.pictureBoxDetailPhoto);
            this.Name = "listItem";
            this.Size = new System.Drawing.Size(240, 304);
            this.Load += new System.EventHandler(this.listItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBucket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetailPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBucket;
        private System.Windows.Forms.Label labelDetailPrice;
        private System.Windows.Forms.Label labelDetailName;
        private System.Windows.Forms.PictureBox pictureBoxDetailPhoto;
        private System.Windows.Forms.Label labelDetailDescription;
    }
}
