using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tuningAtelier.Controls;
using tuningAtelier.ENT;

namespace tuningAtelier.Forms
{
    public partial class userForm : Form
    {
        #region DLL
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr Rounded(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthElipse, int nHeightElipse);
        #endregion

        #region Properties
        private Form enterForm;
        private int timerCounter = 0;
        internal user userData = null;
        private string userLogin = "";
        internal double totalPrice;
        #endregion

        public userForm(Form main, string login)
        {
            InitializeComponent();
            enterForm = main;
            userLogin = login;
        }

        #region Func
        private void UserForm_Load(object sender, EventArgs e)
        {
            timerAFK.Start();
            this.Width = 613;
            this.Height = 435;
            tabPageBucket.Parent = null;
            roundedControl();
            using (BatteriesEntities db = new BatteriesEntities())
            {
                userData = db.user.Single(p => p.login == userLogin);
                db.order.Add(new order
                {
                    idUser = userData.idUser,
                    status = "Активен",
                    orderDate = DateTime.Now,
                });
                db.SaveChanges();
            }
            setDataFunc();
            loadListItems();
        }

        private void tabPage_MouseMove(object sender, MouseEventArgs e)
        {
            timerCounter = 0;
        }

        private void tabPage_KeyDown(object sender, KeyEventArgs e)
        {
            timerCounter = 0;
        }
        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            enterForm.Show();
            using (BatteriesEntities db = new BatteriesEntities())
            {
                if (db.order.Where(p => p.idUser == userData.idUser && p.status == "Активен").Count() > 0)
                {
                    var mainOrder = db.order.Where(p => p.idUser == userData.idUser && p.status == "Активен").OrderByDescending(p => p.orderDate).ToList()[0];
                    mainOrder.status = "Отменен";
                    db.Entry(mainOrder).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
        }

        private void timerAFK_Tick(object sender, EventArgs e)
        {
            timerCounter++;
            if (timerCounter == 120)
            {
                this.Close();
                enterForm.Show();
            }
        }

        private void UserForm_VisibleChanged(object sender, EventArgs e)
        {
            timerCounter = 0;
            if (this.Visible == false)
            {
                timerAFK.Stop();
            }
            else
            {
                timerAFK.Start();
            }
        }

        private void tabPage_Selected(object sender, TabControlEventArgs e)
        {
            if (tabPage.SelectedTab == tabPageGoods)
            {
                this.Width = 841;
                this.Height = 625;
            }
            if (tabPage.SelectedTab == tabPageBucket)
            {
                loadGridBucketItems();
                this.Width = 841;
                this.Height = 625;
            }
            if (tabPage.SelectedTab == tabPageProfile)
            {
                this.Width = 613;
                this.Height = 435;
            }
        }

        private void updateData()
        {
            string rbText = "";
            foreach (var pb in tabPageProfile.Controls.OfType<RadioButton>())
            {
                if (pb.Checked)
                {
                    rbText = pb.Text;
                }
            }
            userData.login = textBoxLogin.Text;
            userData.password = textBoxPassword.Text;
            userData.name = textBoxName.Text;
            userData.surname = textBoxSurname.Text;
            userData.patronymic = textBoxPatronymic.Text;
            userData.birthday = maskedTextBoxBirthday.Text;
            userData.phoneNumber = maskedTextBoxPhoneNumber.Text;
            userData.gender = rbText;
            if (pictureBoxProfileImage.Image != null)
            {
                userData.userPhoto = convertImageToBytes(pictureBoxProfileImage.Image);
            }
        }

        private void setDataFunc()
        {
            textBoxLogin.Text = userData.login;
            textBoxPassword.Text = userData.password;
            textBoxName.Text = userData.name;
            textBoxSurname.Text = userData.surname;
            textBoxPatronymic.Text = userData.patronymic;
            textBoxRole.Text = userData.role;
            maskedTextBoxBirthday.Text = userData.birthday;
            maskedTextBoxPhoneNumber.Text = userData.phoneNumber;
            if (userData.userPhoto != null)
            {
                try
                {
                    pictureBoxProfileImage.Image = convertByteArrayToImage(userData.userPhoto);
                } catch
                {
                    pictureBoxProfileImage.Image = null;
                }
            }
            if (userData.gender == "Мужской")
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonFemale.Checked = true;
            }
            using (BatteriesEntities db = new BatteriesEntities())
            {
                foreach (var ateliers in db.Shop.ToList())
                {
                    comboBoxAtelier.Items.Add(ateliers.nameShop);
                }
            }
        }

        private Image convertByteArrayToImage(byte[] data)
        {
            using (MemoryStream memoryStream = new MemoryStream(data, 0, data.Length))
            {
                return Image.FromStream(memoryStream, true);
            }
        }

