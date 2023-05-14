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
        public managerForm()
        {
            InitializeComponent();
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            loadOrders();
        }

        private void loadOrders()
        {
            using (BatteriesEntities db = new BatteriesEntities())
            {
                OrdersView.DataSource = db.order.Select(p => new
                {
                    p.idOrder,
                    FIO = db.user.FirstOrDefault(p1 => p1.idUser == p.idUser).surname + db.user.FirstOrDefault(p1 => p1.idUser == p.idUser).name + db.user.FirstOrDefault(p1 => p1.idUser == p.idUser).patronymic,
                    Phone = db.user.FirstOrDefault(p1 => p1.idUser == p.idUser).phoneNumber,
                    Date = p.orderDate,
                }).ToList();
            }
        }
    }
}
