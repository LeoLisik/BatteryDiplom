namespace tuningAtelier.Forms
{
    partial class managerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OrdersView = new System.Windows.Forms.DataGridView();
            this.idOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersView
            // 
            this.OrdersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrder,
            this.FIO,
            this.Phone,
            this.Date});
            this.OrdersView.Location = new System.Drawing.Point(-1, 0);
            this.OrdersView.Margin = new System.Windows.Forms.Padding(2);
            this.OrdersView.Name = "OrdersView";
            this.OrdersView.RowHeadersWidth = 51;
            this.OrdersView.RowTemplate.Height = 100;
            this.OrdersView.Size = new System.Drawing.Size(559, 236);
            this.OrdersView.TabIndex = 1;
            // 
            // idOrder
            // 
            this.idOrder.DataPropertyName = "idUser";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idOrder.DefaultCellStyle = dataGridViewCellStyle1;
            this.idOrder.HeaderText = "№ order";
            this.idOrder.MinimumWidth = 6;
            this.idOrder.Name = "idOrder";
            this.idOrder.Width = 125;
            // 
            // FIO
            // 
            this.FIO.DataPropertyName = "login";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FIO.DefaultCellStyle = dataGridViewCellStyle2;
            this.FIO.HeaderText = "FIO";
            this.FIO.MinimumWidth = 6;
            this.FIO.Name = "FIO";
            this.FIO.Width = 125;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "password";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Phone.DefaultCellStyle = dataGridViewCellStyle3;
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "gender";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Date.DefaultCellStyle = dataGridViewCellStyle4;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 424);
            this.Controls.Add(this.OrdersView);
            this.Name = "managerForm";
            this.Text = "managerForm";
            this.Load += new System.EventHandler(this.onFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}