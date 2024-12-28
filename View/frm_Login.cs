using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySchedule.Controllers;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;

namespace UniversitySchedule.View
{
    public partial class frm_Login : Form
    {
        public frm_Login(bool isLogout = false)
        {
            IsLogout = isLogout;
            InitializeComponent();
        }

        private SettingLogin settingLogin = new SettingLogin();
        private bool IsLogout;
        private bool HidePassword = true;
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHideForm_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                settingLogin.Update("txtUsername", txtUsername.Text);
                settingLogin.Update("txtPassword", txtPassword.Text);
                settingLogin.Update("chkRemember", chkRemember.Checked);
                settingLogin.Save();

                Thread thread = new Thread(new ThreadStart(CheckLogin));
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            try
            {
                HidePassword = true;
                btnHidePassword.BackgroundImage = Properties.Resources.eye_hide_24_red;
                txtUsername.Text = settingLogin.GetValue("txtUsername");
                txtPassword.Text = settingLogin.GetValue("txtPassword");
                if (IsLogout)
                {
                    chkRemember.Checked = false;
                    settingLogin.Update("chkRemember", chkRemember.Checked);
                    settingLogin.Save();
                }
                chkRemember.Checked = settingLogin.GetValueBool("chkRemember");

                if (chkRemember.Checked && !IsLogout)
                {
                    Thread thread = new Thread(new ThreadStart(CheckLogin));
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void CheckLogin()
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string passwordHash = ValidateInformation.Password.Hash(password);
                if (username.IsNullOrEmpty() || password.IsNullOrEmpty())
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                var (isSuccess, message, user) = UserController.Instance().Login(username, passwordHash);

                if (isSuccess)
                {
                    UserLogin.User = user;
                    Thread thread = new Thread(new ThreadStart(() =>
                    {
                        try
                        {
                            frm_Main frm_Main = new frm_Main();
                            frm_Main.ShowDialog();
                        }
                        catch (Exception ex) { Log4Net.LogException(ex, ""); }
                    }));
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            try
            {
                HidePassword = !HidePassword;
                if (HidePassword)
                {
                    txtPassword.PasswordChar = '*';
                    btnHidePassword.BackgroundImage = Properties.Resources.eye_hide_24_red;
                }
                else
                {
                    txtPassword.PasswordChar = '\0';
                    btnHidePassword.BackgroundImage = Properties.Resources.eye_show_24_red;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }
    }
}
