using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tuningAtelier.ENT;
using tuningAtelier.Forms;

namespace tuningAtelier.Controls
{
    public partial class listItem : UserControl
    {
        #region DLL
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr Rounded(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthElipse, int nHeightElipse);
        #endregion
        #region Changes
        userForm goodsForm;
        #endregion
        public listItem(userForm main)
        {
            InitializeComponent();
            goodsForm = main;
        }

        #region Properties
        private int idBatteries;
        private string batteriesName;
        private double batteriesPrice;
        private string batteriesDescription;
        private int widthItem;
        private int heightItem;
        private Image batteriesImage;

        [Category("Custom Props")]
        public int IdBatteries
        {
            get { return idBatteries; }
            set { idBatteries = value; }
        }

        [Category("Custom Props")]
        public string DetailName
        {
            get { return batteriesName; }
            set 
            { 
                batteriesName = value; 
                labelDetailName.Text = String.Empty;
                for (int i = 0; i < value.Length; i++)
                {
                    labelDetailName.Text += value[i];
                    if (i == 13)
                    {
                        labelDetailName.Text += "\n";
                    }
                    if (i == 26)
                    {
                        labelDetailName.Text += "\n";
                    }
                    if (i == 39)
                    {
                        labelDetailName.Text += "\n";
                    }
                    if (i == 52)
                    {
                        labelDetailName.Text += "\n";
                    }
                }
            }
        }

        [Category("Custom Props")]
        public double BatteriesPrice
        {
            get { return batteriesPrice; }
            set { batteriesPrice = value; labelDetailPrice.Text = ("Цена: " + value.ToString()); }
        }

        [Category("Custom Props")]
        public string DetailDescription
        {
            get { return batteriesDescription; }
            set 
            { 
                batteriesDescription = value;
                labelDetailDescription.Text = String.Empty;
                for (int i = 0; i < value.Length; i++)
                {
                    labelDetailDescription.Text += value[i];
                    if (i == 15)
                    {
                        labelDetailDescription.Text += "\n";
                    }
                    if (i == 30)
                    {
                        labelDetailDescription.Text += "\n";
                    }
                    if (i == 45)
                    {
                        labelDetailDescription.Text += "\n";
                    }
                    if (i == 60)
                    {
                        labelDetailDescription.Text += "\n";
                    }
                }
            }
        }

        [Category("Custom Props")]
        public int WidthItem
        {
            get { return widthItem; }
            set { widthItem = value; this.Width = value; }
        }

        [Category("Custom Props")]
        public int HeightItem
        {
            get { return heightItem; }
            set { heightItem = value; this.Height = value; }
        }

        [Category("Custom Props")]
        public Image DetailImage
        {
            get { return batteriesImage; }
            set { batteriesImage = value; pictureBoxDetailPhoto.Image = value; }
        }
        #endregion

        #region Func
        private void listItem_Load(object sender, EventArgs e)
        {
            IntPtr ptr = Rounded(0, 0, this.Width, this.Height, 20, 20);
            this.Region = Region.FromHrgn(ptr);
        }

        private void pictureBoxBucket_Click(object sender, EventArgs e)
        {
            using (BatteriesEntities db = new BatteriesEntities())
            {
                var order = db.order.Where(p => p.idUser == goodsForm.userData.idUser && p.status == "Активен").OrderByDescending(p => p.orderDate).ToList()[0];
                db.batteriesBucket.Add(new batteriesBucket
                {
                    idOrder = order.idOrder,
                    idBatteries = IdBatteries
                });
                goodsForm.totalPrice += BatteriesPrice;
                goodsForm.pictureBoxBucket.Visible = true;
                goodsForm.tabPageBucket.Parent = goodsForm.tabPage;
                db.SaveChanges();
            }
        }
        #endregion
    }
}
