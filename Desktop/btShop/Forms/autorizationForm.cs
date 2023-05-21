using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tuningAtelier.Class;
using tuningAtelier.ENT;
using tuningAtelier.Forms;
using tuningAtelier.Properties;

namespace tuningAtelier
{
    public partial class autorizationForm : Form
    {
        #region Properties
        private int timerCounter = 0;
        private string filePath = "rememberMe.txt";
        private string[] fileData;
        private int wrongPasswordCount = 0;
        private int number = 0;
        #endregion

        public autorizationForm()
        {
            InitializeComponent();
        }

        #region Func
        private void loadCaptchaImage()
        {
            Random rnd = new Random();
            number = rnd.Next(1234, 9999);
            var image = new Bitmap(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
            var font = new Font("Ink Free", 35, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(number.ToString(), font, Brushes.Red, new Point(pictureBoxCaptcha.Width / 7, pictureBoxCaptcha.Height / 5));
            pictureBoxCaptcha.Image = image;
        }
        private void enterRegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            timerCounter = 0;
        }

        private void enterRegisterForm_KeyDown(object sender, KeyEventArgs e)
        {
            timerCounter = 0;
            if (e.KeyCode == Keys.Enter)
            {
                buttonEnter.PerformClick();
            }
        }


        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                if (fileData.Contains(textBoxLogin.Text))
                {
                    textBoxPassword.Text = RcaCryptDecrypt.DeCrypt(fileData[Array.IndexOf(fileData, textBoxLogin.Text) + 1]);
                }
            }
        }

        private void enterRegisterForm_Load(object sender, EventArgs e)
        {
            this.Width = 182;
            this.Height = 205;
            timerAFK.Start();
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    fileData = sr.ReadToEnd().Trim().Split('\n');
                }
            }
        }

        private void enterRegisterForm_VisibleChanged(object sender, EventArgs e)
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
        private void TimerAFK_Tick(object sender, EventArgs e)
        {
            timerCounter++;
            if (timerCounter == 60)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Enter
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            foreach (var pb in this.Controls.OfType<TextBox>())
            {
                if (pb.Text == "" && pb.Name != "textBoxCaptcha")
                {
                    MessageBox.Show("Одно или несколько полей пустые", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            using (BatteriesEntities db = new BatteriesEntities())
            {
                if (db.user.Any(p => p.login == textBoxLogin.Text))
                {
                    var userData = db.user.Single(p => p.login == textBoxLogin.Text);
                    if (pictureBoxCaptcha.Visible == true)
                    {

                        if (textBoxCaptcha.Text != number.ToString())
                        {
                            MessageBox.Show("Попробуйте еще раз ввести Captcha", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            loadCaptchaImage();
                        }
                        else if (textBoxPassword.Text != userData.password)
                        {
                            MessageBox.Show("Неправильный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            loadCaptchaImage();
                        }
                        else
                        {
                            if (userData.status == "Неактивен")
                            {
                                MessageBox.Show("Аккаунт неактивен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (userData.role == "Админ")
                            {
                                wrongPasswordCount = 0;
                                adminForm AdminForm = new adminForm(this, userData.login);
                                AdminForm.Show(this);
                                this.Hide();
                                if (checkBoxMemorize.Checked)
                                {
                                    using (StreamWriter strem = new StreamWriter(filePath))
                                        strem.WriteLine(textBoxLogin.Text + "\n" + RcaCryptDecrypt.Crypt(textBoxPassword.Text));
                                }
                            }
                            else if (userData.role == "Менеджер по продажам")
                            {
                                wrongPasswordCount = 0;
                                managerForm ManagerForm = new managerForm();
                                ManagerForm.Owner = this;
                                ManagerForm.Show();
                                this.Hide();
                                if (checkBoxMemorize.Checked)
                                {
                                    using (StreamWriter strem = new StreamWriter(filePath))
                                        strem.WriteLine(textBoxLogin.Text + "\n" + RcaCryptDecrypt.Crypt(textBoxPassword.Text));
                                }
                            }
                            else
                            {
                                wrongPasswordCount = 0;
                                userForm UserForm = new userForm(this, userData.login);
                                UserForm.Show(this);
                                this.Hide();
                                if (checkBoxMemorize.Checked)
                                {
                                    using (StreamWriter strem = new StreamWriter(filePath))
                                        strem.WriteLine(textBoxLogin.Text + "\n" + RcaCryptDecrypt.Crypt(textBoxPassword.Text));
                                }
                            }
                        }
                    }
                    else if (textBoxPassword.Text != userData.password)
                    {
                        MessageBox.Show("Неправильный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        wrongPasswordCount++;
                        if (wrongPasswordCount >= 3)
                        {
                            pictureBoxCaptcha.Visible = true;
                            labelCaptcha.Visible = true;
                            textBoxCaptcha.Visible = true;
                            pictureBoxRefreshCaptcha.Visible = true;
                            pictureBoxRefreshCaptcha.BringToFront();
                            this.Height = 330;
                            loadCaptchaImage();
                        }
                    }
                    else
                    {
                        if (userData.status == "Неактивен")
                        {
                            MessageBox.Show("Аккаунт неактивен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (userData.role == "Админ")
                        {
                            wrongPasswordCount = 0;
                            adminForm AdminForm = new adminForm(this, userData.login);
                            AdminForm.Show(this);
                            this.Hide();
                            if (checkBoxMemorize.Checked)
                            {
                                using (StreamWriter strem = new StreamWriter(filePath))
                                    strem.WriteLine(textBoxLogin.Text + "\n" + RcaCryptDecrypt.Crypt(textBoxPassword.Text));
                            }
                        }
                        else if (userData.role == "Менеджер по продажам")
                        {
                            wrongPasswordCount = 0;
                            managerForm ManagerForm = new managerForm();
                            ManagerForm.Owner = this;
                            ManagerForm.Show();
                            this.Hide();
                            if (checkBoxMemorize.Checked)
                            {
                                using (StreamWriter strem = new StreamWriter(filePath))
                                    strem.WriteLine(textBoxLogin.Text + "\n" + RcaCryptDecrypt.Crypt(textBoxPassword.Text));
                            }
                        }
                        else
                        {
                            wrongPasswordCount = 0;
                            userForm UserForm = new userForm(this, userData.login);
                            UserForm.Show(this);
                            this.Hide();
                            if (checkBoxMemorize.Checked)
                            {
                                using (StreamWriter strem = new StreamWriter(filePath))
                                    strem.WriteLine(textBoxLogin.Text + "\n" + RcaCryptDecrypt.Crypt(textBoxPassword.Text));
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Такого пользователя нету", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            registerForm registerForm = new registerForm(this);
            registerForm.Show(this);
            this.Hide();
        }

        private void pictureBoxEye_Click(object sender, EventArgs e)
        {
            if (!textBoxPassword.UseSystemPasswordChar)
            {
                textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
                pictureBoxEye.Image = Resources.eyeVisible;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
                pictureBoxEye.Image = Resources.eyeInvisible;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxRefreshCaptcha_Click(object sender, EventArgs e)
        {
            loadCaptchaImage();
        }
        #endregion
    }
}
