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

        public static User currentUser;

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
                    case "student":
                        pnAddStudent.BackColor = Color.FromArgb(250, 82, 82);
                        btnAddStudent.BackColor = Color.FromArgb(250, 232, 234);
                        btnAddStudent.ForeColor = Color.FromArgb(250, 82, 82);
                        btnAddStudent.Font = new Font(btnAddStudent.Font, FontStyle.Bold);
                        btnAddStudent.Image = Properties.Resources.student_24_red;
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

                pnAddStudent.BackColor = Color.White;
                btnAddStudent.BackColor = Color.White;
                btnAddStudent.ForeColor = Color.Black;
                btnAddStudent.Font = new Font(btnAddStudent.Font, FontStyle.Regular);
                btnAddStudent.Image = Properties.Resources.student_24_black;
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
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                HighlightButtonClicked("student");
                frm_UserInformation frm_AddUser = new frm_UserInformation(Role.Student);
                frm_AddUser.ShowDialog();
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
                if (cmbRole.Text.Contains("Tất cả"))
                {
                    users = UserController.Instance().GetAllUser();
                    users.ForEach(FillToDgvUser);
                }
                else
                {
                    for (int i = 0; i < cmbRole.Items.Count; i++)
                    {
                        if (cmbRole.CheckBoxItems[i].Checked)
                        {
                            if (cmbRole.CheckBoxItems[i].Text == "Giảng viên")
                            {
                                users = UserController.Instance().GetAllUserByRole(Role.Instructor);
                            }
                            else if (cmbRole.CheckBoxItems[i].Text == "Sinh viên")
                            {
                                users = UserController.Instance().GetAllUserByRole(Role.Student);
                            }
                            users.ForEach(FillToDgvUser);
                        }
                    }
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
                cell7.Value = user.Role == Role.Instructor ? "Giảng viên" : user.Role == Role.Student ? "Sinh viên" : "";
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
                frm_UserInformation frm_UserInformation = new frm_UserInformation();
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
            InitIconButton();
        }
    }
}
