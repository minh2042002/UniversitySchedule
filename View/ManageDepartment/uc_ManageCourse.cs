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
    public partial class uc_ManageCourse : UserControl
    {
        public uc_ManageCourse()
        {
            InitializeComponent();
        }

        public static Course currentCourse;

        private void FillToDgvCourse(Course course)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                cell1.Value = (dgvCourse.Rows.Count + 1).ToString();
                row.Cells.Add(cell1);

                DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                cell2.Value = course.Name;
                row.Cells.Add(cell2);

                DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
                cell3.Value = course.Credit;
                row.Cells.Add(cell3);

                DataGridViewTextBoxCell cell4 = new DataGridViewTextBoxCell();
                cell4.Value = course.MaxStudent;
                row.Cells.Add(cell4);

                DataGridViewTextBoxCell cell5 = new DataGridViewTextBoxCell();
                cell5.Value = course.NumberClass;
                row.Cells.Add(cell5);

                DataGridViewTextBoxCell cell6 = new DataGridViewTextBoxCell();
                cell6.Value = course.Instructors?.Count;
                row.Cells.Add(cell6);

                DataGridViewTextBoxCell cell7 = new DataGridViewTextBoxCell();
                cell7.Value = course.Department?.Name;
                row.Cells.Add(cell7);

                row.Tag = course;

                Invoke(new MethodInvoker(delegate ()
                {
                    dgvCourse.Rows.Add(row);
                }));
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void LoadDepartmentFromDatabase()
        {
            try
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
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void LoadCourseByDepartmentSelected()
        {
            try
            {
                dgvCourse.Rows.Clear();
                if (cmbDepartment.Text.Contains("Tất cả"))
                {
                    List<Course> courses = CourseController.Instance().GetAllCourse();
                    courses.ForEach(FillToDgvCourse);
                }
                else
                {
                    for (int i = 0; i < cmbDepartment.Items.Count; i++)
                    {
                        if (cmbDepartment.CheckBoxItems[i].Checked)
                        {
                            Department department = DepartmentController.Instance().GetDepartmentByName(cmbDepartment.CheckBoxItems[i].Text);
                            List<Course> courses = CourseController.Instance().GetCourseByDepartment(department);
                            courses.ForEach(FillToDgvCourse);
                        }
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCourseByDepartmentSelected();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDepartmentFromDatabase();
        }

        private void editCourse_Click(object sender, EventArgs e)
        {
            try
            {
                currentCourse = dgvCourse.CurrentRow.Tag as Course;
                frm_AddCourse frm_AddCourse = new frm_AddCourse(updateMode: true);
                frm_AddCourse.ShowDialog();
                LoadCourseByDepartmentSelected();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void deleteCourse_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa môn học này không ?\n Việc xóa môn học sẽ xóa tất cả dữ liệu liên quan đến môn học này!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    currentCourse = dgvCourse.CurrentRow.Tag as Course;
                    int deleteResult = CourseController.Instance().DeleteCourse(currentCourse);
                    if (deleteResult == 0)
                    {
                        MessageBox.Show("Không tồn tại môn học này!", "Thông Báo");
                    }
                    else if (deleteResult == -1)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại!", "Thông Báo");
                    }
                    else if (deleteResult == 1)
                    {
                        MessageBox.Show("Xóa môn học thành công.", "Thông báo");
                        LoadCourseByDepartmentSelected();
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void uc_ManageCourse_Load(object sender, EventArgs e)
        {
            LoadDepartmentFromDatabase();
        }
    }
}
