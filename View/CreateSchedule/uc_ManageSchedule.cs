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
using UniversitySchedule.Dto;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;

namespace UniversitySchedule.View.CreateSchedule
{
    public partial class uc_ManageSchedule : UserControl
    {
        public uc_ManageSchedule()
        {
            InitializeComponent();
        }

        private Schedule? currentSchedule = null;
        private List<Schedule> schedules;

        private void LoadScheduleListFromDatabase()
        {
            try
            {
                schedules = ScheduleController.Instance().GetAllSchedule();
                cmbSchedule.Items.Clear();
                if (schedules.Count > 0)
                {
                    schedules.ForEach(s => cmbSchedule.Items.Add(s.Name));
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void LoadScheduleBySelected()
        {
            try
            {
                dgvSchedule.Rows.Clear();
                if (schedules.Count > 0)
                {
                    currentSchedule = schedules.FirstOrDefault(s => s.Name == cmbSchedule.SelectedItem.ToString());
                    if (currentSchedule != null)
                    {
                        currentSchedule.Classes
                                       .OrderBy(x => x.MeetingTime.Day)   // Sắp xếp theo DayOfWeek
                                       .ThenBy(x => x.MeetingTime.StartTime)    // Sắp xếp theo thời gian bắt đầu
                                       .ThenBy(x => x.MeetingTime.EndTime)
                                       .ToList()
                                       .ForEach(FillToDgvSchedule);
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void FillToDgvSchedule(Class classDetail)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                cell1.Value = (dgvSchedule.Rows.Count + 1).ToString();
                row.Cells.Add(cell1);

                DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                cell2.Value = classDetail.Department.Name;
                row.Cells.Add(cell2);

                DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
                cell3.Value = $"{classDetail.Course.Name} ({classDetail.Course.Credit})";
                row.Cells.Add(cell3);

                DataGridViewTextBoxCell cell4 = new DataGridViewTextBoxCell();
                cell4.Value = (int)classDetail.MeetingTime.Day + 1;
                row.Cells.Add(cell4);

                DataGridViewTextBoxCell cell5 = new DataGridViewTextBoxCell();
                cell5.Value = classDetail.MeetingTime.ToString();
                row.Cells.Add(cell5);

                DataGridViewTextBoxCell cell6 = new DataGridViewTextBoxCell();
                cell6.Value = classDetail.Room.ToString();
                row.Cells.Add(cell6);

                DataGridViewTextBoxCell cell7 = new DataGridViewTextBoxCell();
                cell7.Value = classDetail.Instructor.User.Information.Name;
                row.Cells.Add(cell7);

                DataGridViewTextBoxCell cell8 = new DataGridViewTextBoxCell();
                cell8.Value = classDetail.Course.MaxStudent;
                row.Cells.Add(cell8);

                row.Tag = classDetail;

                Invoke(new MethodInvoker(delegate ()
                {
                    dgvSchedule.Rows.Add(row);
                }));
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void uc_ManageSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                LoadScheduleListFromDatabase();
                dgvSchedule.Columns["meeting_time"].DefaultCellStyle.Format = "HH:mm";
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSchedule != null && currentSchedule.Classes.Count > 0)
                {
                    List<Class> classes = currentSchedule.Classes
                                                        .OrderBy(x => x.MeetingTime.Day)   // Sắp xếp theo DayOfWeek
                                                        .ThenBy(x => x.MeetingTime.StartTime)    // Sắp xếp theo thời gian bắt đầu
                                                        .ThenBy(x => x.MeetingTime.EndTime).ToList();
                    Excel.ExportCoursesToExcelWithDialog(classes);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadScheduleListFromDatabase();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadScheduleBySelected();
        }

        private void setActive_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSchedule != null)
                {
                    int updateResult = ScheduleController.Instance().SetActive(currentSchedule);
                    if (updateResult == 0)
                    {
                        MessageBox.Show("Không tồn tại thời khóa biểu này!", "Thông Báo");
                    }
                    else if (updateResult == -1)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại!", "Thông Báo");
                    }
                    else if (updateResult == 1)
                    {
                        MessageBox.Show("Đặt làm thời khóa biểu chính thức thành công.", "Thông báo");
                    }

                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }
    }
}
