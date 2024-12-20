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
using static UniversitySchedule.View.ManageDepartment.uc_ManageInstructor;

namespace UniversitySchedule.View.ManageDepartment
{
    public partial class frm_ChooseCourse : Form
    {
        public frm_ChooseCourse()
        {
            InitializeComponent();
        }

        private void FillToDgvCourse(Course course)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                check.Value = true;
                row.Cells.Add(check);

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
                cell6.Value = course.Department?.Name;
                row.Cells.Add(cell6);

                row.Tag = course;

                Invoke(new MethodInvoker(delegate ()
                {
                    dgvCourse.Rows.Add(row);
                }));
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void LoadCourseByDepartment()
        {
            try
            {
                dgvCourse.Rows.Clear();
                Department department = DepartmentController.Instance().GetDepartmentByName(currentInstructor.Department.Name);
                List<Course> courses = CourseController.Instance().GetCourseByDepartment(department);
                courses.ForEach(FillToDgvCourse);
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void LoadCourseOfInstructor()
        {
            try
            {
                dgvCourse.Rows.Clear();
                List<Course> courses = CourseController.Instance().GetCoursesByInstructor(currentInstructor);
                courses.ForEach(FillToDgvCourse);
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<Course> courses = new List<Course>();
                dgvCourse.EndEdit();
                foreach (DataGridViewRow row in dgvCourse.Rows)
                {
                    if ((bool)row.Cells[0].Value)
                    {
                        Course course = row.Tag as Course;
                        courses.Add(course);
                    }
                }

                int updateResult = InstructorController.Instance().UpdateCourse(currentInstructor, courses);
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
                    MessageBox.Show("Cập nhật lớp giảng dạy thành công.", "Thông báo");
                    this.Close();
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void frm_ChooseCourse_Load(object sender, EventArgs e)
        {
            LoadCourseOfInstructor();
        }

        private void select_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvCourse.SelectedRows)
                {
                    row.Cells[0].Value = true;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void unselect_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvCourse.SelectedRows)
                {
                    row.Cells[0].Value = false;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvCourse.Rows)
                {
                    row.Cells[0].Value = true;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void unselectAll_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvCourse.Rows)
                {
                    row.Cells[0].Value = false;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void getAllCourse_Click(object sender, EventArgs e)
        {
            LoadCourseByDepartment();
        }
    }
}
