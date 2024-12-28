using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySchedule.Controllers;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;

namespace UniversitySchedule.View.ManageAccount
{
    public partial class uc_ManageAccount_Action : UserControl
    {
        public uc_ManageAccount_Action()
        {
            InitializeComponent();
        }

        private static User currentUser;

        private void HighlightButtonClicked(string button)
        {
            try
            {
                InitIconButton();
                switch (button)
                {
                    case "instructor":
                        pnAddInstructor.BackColor = Color.FromArgb(250, 82, 82);
                        btnAddInstructor.BackColor = Color.FromArgb(250, 232, 234);
                        btnAddInstructor.ForeColor = Color.FromArgb(250, 82, 82);
                        btnAddInstructor.Font = new Font(btnAddInstructor.Font, FontStyle.Bold);
                        btnAddInstructor.Image = Properties.Resources.teacher_24_red;
                        break;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void InitIconButton()
        {
            try
            {
                pnAddInstructor.BackColor = Color.White;
                btnAddInstructor.BackColor = Color.White;
                btnAddInstructor.ForeColor = Color.Black;
                btnAddInstructor.Font = new Font(btnAddInstructor.Font, FontStyle.Regular);
                btnAddInstructor.Image = Properties.Resources.teacher_24_black;
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            try
            {
                HighlightButtonClicked("instructor");
                frm_UserInformation frm_AddUser = new frm_UserInformation(Role.Instructor);
                frm_AddUser.ShowDialog();
                InitIconButton();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadUserByRoleSelected();
        }

        private void LoadUserByRoleSelected()
        {
            try
            {
                List<User> users = new List<User>();
                dgvUser.Rows.Clear();
                users = UserController.Instance().GetAllUserByRole(Role.Instructor);
                if (users.Count > 0)
                {
                    users.ForEach(FillToDgvUser);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void FillToDgvUser(User user)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                cell1.Value = (dgvUser.Rows.Count + 1).ToString();
                row.Cells.Add(cell1);

                DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                cell2.Value = user.Username;
                row.Cells.Add(cell2);

                DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
                cell3.Value = user.Information?.Name!;
                row.Cells.Add(cell3);

                DataGridViewTextBoxCell cell4 = new DataGridViewTextBoxCell();
                cell4.Value = user.Information?.Phone!;
                row.Cells.Add(cell4);

                DataGridViewTextBoxCell cell5 = new DataGridViewTextBoxCell();
                cell5.Value = user.Information?.Email!;
                row.Cells.Add(cell5);

                DataGridViewTextBoxCell cell6 = new DataGridViewTextBoxCell();
                cell6.Value = user.Information?.DayOfBirth!;
                row.Cells.Add(cell6);

                DataGridViewTextBoxCell cell7 = new DataGridViewTextBoxCell();
                cell7.Value = "Giảng viên";
                row.Cells.Add(cell7);

                row.Tag = user;

                Invoke(new MethodInvoker(delegate ()
                {
                    dgvUser.Rows.Add(row);
                }));
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void editInformation_Click(object sender, EventArgs e)
        {
            try
            {
                currentUser = dgvUser.CurrentRow.Tag as User;
                frm_UserInformation frm_UserInformation = new frm_UserInformation(currentUser);
                frm_UserInformation.ShowDialog();
                LoadUserByRoleSelected();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa tài khoản này không ?\n Việc xóa tài khoản sẽ xóa tất cả dữ liệu liên quan đến tài khoản này!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    currentUser = dgvUser.CurrentRow.Tag as User;
                    int deleteResult = UserController.Instance().DeleteUser(currentUser);
                    if (deleteResult == 0)
                    {
                        MessageBox.Show("Không tồn tại tài khoản này!", "Thông Báo");
                    }
                    else if (deleteResult == -1)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại!", "Thông Báo");
                    }
                    else if (deleteResult == 1)
                    {
                        MessageBox.Show("Xóa tài khoản thành công.", "Thông báo");
                        LoadUserByRoleSelected();
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void uc_ManageAccount_Action_Load(object sender, EventArgs e)
        {
            try
            {
                InitIconButton();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                UserLogin.User = null;
                Thread thread = new Thread(new ThreadStart(() =>
                {
                    try
                    {
                        frm_Login frm_Login = new frm_Login(isLogout: true);
                        frm_Login.ShowDialog();
                    }
                    catch (Exception ex) { Log4Net.LogException(ex, ""); }
                }));
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                Application.Exit();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }
    }
}
