namespace tuningAtelier.Controls
{
    partial class bucketListItem
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
            this.labelDetailPrice = new System.Windows.Forms.Label();
            this.labelDetailName = new System.Windows.Forms.Label();
            this.pictureBoxBucketCross = new System.Windows.Forms.PictureBox();
            this.pictureBoxBucketDrtailPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBucketCross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBucketDrtailPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDetailPrice
            // 
            this.labelDetailPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDetailPrice.AutoSize = true;
            this.labelDetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDetailPrice.Location = new System.Drawing.Point(138, 124);
            this.labelDetailPrice.Name = "labelDetailPrice";
            this.labelDetailPrice.Size = new System.Drawing.Size(47, 18);
            this.labelDetailPrice.TabIndex = 10;
            this.labelDetailPrice.Text = "Цена";
            // 
            // labelDetailName
            // 
            this.labelDetailName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDetailName.AutoSize = true;
            this.labelDetailName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDetailName.Location = new System.Drawing.Point(3, 124);
            this.labelDetailName.Name = "labelDetailName";
            this.labelDetailName.Size = new System.Drawing.Size(118, 16);
            this.labelDetailName.TabIndex = 9;
            this.labelDetailName.Text = "Наименование";
            // 
            // pictureBoxBucketCross
            // 
            this.pictureBoxBucketCross.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBucketCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBucketCross.Image = global::tuningAtelier.Properties.Resources.cross;
            this.pictureBoxBucketCross.Location = new System.Drawing.Point(204, 14);
            this.pictureBoxBucketCross.Name = "pictureBoxBucketCross";
            this.pictureBoxBucketCross.Size = new System.Drawing.Size(35, 27);
            this.pictureBoxBucketCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBucketCross.TabIndex = 11;
            this.pictureBoxBucketCross.TabStop = false;
            this.pictureBoxBucketCross.Click += new System.EventHandler(this.pictureBoxCross_Click);
            // 
            // pictureBoxBucketDrtailPhoto
            // 
            this.pictureBoxBucketDrtailPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBucketDrtailPhoto.Image = global::tuningAtelier.Properties.Resources.photo;
            this.pictureBoxBucketDrtailPhoto.Location = new System.Drawing.Point(14, 14);
            this.pictureBoxBucketDrtailPhoto.Name = "pictureBoxBucketDrtailPhoto";
            this.pictureBoxBucketDrtailPhoto.Size = new System.Drawing.Size(183, 107);
            this.pictureBoxBucketDrtailPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBucketDrtailPhoto.TabIndex = 0;
            this.pictureBoxBucketDrtailPhoto.TabStop = false;
            // 
            // bucketListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pictureBoxBucketCross);
            this.Controls.Add(this.labelDetailPrice);
            this.Controls.Add(this.labelDetailName);
            this.Controls.Add(this.pictureBoxBucketDrtailPhoto);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "bucketListItem";
            this.Size = new System.Drawing.Size(250, 172);
            this.Load += new System.EventHandler(this.bucketListItem_Load);
            this.Click += new System.EventHandler(this.bucketListItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBucketCross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBucketDrtailPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBucketDrtailPhoto;
        private System.Windows.Forms.PictureBox pictureBoxBucketCross;
        private System.Windows.Forms.Label labelDetailPrice;
        private System.Windows.Forms.Label labelDetailName;
    }
}