        private byte[] convertImageToBytes(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }

        private void loadListItems()
        {
            flowLayoutPanelGoods.Controls.Clear();
            using (BatteriesEntities db = new BatteriesEntities())
            {
                listItem[] listItems = new listItem[db.menu.Count()];
                int i = 0;
                foreach (var item in db.menu.ToList())
                {
                    listItems[i] = new listItem(this);
                    listItems[i].IdBatteries = item.idBatteries;
                    listItems[i].DetailName = item.nameBatteries;
                    listItems[i].BatteriesPrice = item.priceBatteries;
                    listItems[i].DetailDescription = item.descriptionBatteries;
                    listItems[i].WidthItem = 240;
                    listItems[i].HeightItem = 304;
                    if (item.photoBatteries != null)
                    {
                        listItems[i].DetailImage = convertByteArrayToImage(item.photoBatteries);
                    }
                    flowLayoutPanelGoods.Controls.Add(listItems[i]);
                    i++;
                }
            }
        }

        private void roundedControl()
        {
            foreach (var tabPageControl in tabPage.Controls.OfType<TabPage>())
            {
                foreach (var pb in tabPageControl.Controls.OfType<Button>())
                {
                    IntPtr ptr = Rounded(0, 0, pb.Width, pb.Height, 20, 20);
                    pb.Region = Region.FromHrgn(ptr);
                }
            }
        }

        internal void loadGridBucketItems()
        {
            flowLayoutPanelBucket.Controls.Clear();
            using (BatteriesEntities db = new BatteriesEntities())
            {
                if (db.order.Where(p => p.idUser == userData.idUser && p.status == "Активен").Count() > 0)
                {
                    var order = db.order.Where(p => p.idUser == userData.idUser && p.status == "Активен").OrderByDescending(p => p.orderDate).ToList()[0];
                    if (db.batteriesBucket.Where(p => p.idOrder == order.idOrder).Count() > 0)
                    {
                        bucketListItem[] bucketListItems = new bucketListItem[db.batteriesBucket.Where(p => p.idOrder == order.idOrder).Count()];
                        int i = 0;
                        foreach (var item in db.batteriesBucket.Where(p => p.idOrder == order.idOrder).ToList())
                        {
                            var detail = db.menu.Single(p => p.idBatteries == item.idBatteries);
                            bucketListItems[i] = new bucketListItem(this);
                            bucketListItems[i].IdBucket = item.idBucket;
                            bucketListItems[i].DetailName = detail.nameBatteries;
                            bucketListItems[i].DetailPrice = detail.priceBatteries;
                            bucketListItems[i].DetailDescription = detail.descriptionBatteries;
                            bucketListItems[i].WidthItem = 250;
                            bucketListItems[i].HeightItem = 172;
                            if (detail.photoBatteries != null)
                            {
                                bucketListItems[i].DetailImage = convertByteArrayToImage(detail.photoBatteries);
                            }

                            flowLayoutPanelBucket.Controls.Add(bucketListItems[i]);
                            i++;
                        }
                    }
                }
            }
        }

        private void loadListBucketItems()
        {
            flowLayoutPanelBucket.Controls.Clear();
            using (BatteriesEntities db = new BatteriesEntities())
            {
                var order = db.order.Single(p => p.idUser == userData.idUser && p.status == "Активен");
                if (db.batteriesBucket.Where(p => p.idOrder == order.idOrder).Count() > 0)
                {
                    bucketListItem[] bucketListItems = new bucketListItem[db.batteriesBucket.Where(p => p.idOrder == order.idOrder).Count()];
                    int i = 0;
                    foreach (var item in db.batteriesBucket.Where(p => p.idOrder == order.idOrder).ToList())
                    {
                        var detail = db.menu.Single(p => p.idBatteries == item.idBatteries);
                        bucketListItems[i] = new bucketListItem(this);
                        bucketListItems[i].IdBucket = item.idBucket;
                        bucketListItems[i].DetailName = detail.nameBatteries;
                        bucketListItems[i].DetailPrice = detail.priceBatteries;
                        bucketListItems[i].DetailDescription = detail.descriptionBatteries;
                        bucketListItems[i].WidthItem = 475;
                        bucketListItems[i].HeightItem = 304;
                        if (detail.photoBatteries != null)
                        {
                            bucketListItems[i].DetailImage = convertByteArrayToImage(detail.photoBatteries);
                        }

                        flowLayoutPanelBucket.Controls.Add(bucketListItems[i]);
                        i++;
                    }
                }
            }
        }

