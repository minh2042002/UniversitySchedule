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
using static UniversitySchedule.View.ManageDepartment.uc_ManageCourse;
namespace UniversitySchedule.View.ManageDepartment
{
    public partial class frm_AddCourse : Form
    {
        public frm_AddCourse(bool updateMode = false)
        {
            update_mode = updateMode;
            InitializeComponent();
        }

        private bool update_mode = false;
        private List<Department> departments;
        private void frm_AddCourse_Load(object sender, EventArgs e)
        {
            try
            {
                if (update_mode)
                {
                    this.Text = "Thông tin môn học";
                    txtNameCourse.Text = currentCourse.Name;
                    numCredit.Value = currentCourse.Credit;
                    numMaxStudent.Value = currentCourse.MaxStudent;
                    numClass.Value = currentCourse.NumberClass;
                    LoadDepartmentFromDatabase();
                    cmbDepartment.SelectedItem = currentCourse.Department.Name;
                }
                else
                {
                    this.Text = "Thêm môn học";
                    txtNameCourse.Text = "";
                    numCredit.Value = 2;
                    numMaxStudent.Value = 50;
                    numClass.Value = 2;
                    LoadDepartmentFromDatabase();
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
                if (txtNameCourse.Text.IsNullOrEmpty() || cmbDepartment.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                if (update_mode)
                {
                    currentCourse.Name = txtNameCourse.Text;
                    currentCourse.Credit = (int)numCredit.Value;
                    currentCourse.MaxStudent = (int)numMaxStudent.Value;
                    currentCourse.NumberClass = (int)numClass.Value;
                    if (cmbDepartment.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng chọn bộ môn!", "Thông Báo");
                        return;
                    }

                    Department department = DepartmentController.Instance().GetDepartmentByName(cmbDepartment.SelectedItem.ToString());
                    currentCourse.Department = null;
                    currentCourse.DepartmentId = department.Id;

                    int updateResult = CourseController.Instance().UpdateCourse(currentCourse);
                    if (updateResult == 0)
                    {
                        MessageBox.Show("Không tồn tại môn học này!", "Thông Báo");
                    }
                    else if (updateResult == -1)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại!", "Thông Báo");
                    }
                    else if (updateResult == 1)
                    {
                        MessageBox.Show("Cập nhật môn học thành công.", "Thông báo");
                        this.Close();
                    }
                }
                else
                {
                    Course newCourse = new Course();
                    newCourse.Name = txtNameCourse.Text;
                    newCourse.Credit = (int)numCredit.Value;
                    newCourse.MaxStudent = (int)numMaxStudent.Value;
                    newCourse.NumberClass = (int)numClass.Value;
                    if (cmbDepartment.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng chọn bộ môn!", "Thông Báo");
                        return;
                    }

                    Department department = DepartmentController.Instance().GetDepartmentByName(cmbDepartment.SelectedItem.ToString());
                    newCourse.DepartmentId = department.Id;

                    int addResult = CourseController.Instance().InsertCourse(newCourse);
                    if (addResult == 0)
                    {
                        MessageBox.Show("Đã tồn tại môn học này!", "Thông Báo");
                    }
                    else if (addResult == -1)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại!", "Thông Báo");
                    }
                    else if (addResult == 1)
                    {
                        MessageBox.Show("Thêm môn học thành công.", "Thông báo");
                        this.Text = "Thêm môn học";
                        txtNameCourse.Text = "";
                        numCredit.Value = 2;
                        numMaxStudent.Value = 50;
                        numClass.Value = 2;
                        cmbDepartment.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }
    }
}
