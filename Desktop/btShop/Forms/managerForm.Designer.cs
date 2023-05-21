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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OrdersView = new System.Windows.Forms.DataGridView();
            this.idOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshButton = new System.Windows.Forms.Button();
            this.timerAFK = new System.Windows.Forms.Timer(this.components);
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
            this.OrdersView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrdersView.Name = "OrdersView";
            this.OrdersView.RowHeadersWidth = 51;
            this.OrdersView.RowTemplate.Height = 100;
            this.OrdersView.Size = new System.Drawing.Size(705, 383);
            this.OrdersView.TabIndex = 1;
            this.OrdersView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OrdersView_MouseDoubleClick);
            // 
            // idOrder
            // 
            this.idOrder.DataPropertyName = "idOrder";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idOrder.DefaultCellStyle = dataGridViewCellStyle4;
            this.idOrder.HeaderText = "№ order";
            this.idOrder.MinimumWidth = 6;
            this.idOrder.Name = "idOrder";
            this.idOrder.Width = 125;
            // 
            // FIO
            // 
            this.FIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FIO.DataPropertyName = "FIO";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FIO.DefaultCellStyle = dataGridViewCellStyle5;
            this.FIO.HeaderText = "FIO";
            this.FIO.MinimumWidth = 6;
            this.FIO.Name = "FIO";
            this.FIO.Width = 59;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Phone.DefaultCellStyle = dataGridViewCellStyle6;
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Date.Width = 125;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(557, 388);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(147, 51);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.loadOrders);
            // 
            // timerAFK
            // 
            this.timerAFK.Enabled = true;
            this.timerAFK.Interval = 1000;
            this.timerAFK.Tick += new System.EventHandler(this.timerAFK_Tick);
            // 
            // managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 443);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.OrdersView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "managerForm";
            this.Text = "managerForm";
            this.Activated += new System.EventHandler(this.loadOrders);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onFormClosing);
            this.Load += new System.EventHandler(this.onFormLoad);
            this.Click += new System.EventHandler(this.managerForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Timer timerAFK;
    }
}