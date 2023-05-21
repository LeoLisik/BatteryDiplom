using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tuningAtelier.ENT;

namespace tuningAtelier.Forms
{
    public partial class managerForm : Form
    {
        private int timerCounter = 0;
        private Form enterForm;

        public managerForm()
        {
            InitializeComponent();
        }

        public void resetAFK()
        {
            timerCounter = 0;
        }

        private void onFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            enterForm = this.Owner;
            loadOrders();
        }

        private void loadOrders()
        {
            resetAFK();
            using (BatteriesEntities db = new BatteriesEntities())
            {
                OrdersView.DataSource = db.order.Where(p => p.status == "Активен").Select(p => new
                {
                    idOrder = p.idOrder,
                    FIO = db.user.FirstOrDefault(p1 => p1.idUser == p.idUser).surname + " " + db.user.FirstOrDefault(p1 => p1.idUser == p.idUser).name + " " + db.user.FirstOrDefault(p1 => p1.idUser == p.idUser).patronymic,
                    Phone = db.user.FirstOrDefault(p1 => p1.idUser == p.idUser).phoneNumber,
                    Date = p.orderDate,
                }).ToList();
            }
        }

        private void loadOrders(object sender, EventArgs e)
        {
            loadOrders();
        }

        private void OrdersView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            resetAFK();
            int idOrder = int.Parse(OrdersView.CurrentCell.OwningRow.Cells[0].Value.ToString());
            OrderView form = new OrderView(idOrder);
            form.Owner = this;
            form.ShowDialog();
        }

        private void timerAFK_Tick(object sender, EventArgs e)
        {
            timerCounter++;
            if (timerCounter == 600)
            {
                this.Close();
                enterForm.Show();
            }
        }

        private void managerForm_Click(object sender, EventArgs e)
        {
            resetAFK();
        }
    }
}
