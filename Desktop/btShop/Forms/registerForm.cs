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
using tuningAtelier.ENT;

namespace tuningAtelier.Forms
{
    public partial class registerForm : Form
    {
        #region Properties
        private Form enterForm;
        private int timerCounter = 0;
        #endregion
        public registerForm(Form main)
        {
            InitializeComponent();
            enterForm = main;
        }
        #region Func
        private byte[] convertImageToBytes(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }

        private bool checkUser()
        {
            using (BatteriesEntities db = new BatteriesEntities())
            {
                if (db.user.Any(p => p.login == textBoxLogin.Text))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private void RegisterForm_VisibleChanged(object sender, EventArgs e)
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
        private void registerForm_Load(object sender, EventArgs e)
        {
            timerAFK.Start();
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            enterForm.Show();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            enterForm.Show();
        }

        private void RegisterForm_KeyDown(object sender, KeyEventArgs e)
        {
            timerCounter = 0;
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            timerCounter = 0;
        }
        #endregion

        #region Register
        private void buttonLoadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxPhoto.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            foreach (var pb in this.Controls.OfType<TextBox>())
            {
                if (pb.Text == "" && pb.Name != "textBoxPatronymic")
                {
                    MessageBox.Show("Одно или несколько полей пустые", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            foreach (var pb in this.Controls.OfType<MaskedTextBox>())
            {
                if (!pb.MaskCompleted)
                {
                    MessageBox.Show("Одно или несколько полей пустые", "Ошибка");
                    return;
                }
            }
            if (textBoxPassword.Text == textBoxAcceptPassword.Text)
            {
                if (checkUser())
                {
                    MessageBox.Show("Такой пользователь уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (radioButtonFemale.Checked || radioButtonMale.Checked)
                {
                    string rbText = "";
                    foreach (var pb in this.Controls.OfType<RadioButton>())
                    {
                        if (pb.Checked)
                        {
                            rbText = pb.Text;
                        }
                    }
                    if (pictureBoxPhoto.Image == null)
                    {
                        using (BatteriesEntities db = new BatteriesEntities())
                        {
                            db.user.Add(new user
                            {
                                login = textBoxLogin.Text.Trim(),
                                password = textBoxPassword.Text.Trim(),
                                gender = rbText,
                                surname = textBoxSurname.Text.Trim(),
                                name = textBoxName.Text.Trim(),
                                patronymic = textBoxPatronymic.Text.Trim(),
                                role = "Пользователь",
                                birthday = maskedTextBoxBirthday.Text,
                                phoneNumber = maskedTextBoxPhoneNumber.Text,
                                status = "Активен"
                            });
                            db.SaveChanges();
                        }
                        MessageBox.Show("Успешная регистрация", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        enterForm.Show();
                    }
                    else
                    {
                        using (BatteriesEntities db = new BatteriesEntities())
                        {
                            db.user.Add(new user
                            {
                                login = textBoxLogin.Text.Trim(),
                                password = textBoxPassword.Text.Trim(),
                                gender = rbText,
                                surname = textBoxSurname.Text.Trim(),
                                name = textBoxName.Text.Trim(),
                                patronymic = textBoxPatronymic.Text.Trim(),
                                userPhoto = convertImageToBytes(pictureBoxPhoto.Image),
                                role = "Пользователь",
                                birthday = maskedTextBoxBirthday.Text,
                                phoneNumber = maskedTextBoxPhoneNumber.Text,
                                status = "Активен"
                            });
                            db.SaveChanges();
                        }
                        MessageBox.Show("Успешная регистрация", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        enterForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали пол", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerAFK_Tick(object sender, EventArgs e)
        {
            timerCounter++;
            if (timerCounter == 60)
            {
                this.Close();
                enterForm.Show();
            }
        }
        #endregion
    }
}
