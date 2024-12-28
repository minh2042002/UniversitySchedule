using Sunny.UI;
using UniversitySchedule.Controllers;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;
namespace UniversitySchedule.View.ManageAccount
{
    public partial class frm_UserInformation : Form
    {
        public frm_UserInformation(User user)
        {
            update_mode = true;
            currentUser = user;
            InitializeComponent();
        }

        public frm_UserInformation(Role roleUser)
        {
            update_mode = false;
            role = roleUser;
            InitializeComponent();
        }

        private bool HidePassword = true;
        private bool update_mode = false;
        private Role role;
        private Information currentInformation;
        private User currentUser;
        private List<Department> departments;

        private void frm_UserInformation_Load(object sender, EventArgs e)
        {
            try
            {
                HidePassword = true;
                btnHidePassword.BackgroundImage = Properties.Resources.eye_hide_24_red;
                if (update_mode)
                {
                    pnAccount.Visible = false;
                    pnHide.Visible = false;
                    pnDepartment.Visible = false;

                    currentInformation = InformationController.Instance().GetInformationByUser(currentUser);
                    txtFullName.Text = currentInformation.Name;

                    txtPhone.Text = currentInformation.Phone;
                    txtPhone.Enabled = txtPhone.Text.IsNullOrEmpty() ? true : false;

                    txtEmail.Text = currentInformation.Email;
                    txtEmail.Enabled = txtEmail.Text.IsNullOrEmpty() ? true : false;

                    dpDayOfBirth.Value = currentInformation.DayOfBirth.ToDateTime(TimeOnly.MinValue);
                }
                else
                {
                    pnAccount.Visible = true;
                    pnHide.Visible = true;
                    pnDepartment.Visible = true;

                    LoadDepartmentFromDatabase();

                    txtPhone.Enabled = true;
                    txtEmail.Enabled = true;
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtFullName.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                    dpDayOfBirth.Value = DateTime.Now.Date;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void LoadDepartmentFromDatabase()
        {
            try
            {
                departments = DepartmentController.Instance().GetAllDepartment()?.ToList() ?? new List<Department>();
                if (departments.Count() > 0)
                {
                    cmbDepartment.Items.Clear();
                    foreach (Department department in departments)
                    {
                        cmbDepartment.Items.Add(department.Name);
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (update_mode)
                {
                    if (txtFullName.Text.IsNullOrEmpty() || txtPhone.Text.IsNullOrEmpty() || txtEmail.Text.IsNullOrEmpty())
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                        return;
                    }

                    currentInformation.Name = txtFullName.Text;
                    currentInformation.DayOfBirth = DateOnly.FromDateTime(dpDayOfBirth.Value);

                    int updateResult = InformationController.Instance().UpdateInformation(currentInformation);
                    if (updateResult == 0)
                    {
                        MessageBox.Show("Không tồn tại thông tin tài khoản này!", "Thông Báo");
                    }
                    else if (updateResult == -1)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại!", "Thông Báo");
                    }
                    else if (updateResult == 1)
                    {
                        MessageBox.Show("Cập nhật thông tin tài khoản thành công.", "Thông báo");
                        this.Close();
                    }
                }
                else
                {
                    if (txtUsername.Text.IsNullOrEmpty() || txtPassword.Text.IsNullOrEmpty() || cmbDepartment.SelectedItem == null || txtFullName.Text.IsNullOrEmpty() || txtPhone.Text.IsNullOrEmpty() || txtEmail.Text.IsNullOrEmpty())
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                        return;
                    }

                    var (isValid, message) = ValidateInformation.Password.Validate(txtPassword.Text);
                    if (isValid)
                    {
                        (isValid, message) = ValidateInformation.Email.Validate(txtEmail.Text);
                        if (isValid)
                        {
                            (isValid, message) = ValidateInformation.Phone.IsPhoneNumber(txtPhone.Text);
                            if (isValid)
                            {
                                User newUser = new User();
                                newUser.Username = txtUsername.Text;
                                newUser.Password = ValidateInformation.Password.Hash(txtPassword.Text);
                                newUser.Role = role;

                                Department department = DepartmentController.Instance().GetDepartmentByName(cmbDepartment.SelectedItem.ToString());

                                newUser.Instructor = new Instructor();
                                newUser.Instructor.DepartmentId = department.Id;

                                newUser.Information = new Information();
                                newUser.Information.Name = txtFullName.Text;
                                newUser.Information.Phone = txtPhone.Text;
                                newUser.Information.Email = txtEmail.Text;
                                newUser.Information.DayOfBirth = DateOnly.FromDateTime(dpDayOfBirth.Value);

                                var (status, message2) = UserController.Instance().InsertUserWithInformation(newUser);
                                if (status == 0)
                                {
                                    MessageBox.Show(message2);
                                }
                                else if (status == -1)
                                {
                                    MessageBox.Show(message2);
                                }
                                else if (status == 1)
                                {
                                    MessageBox.Show(message2);

                                    txtUsername.Text = "";
                                    txtPassword.Text = "";
                                    txtFullName.Text = "";
                                    txtPhone.Text = "";
                                    txtEmail.Text = "";
                                    dpDayOfBirth.Value = DateTime.Now.Date;
                                }
                            }
                            else
                            {
                                MessageBox.Show(message);
                            }
                        }
                        else
                        {
                            MessageBox.Show(message);
                        }
                    }
                    else
                    {
                        MessageBox.Show(message);
                    }
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
