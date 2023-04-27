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
    public partial class bucketListItem : UserControl
    {
        #region DLL
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr Rounded(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthElipse, int nHeightElipse);
        #endregion

        #region Changes
        userForm goodsForm;
        #endregion
        public bucketListItem(userForm main)
        {
            InitializeComponent();
            goodsForm = main;
        }

        #region Properties
        private int idBucket;
        private int idDetail;
        private string detailName;
        private double detailPrice;
        private string detailDescription;
        private int widthItem;
        private int heightItem;
        private Image detailImage;

        [Category("Custom Props")]
        public int IdBucket
        {
            get { return idBucket; }
            set { idBucket = value; }
        }

        [Category("Custom Props")]
        public int IdDetail
        {
            get { return idDetail; }
            set { idDetail = value; }
        }

        [Category("Custom Props")]
        public string DetailName
        {
            get { return detailName; }
            set { 
                detailName = value; 
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
        public double DetailPrice
        {
            get { return detailPrice; }
            set { detailPrice = value; labelDetailPrice.Text = ("Цена: " + value.ToString()); }
        }

        [Category("Custom Props")]
        public string DetailDescription
        {
            get { return detailDescription; }
            set { detailDescription = value; }
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
            get { return detailImage; }
            set { detailImage = value; pictureBoxBucketDrtailPhoto.Image = value; }
        }
        #endregion

        #region ControlFunc
        private void bucketListItem_Click(object sender, EventArgs e)
        {
            goodsForm.pictureBoxDishBucket.Image = DetailImage;
            goodsForm.pictureBoxDishBucket.Visible = true;
            goodsForm.labelDishNameBucket.Text = DetailName;
            goodsForm.labelDishNameBucket.Visible = true;
            goodsForm.labelDishDescriptionBucket.Text = String.Empty;
            for (int i = 0; i < DetailDescription.Length; i++)
            {
                goodsForm.labelDishDescriptionBucket.Text += DetailDescription[i];
                if (i == 30)
                {
                    goodsForm.labelDishDescriptionBucket.Text += "\n";
                }
                if (i == 60)
                {
                    goodsForm.labelDishDescriptionBucket.Text += "\n";
                }
                if (i == 90)
                {
                    goodsForm.labelDishDescriptionBucket.Text += "\n";
                }
                if (i == 120)
                {
                    goodsForm.labelDishDescriptionBucket.Text += "\n";
                }
            }
            goodsForm.labelDishDescriptionBucket.Visible = true;
            goodsForm.labelDishPriceBucket.Text = ("Цена: " + DetailPrice.ToString());
            goodsForm.labelDishPriceBucket.Visible = true;
        }

        private void bucketListItem_Load(object sender, EventArgs e)
        {
            IntPtr ptr = Rounded(0, 0, this.Width, this.Height, 20, 20);
            this.Region = Region.FromHrgn(ptr);
        }

        private void pictureBoxCross_Click(object sender, EventArgs e)
        {
            using (BatteriesEntities db = new BatteriesEntities())
            {
                var itemBucket = db.batteriesBucket.Find(IdBucket);
                db.batteriesBucket.Remove(itemBucket);
                db.SaveChanges();
                goodsForm.loadGridBucketItems();
                goodsForm.totalPrice -= DetailPrice;
            }
        }
        #endregion
    }
}
