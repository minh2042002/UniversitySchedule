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
    public partial class frm_MoveDepartment : Form
    {
        public frm_MoveDepartment()
        {
            InitializeComponent();
        }

        private List<Department> departments;

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
                    cmbDepartment.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            try
            {
                Department department = DepartmentController.Instance().GetDepartmentByName(cmbDepartment.SelectedItem.ToString());

                int updateResult = InstructorController.Instance().UpdateDepartment(currentInstructor, department);
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
                    MessageBox.Show("Chuyển bộ môn thành công.", "Thông báo");
                    this.Close();
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void frm_MoveDepartment_Load(object sender, EventArgs e)
        {
            LoadDepartmentFromDatabase();
        }
    }
}
