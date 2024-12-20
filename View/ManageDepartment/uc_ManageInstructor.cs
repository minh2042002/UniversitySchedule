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

        public static Instructor currentInstructor;

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
                cell6.Value = instructor.Department.Name;
                row.Cells.Add(cell6);

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
            LoadDepartmentFromDatabase();
        }

        private void moveDepartment_Click(object sender, EventArgs e)
        {
            currentInstructor = dgvInstructor.CurrentRow.Tag as Instructor;
            frm_MoveDepartment frm_MoveDepartment = new frm_MoveDepartment();
            frm_MoveDepartment.ShowDialog();
            LoadInstructorByDepartmentSelected();
        }
    }
}
