using Microsoft.VisualBasic.Devices;
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

namespace UniversitySchedule.View.ManageDepartment
{
    public partial class uc_ManageInstructor : UserControl
    {
        public uc_ManageInstructor()
        {
            InitializeComponent();
        }

        private void FillToDgvInstructor(Instructor instructor)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                cell1.Value = (dgvInstructor.Rows.Count + 1).ToString();
                row.Cells.Add(cell1);

                DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                cell2.Value = instructor.User.Information.Name;
                row.Cells.Add(cell2);

                DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
                cell3.Value = instructor.User.Information.Phone;
                row.Cells.Add(cell3);

                DataGridViewTextBoxCell cell4 = new DataGridViewTextBoxCell();
                cell4.Value = instructor.User.Information.Email;
                row.Cells.Add(cell4);

                DataGridViewTextBoxCell cell5 = new DataGridViewTextBoxCell();
                cell5.Value = instructor.User.Information.DayOfBirth;
                row.Cells.Add(cell5);

                DataGridViewTextBoxCell cell6 = new DataGridViewTextBoxCell();
                cell6.Value = instructor.User.Role == Role.Head ? "Trưởng bộ môn" : instructor.User.Role == Role.Instructor ? "Giảng viên" : "";
                row.Cells.Add(cell6);

                DataGridViewTextBoxCell cell7 = new DataGridViewTextBoxCell();
                cell7.Value = instructor.Department.Name;
                row.Cells.Add(cell7);

                row.Tag = instructor;

                Invoke(new MethodInvoker(delegate ()
                {
                    dgvInstructor.Rows.Add(row);
                }));
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void LoadDepartmentFromDatabase()
        {
            try
            {
                if (UserLogin.User.Role == Role.Admin)
                {
                    List<Department> departments = DepartmentController.Instance().GetAllDepartment()?.ToList() ?? new List<Department>();
                    if (departments.Count() > 0)
                    {
                        cmbDepartment.Items.Clear();
                        cmbDepartment.Items.Add("Tất cả");
                        foreach (Department department in departments)
                        {
                            cmbDepartment.Items.Add(department.Name);
                        }
                    }
                }
                else if (UserLogin.User.Role == Role.Head)
                {
                    Department department = DepartmentController.Instance().GetDepartmentByName(UserLogin.User.Instructor.Department.Name);
                    cmbDepartment.Items.Clear();
                    cmbDepartment.Items.Add(department.Name);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void LoadInstructorByDepartmentSelected()
        {
            try
            {
                dgvInstructor.Rows.Clear();
                if (cmbDepartment.Text.Contains("Tất cả"))
                {
                    List<Instructor> instructors = InstructorController.Instance().GetAllInstructorDetail();
                    instructors.ForEach(FillToDgvInstructor);
                }
                else
                {
                    for (int i = 0; i < cmbDepartment.Items.Count; i++)
                    {
                        if (cmbDepartment.CheckBoxItems[i].Checked)
                        {
                            Department department = DepartmentController.Instance().GetDepartmentByName(cmbDepartment.CheckBoxItems[i].Text);
                            List<Instructor> instructors = InstructorController.Instance().GetInstructorByDepartment(department);
                            instructors.ForEach(FillToDgvInstructor);
                        }
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadInstructorByDepartmentSelected();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDepartmentFromDatabase();
        }

        private void uc_ManageInstructor_Load(object sender, EventArgs e)
        {
            try
            {
                if (UserLogin.User.Role == Role.Admin)
                {
                    moveDepartment.Enabled = true;
                    moveDepartment.Visible = true;

                    setHead.Enabled = true;
                    setHead.Visible = true;
                }
                else
                {
                    moveDepartment.Enabled = false;
                    moveDepartment.Visible = false;

                    setHead.Enabled = false;
                    setHead.Visible = false;
                }
                LoadDepartmentFromDatabase();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void moveDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                Instructor currentInstructor = dgvInstructor.CurrentRow.Tag as Instructor;
                frm_MoveDepartment frm_MoveDepartment = new frm_MoveDepartment(currentInstructor);
                frm_MoveDepartment.ShowDialog();
                LoadInstructorByDepartmentSelected();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void manageCourse_Click(object sender, EventArgs e)
        {
            try
            {
                Instructor currentInstructor = dgvInstructor.CurrentRow.Tag as Instructor;
                frm_ChooseCourse frm_ChooseCourse = new frm_ChooseCourse(currentInstructor);
                frm_ChooseCourse.ShowDialog();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void setHead_Click(object sender, EventArgs e)
        {
            try
            {
                Instructor currentInstructor = dgvInstructor.CurrentRow.Tag as Instructor;
                int updateResult = UserController.Instance().SetHeadForInstructor(currentInstructor);
                if (updateResult == 0)
                {
                    MessageBox.Show("Không tồn tại giảng viên này!", "Thông Báo");
                }
                else if (updateResult == -1)
                {
                    MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại!", "Thông Báo");
                }
                else if (updateResult == 1)
                {
                    MessageBox.Show("Đặt làm trưởng bộ môn thành công.", "Thông báo");
                }

                LoadInstructorByDepartmentSelected();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }
    }
}
