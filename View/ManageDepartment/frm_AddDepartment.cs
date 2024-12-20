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
    public partial class frm_AddDepartment : Form
    {
        public frm_AddDepartment()
        {
            InitializeComponent();
        }

        private Department currentDepartment;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Department department = new Department();
                if (!txtNameDepartment.Text.Trim().IsNullOrEmpty())
                {
                    department.Name = txtNameDepartment.Text.Trim();
                    txtNameDepartment.Clear();
                    int addResult = DepartmentController.Instance().InsertDepartment(department);
                    if (addResult == 0)
                    {
                        MessageBox.Show("Đã tồn tại bộ môn này!", "Thông Báo");
                    }
                    else if (addResult == -1)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại!", "Thông Báo");
                    }
                    else if (addResult == 1)
                    {
                        MessageBox.Show("Thêm bộ môn thành công.", "Thông báo");
                        LoadDepartmentFromDatabase();
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNameDepartment.Text.Trim().IsNullOrEmpty())
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn cập nhật tên bộ môn này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        currentDepartment.Name = txtNameDepartment.Text.Trim();
                        int updateResult = DepartmentController.Instance().UpdateDepartment(currentDepartment);
                        if (updateResult == 0)
                        {
                            MessageBox.Show("Không tồn tại bộ môn này!", "Thông Báo");
                        }
                        else if (updateResult == -1)
                        {
                            MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại!", "Thông Báo");
                        }
                        else if (updateResult == 1)
                        {
                            MessageBox.Show("Cập nhật bộ môn thành công.", "Thông báo");
                            LoadDepartmentFromDatabase();
                        }
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa bộ môn này không ?\n Việc xóa bộ môn sẽ xóa tất cả dữ liệu thuộc bộ môn!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Department department = (Department)dgvDepartment.CurrentRow.Tag;
                    int deleteResult = DepartmentController.Instance().DeleteDepartment(currentDepartment);
                    if (deleteResult == 0)
                    {
                        MessageBox.Show("Không tồn tại bộ môn này!", "Thông Báo");
                    }
                    else if (deleteResult == -1)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại!", "Thông Báo");
                    }
                    else if (deleteResult == 1)
                    {
                        MessageBox.Show("Xóa bộ môn thành công.", "Thông báo");
                        LoadDepartmentFromDatabase();
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void FillToDgvDepartment(Department department)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                cell1.Value = (dgvDepartment.Rows.Count + 1).ToString();
                row.Cells.Add(cell1);

                DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                cell2.Value = department.Id;
                row.Cells.Add(cell2);

                DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
                cell3.Value = department.Name;
                row.Cells.Add(cell3);

                row.Tag = department;

                Invoke(new MethodInvoker(delegate ()
                {
                    dgvDepartment.Rows.Add(row);
                }));
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void LoadDepartmentFromDatabase()
        {
            try
            {
                dgvDepartment.Rows.Clear();
                List<Department> departments = DepartmentController.Instance().GetAllDepartment();
                foreach (Department department in departments)
                {
                    FillToDgvDepartment(department);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void frm_AddDepartment_Load(object sender, EventArgs e)
        {
            LoadDepartmentFromDatabase();
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                currentDepartment = (Department)dgvDepartment.CurrentRow.Tag;
                txtNameDepartment.Text = currentDepartment.Name;
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }
    }
}
