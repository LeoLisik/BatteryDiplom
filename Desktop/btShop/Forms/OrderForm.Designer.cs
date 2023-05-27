
namespace tuningAtelier.Forms
{
    partial class OrderView
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
            this.idOrderPlace = new System.Windows.Forms.TextBox();
            this.PhonePlace = new System.Windows.Forms.TextBox();
            this.pricePlace = new System.Windows.Forms.TextBox();
            this.orderDatePlace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.staffsView = new System.Windows.Forms.DataGridView();
            this.Photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptButton = new System.Windows.Forms.Button();
            this.declineButton = new System.Windows.Forms.Button();
            this.addressPlace = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.staffsView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказ";
            // 
            // idOrderPlace
            // 
            this.idOrderPlace.Enabled = false;
            this.idOrderPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idOrderPlace.Location = new System.Drawing.Point(99, 2);
            this.idOrderPlace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idOrderPlace.Name = "idOrderPlace";
            this.idOrderPlace.Size = new System.Drawing.Size(107, 26);
            this.idOrderPlace.TabIndex = 1;
            // 
            // PhonePlace
            // 
            this.PhonePlace.Enabled = false;
            this.PhonePlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhonePlace.Location = new System.Drawing.Point(9, 50);
            this.PhonePlace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PhonePlace.Name = "PhonePlace";
            this.PhonePlace.Size = new System.Drawing.Size(151, 26);
            this.PhonePlace.TabIndex = 2;
            // 
            // pricePlace
            // 
            this.pricePlace.Enabled = false;
            this.pricePlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pricePlace.Location = new System.Drawing.Point(164, 51);
            this.pricePlace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pricePlace.Name = "pricePlace";
            this.pricePlace.Size = new System.Drawing.Size(158, 26);
            this.pricePlace.TabIndex = 4;
            // 
            // orderDatePlace
            // 
            this.orderDatePlace.Enabled = false;
            this.orderDatePlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderDatePlace.Location = new System.Drawing.Point(164, 101);
            this.orderDatePlace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderDatePlace.Name = "orderDatePlace";
            this.orderDatePlace.Size = new System.Drawing.Size(158, 26);
            this.orderDatePlace.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Адрес магазина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(209, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Итоговая цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(224, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата заказа";
            // 
            // staffsView
            // 
            this.staffsView.AllowUserToAddRows = false;
            this.staffsView.AllowUserToDeleteRows = false;
            this.staffsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Photo,
            this.StaffName,
            this.Price,
            this.Count,
            this.Sum});
            this.staffsView.Location = new System.Drawing.Point(9, 130);
            this.staffsView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.staffsView.Name = "staffsView";
            this.staffsView.ReadOnly = true;
            this.staffsView.RowHeadersVisible = false;
            this.staffsView.RowHeadersWidth = 51;
            this.staffsView.RowTemplate.Height = 24;
            this.staffsView.Size = new System.Drawing.Size(318, 179);
            this.staffsView.TabIndex = 12;
            // 
            // Photo
            // 
            this.Photo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Photo.DataPropertyName = "Photo";
            this.Photo.HeaderText = "Фото";
            this.Photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Photo.MinimumWidth = 6;
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            this.Photo.Width = 50;
            // 
            // StaffName
            // 
            this.StaffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StaffName.DataPropertyName = "StaffName";
            this.StaffName.HeaderText = "Название";
            this.StaffName.MinimumWidth = 6;
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            this.StaffName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StaffName.Width = 63;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Цена";
            this.Price.MinimumWidth = 50;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 50;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "Количество";
            this.Count.MinimumWidth = 65;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 65;
            // 
            // Sum
            // 
            this.Sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Sum.DataPropertyName = "Sum";
            this.Sum.HeaderText = "Сумма";
            this.Sum.MinimumWidth = 45;
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            this.Sum.Width = 45;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(9, 314);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(122, 41);
            this.acceptButton.TabIndex = 14;
            this.acceptButton.Text = "Подтвердить заказ";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.orderStatusHandler);
            // 
            // declineButton
            // 
            this.declineButton.Location = new System.Drawing.Point(203, 314);
            this.declineButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(124, 41);
            this.declineButton.TabIndex = 15;
            this.declineButton.Text = "Отменить заказ";
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Click += new System.EventHandler(this.orderStatusHandler);
            // 
            // addressPlace
            // 
            this.addressPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressPlace.FormattingEnabled = true;
            this.addressPlace.Location = new System.Drawing.Point(9, 101);
            this.addressPlace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressPlace.Name = "addressPlace";
            this.addressPlace.Size = new System.Drawing.Size(151, 28);
            this.addressPlace.TabIndex = 16;
            this.addressPlace.SelectedIndexChanged += new System.EventHandler(this.addressChange);
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 361);
            this.Controls.Add(this.addressPlace);
            this.Controls.Add(this.declineButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.staffsView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderDatePlace);
            this.Controls.Add(this.pricePlace);
            this.Controls.Add(this.PhonePlace);
            this.Controls.Add(this.idOrderPlace);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrderView";
            this.Text = "OrderForm";
            this.Click += new System.EventHandler(this.resetAFK);
            ((System.ComponentModel.ISupportInitialize)(this.staffsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idOrderPlace;
        private System.Windows.Forms.TextBox PhonePlace;
        private System.Windows.Forms.TextBox pricePlace;
        private System.Windows.Forms.TextBox orderDatePlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView staffsView;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.ComboBox addressPlace;
        private System.Windows.Forms.DataGridViewImageColumn Photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
    }
}