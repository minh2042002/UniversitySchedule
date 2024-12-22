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
using UniversitySchedule.Algorithm;
using UniversitySchedule.Controllers;
using UniversitySchedule.Dto;
using UniversitySchedule.Utils;

namespace UniversitySchedule.View.CreateSchedule
{
    public partial class uc_CreateSchedule_Action : UserControl
    {
        public uc_CreateSchedule_Action()
        {
            InitializeComponent();
        }

        private ScheduleDto ScheduleDto { get; set; }

        private void FillToDgvSchedule(ClassDto classdto)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                cell1.Value = (dgvSchedule.Rows.Count + 1).ToString();
                row.Cells.Add(cell1);

                DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                cell2.Value = classdto.Department.Name;
                row.Cells.Add(cell2);

                DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
                cell3.Value = $"{classdto.Course.Name} ({classdto.Course.Credit})";
                row.Cells.Add(cell3);

                DataGridViewTextBoxCell cell4 = new DataGridViewTextBoxCell();
                cell4.Value = (int)classdto.MeetingTime.Day + 1;
                row.Cells.Add(cell4);

                DataGridViewTextBoxCell cell5 = new DataGridViewTextBoxCell();
                cell5.Value = classdto.MeetingTime.ToString();
                row.Cells.Add(cell5);

                DataGridViewTextBoxCell cell6 = new DataGridViewTextBoxCell();
                cell6.Value = classdto.Room.ToString();
                row.Cells.Add(cell6);

                DataGridViewTextBoxCell cell7 = new DataGridViewTextBoxCell();
                cell7.Value = classdto.Instructor.Name;
                row.Cells.Add(cell7);

                DataGridViewTextBoxCell cell8 = new DataGridViewTextBoxCell();
                cell8.Value = classdto.Course.MaxStudent;
                row.Cells.Add(cell8);

                row.Tag = classdto;

                Invoke(new MethodInvoker(delegate ()
                {
                    dgvSchedule.Rows.Add(row);
                }));
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void HighlightButtonClicked(string button)
        {
            try
            {
                InitIconButton();
                switch (button)
                {
                    case "schedule":
                        pnSchedule.BackColor = Color.FromArgb(250, 82, 82);
                        btnSchedule.BackColor = Color.FromArgb(250, 232, 234);
                        btnSchedule.ForeColor = Color.FromArgb(250, 82, 82);
                        btnSchedule.Font = new Font(btnSchedule.Font, FontStyle.Bold);
                        btnSchedule.Image = Properties.Resources.schedule_24_red;
                        break;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void InitIconButton()
        {
            try
            {
                pnBackButtonSchedule.BackColor = Color.White;
                btnSchedule.BackColor = Color.White;
                btnSchedule.ForeColor = Color.Black;
                btnSchedule.Font = new Font(btnSchedule.Font, FontStyle.Regular);
                btnSchedule.Image = Properties.Resources.schedule_24_black;
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void uc_CreateSchedule_Action_Load(object sender, EventArgs e)
        {
            try
            {
                HighlightButtonClicked("schedule");
                btnSave.Enabled = false;
                btnExportExcel.Enabled = false;
                dgvSchedule.Columns["meeting_time"].DefaultCellStyle.Format = "HH:mm";
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private async void btnCreateSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSchedule.Rows.Clear();
                btnCreateSchedule.Enabled = false;
                await Task.Run(() =>
                {
                    ScheduleDto = Driver.CreateSchedule();
                });
                btnCreateSchedule.Enabled = true;

                if (ScheduleDto.Classes.Count > 0)
                {
                    btnSave.Enabled = true;
                    btnExportExcel.Enabled = true;
                    ScheduleDto.Classes
                                    .OrderBy(x => x.MeetingTime.Day)   // Sắp xếp theo DayOfWeek
                                    .ThenBy(x => x.MeetingTime.StartTime)    // Sắp xếp theo thời gian bắt đầu
                                    .ThenBy(x => x.MeetingTime.EndTime)      // Sắp xếp theo thời gian kết thúc
                                    .ToList()
                                    .ForEach(FillToDgvSchedule);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool addResult = ScheduleController.Instance().InsertSchedule(ScheduleDto, true);
                if (addResult)
                {
                    MessageBox.Show("Lưu thời khóa biểu thành công.");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại!");
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (ScheduleDto != null && ScheduleDto.Classes.Count > 0)
                {
                    List<ClassDto> classes = ScheduleDto.Classes
                                                        .OrderBy(x => x.MeetingTime.Day)   // Sắp xếp theo DayOfWeek
                                                        .ThenBy(x => x.MeetingTime.StartTime)    // Sắp xếp theo thời gian bắt đầu
                                                        .ThenBy(x => x.MeetingTime.EndTime).ToList();
                    Excel.ExportCoursesToExcelWithDialog(classes);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void showConsole_Click(object sender, EventArgs e)
        {

        }
    }
}
