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
    public partial class OrderView : Form
    {
        order Order;
        public OrderView(int idOrder)
        {
            InitializeComponent();
            using (BatteriesEntities db = new BatteriesEntities())
            {
                this.Order = db.order.Single(p => p.idOrder == idOrder);
            }
            fillOrderInfo();
        }

        private void fillOrderInfo()
        {
            using (BatteriesEntities db = new BatteriesEntities())
            {
                idOrderPlace.Text = Order.idOrder.ToString();
                user User = db.user.Single(p => p.idUser == Order.idUser);
                PhonePlace.Text = User.phoneNumber;
                Shop shop = db.Shop.FirstOrDefault(p => p.idShop == Order.idShop);

                addressPlace.Items.AddRange(db.Shop.Select(p => p.addres).ToArray());

                addressPlace.SelectedItem = shop.addres;
                pricePlace.Text = Order.totalPrice.ToString();
                orderDatePlace.Text = Order.orderDate.ToString();

                List<batteriesBucket> buckets = db.batteriesBucket.Where(p => p.idOrder == Order.idOrder).ToList();
                List<menu> menus = new List<menu>();
                foreach (batteriesBucket bucket in buckets)
                {
                    menus.Add(db.menu.Single(p => p.idBatteries == bucket.idBatteries));
                }
                staffsView.DataSource = menus.Select(p => new
                {
                    Photo = p.photoBatteries,
                    Price = p.priceBatteries,
                    StaffName = p.nameBatteries,
                    Count = 1,
                    Sum = 1,
                }).ToList();
            }
        }

        private void orderStatusHandler(object sender, EventArgs e)
        {
            ((managerForm)this.Owner).resetAFK();
            using (BatteriesEntities db = new BatteriesEntities())
            {
                order dbOrder = db.order.Single(p => p.idOrder == Order.idOrder);
                switch (((Button)sender).Text[0])
                {
                    case 'П':
                        {
                            dbOrder.status = "Подтвержден";
                            break;
                        }
                    case 'О':
                        {
                            dbOrder.status = "Отменен";
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Ошибка обработки. Такой кнопки не найдено.");
                            break;
                        }
                }
                db.SaveChanges();
                this.Close();
            }
        }

        private void addressChange(object sender, EventArgs e)
        {
            using (BatteriesEntities db = new BatteriesEntities())
            {
                order DBOrder = db.order.Single(p => p.idOrder == Order.idOrder);
                DBOrder.idShop = db.Shop.Single(p => p.addres == addressPlace.Text).idShop;
                db.SaveChanges();
            }
        }

        private void resetAFK(object sender, EventArgs e)
        {
            ((managerForm)this.Owner).resetAFK();
        }
    }
}