        private void visibleChanged(bool vis)
        {
            foreach (var pb in tabPageProfile.Controls.OfType<TextBox>())
            {
                if (pb.Name != "textBoxRole")
                {
                    pb.Enabled = vis;
                }

            }
            foreach (var pb in tabPageProfile.Controls.OfType<MaskedTextBox>())
            {
                pb.Enabled = vis;
            }
            foreach (var pb in tabPageProfile.Controls.OfType<RadioButton>())
            {
                pb.Enabled = vis;
            }
            buttonEdit.Enabled = !vis;
            buttonChangeImage.Enabled = vis;
            buttonAccept.Enabled = vis;
        }
        #endregion

        #region ChangeYourProgile

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            visibleChanged(true);
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            visibleChanged(false);
            using (BatteriesEntities db = new BatteriesEntities())
            {
                updateData();
                db.Entry(userData).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            MessageBox.Show("Успешное изменение данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxProfileImage.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Goods
        private void pictureBoxGrid_Click(object sender, EventArgs e)
        {
            flowLayoutPanelGoods.Controls.Clear();
            using (BatteriesEntities db = new BatteriesEntities())
            {
                listItem[] listItems = new listItem[db.menu.Count()];
                int i = 0;
                foreach (var item in db.menu.ToList())
                {
                    listItems[i] = new listItem(this);
                    listItems[i].IdBatteries = item.idBatteries;
                    listItems[i].DetailName = item.nameBatteries;
                    listItems[i].BatteriesPrice = item.priceBatteries;
                    listItems[i].DetailDescription = item.descriptionBatteries;
                    listItems[i].WidthItem = 240;
                    listItems[i].HeightItem = 304;
                    if (item.photoBatteries != null)
                    {
                        listItems[i].DetailImage = convertByteArrayToImage(item.photoBatteries);
                    }
                    flowLayoutPanelGoods.Controls.Add(listItems[i]);
                    i++;
                }
            }
        }

        private void pictureBoxList_Click(object sender, EventArgs e)
        {
            flowLayoutPanelGoods.Controls.Clear();
            using (BatteriesEntities db = new BatteriesEntities())
            {
                listItem[] listItems = new listItem[db.menu.Count()];
                int i = 0;
                foreach (var item in db.menu.ToList())
                {
                    listItems[i] = new listItem(this);
                    listItems[i].IdBatteries = item.idBatteries;
                    listItems[i].DetailName = item.nameBatteries;
                    listItems[i].BatteriesPrice = item.priceBatteries;
                    listItems[i].DetailDescription = item.descriptionBatteries;
                    listItems[i].WidthItem = 740;
                    listItems[i].HeightItem = 608;
                    if (item.photoBatteries != null)
                    {
                        listItems[i].DetailImage = convertByteArrayToImage(item.photoBatteries);
                    }

                    flowLayoutPanelGoods.Controls.Add(listItems[i]);
                    i++;
                }
            }
        }

        private void pictureBoxBucket_Click(object sender, EventArgs e)
        {
            tabPageBucket.Parent = tabPage;
            tabPage.SelectedTab = tabPageBucket;
        }

        private void AddToOrder()
        {
            using (BatteriesEntities db = new BatteriesEntities())
            {
                if (db.order.Where(p => p.idUser == userData.idUser && p.status == "Активен").Count() > 0)
                {
                    var order = db.order.Where(p => p.idUser == userData.idUser && p.status == "Активен").OrderByDescending(p => p.orderDate).ToList()[0]; //Изменить!
                    var atelier = db.Shop.Single(p => p.nameShop == comboBoxAtelier.Text);
                    order.totalPrice = totalPrice;
                    order.idShop = atelier.idShop;
                    db.Entry(order).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Ваш заказ #" + order.idOrder + " оформлен");
                }
                this.Close();
            }
        }
        #endregion

        #region Bucket
        private void pictureBoxGridBucket_Click(object sender, EventArgs e)
        {
            loadGridBucketItems();
        }

        private void pictureBoxListBucket_Click(object sender, EventArgs e)
        {
            loadListBucketItems();
        }

        private void buttonAceptdetailOrder_Click(object sender, EventArgs e)
        {
            AddToOrder();
        }

        private void buttonCanceldetailOrder_Click(object sender, EventArgs e)
        {
            using (BatteriesEntities db = new BatteriesEntities())
            {
                var order = db.order.Single(p => p.idUser == userData.idUser && p.status == "Активен");
                order.status = "Отменен";
                db.Entry(order).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            MessageBox.Show("Ваш заказ отменен");
            this.Close();
        }

        private void comboBoxAtelier_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAceptdetailOrder.Enabled = true;
        }
        #endregion
    }
}
