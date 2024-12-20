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

namespace UniversitySchedule.View.ManageSchedule
{
    public partial class uc_ManageSchedule_Action : UserControl
    {
        public uc_ManageSchedule_Action()
        {
            InitializeComponent();
        }

        private void uc_ManageSchedule_Action_Load(object sender, EventArgs e)
        {
            InitDgvCalendar();
            HighlightButtonClicked("schedule");
            LoadScheduleFromDatabase();
        }

        private Button currentButton;
        private List<Class> classes = new List<Class>();
        private List<(DataGridViewCell StartCell, DataGridViewCell EndCell)> eventRanges = new List<(DataGridViewCell, DataGridViewCell)>();
        List<string> timeSlots = new List<string>
        {
            "6:45", "8:15", "8:25", "9:10", "9:20", "10:05", "10:15", "11:45", "12:30", "14:00", "14:10", "14:55", "15:05", "15:50", "16:00", "17:30"
        };

        private void InitDgvCalendar()
        {
            if ((int)UserLogin.Role == 1)
            {
                dgvCalendar.ContextMenuStrip = cmsCalendar;
            }
            else
            {
                dgvCalendar.ContextMenuStrip = null;
            }
            dgvCalendar.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dgvCalendar.DefaultCellStyle.SelectionForeColor = Color.Transparent;
            dgvCalendar.CellClick += dgvCalendar_CellClick;

            int columnWidth = (pnCalendar.Width - 10 - 50) / 7;
            for (int i = 1; i < dgvCalendar.Columns.Count; i++)
            {
                dgvCalendar.Columns[i].Width = columnWidth;  // Cập nhật độ rộng cột
            }

            foreach (string time in timeSlots)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                cell.Value = time;
                dataGridViewRow.Cells.Add(cell);
                dataGridViewRow.Height = 45;
                Invoke(new MethodInvoker(delegate ()
                {
                    dgvCalendar.Rows.Add(dataGridViewRow);
                }));
            }

            dgvCalendar.AllowUserToAddRows = false; // Tắt tính năng thêm hàng mới
            dgvCalendar.CellBorderStyle = DataGridViewCellBorderStyle.None;
            // Tô màu sự kiện
            HighlightEvents(dgvCalendar, timeSlots);
        }

        private void HighlightEvents(DataGridView dgvCalendar, List<string> timeSlots)
        {
            foreach (Class ev in classes)
            {
                // Xác định cột (ngày) dựa trên sự kiện
                int columnIndex = dgvCalendar.Columns.Cast<DataGridViewColumn>()
                                      .FirstOrDefault(c => c.HeaderText == ev.MeetingTime.Day.ToString())?.Index ?? -1;
                if (columnIndex == -1) continue; // Nếu ngày không tồn tại, bỏ qua sự kiện này

                // Xác định hàng bắt đầu và kết thúc dựa trên mốc thời gian
                int startRowIndex = timeSlots.IndexOf(ev.MeetingTime.StartTime.ToString());
                int endRowIndex = timeSlots.IndexOf(ev.MeetingTime.EndTime.ToString());
                if (startRowIndex == -1 || endRowIndex == -1) continue; // Nếu không tìm thấy thời gian, bỏ qua sự kiện

                // Tô màu các ô từ startRowIndex đến endRowIndex
                for (int i = startRowIndex; i <= endRowIndex; i++)
                {
                    dgvCalendar[columnIndex, i].Style.BackColor = GetRandomColor(); // Tô màu nền
                    if (i == startRowIndex)
                    {
                        // Ghi nội dung sự kiện ở ô đầu tiên
                        dgvCalendar[columnIndex, i].Value = ev.Course.Name;
                    }
                }
            }
        }

        private Color GetRandomColor()
        {
            Random rand = new Random();
            return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void LoadScheduleFromDatabase()
        {
            try
            {
                Schedule schedule = ScheduleController.Instance().GetScheduleActiveDetail();
                // Thêm sự kiện mẫu (Thứ 2, 6:45 -> 8:15)

                if (schedule != null && schedule.Classes.Count() > 0)
                {
                    foreach (Class cl in schedule.Classes)
                    {
                        int day = ((int)cl.MeetingTime.Day);
                        int indexStartTime = timeSlots.IndexOf(cl.MeetingTime.StartTime.ToString());
                        int indexEndTime = timeSlots.IndexOf(cl.MeetingTime.EndTime.ToString());

                        AddEventRange(dgvCalendar.Rows[indexStartTime].Cells[day], dgvCalendar.Rows[indexEndTime].Cells[day], Color.FromArgb(250, 82, 82));
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void AddEventRange(DataGridViewCell startCell, DataGridViewCell endCell, Color color)
        {
            eventRanges.Add((startCell, endCell));
            HighlightRange(startCell, endCell, color);
        }

        private void HighlightRange(DataGridViewCell startCell, DataGridViewCell endCell, Color color)
        {
            for (int row = startCell.RowIndex; row <= endCell.RowIndex; row++)
            {
                dgvCalendar.Rows[row].Cells[startCell.ColumnIndex].Style.BackColor = color;
            }
        }

        private bool IsCellInRange(DataGridViewCell cell, DataGridViewCell startCell, DataGridViewCell endCell)
        {
            return cell.RowIndex >= startCell.RowIndex && cell.RowIndex <= endCell.RowIndex &&
                   cell.ColumnIndex == startCell.ColumnIndex; // Phạm vi cùng cột
        }

        private void dgvCalendar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var clickedCell = dgvCalendar.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // Tìm sự kiện chứa ô được click
            foreach (var (startCell, endCell) in eventRanges)
            {
                if (IsCellInRange(clickedCell, startCell, endCell))
                {
                    //ClearHighlight();
                    //HighlightRange(startCell, endCell, Color.Yellow); // Làm nổi bật phạm vi sự kiện
                    return;
                }
            }

            // Nếu không thuộc sự kiện nào, bỏ màu nổi bật
            //ClearHighlight();
        }

        private void pnCalendar_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                int columnWidth = (pnCalendar.Width - 10 - 50) / 7;
                for (int i = 1; i < dgvCalendar.Columns.Count; i++)
                {
                    dgvCalendar.Columns[i].Width = columnWidth;  // Cập nhật độ rộng cột
                }
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
                        btnSchedule.Image = Properties.Resources.calendar_24_red;
                        break;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void InitIconButton()
        {
            try
            {
                pnSchedule.BackColor = Color.White;
                btnSchedule.BackColor = Color.White;
                btnSchedule.ForeColor = Color.Black;
                btnSchedule.Font = new Font(btnSchedule.Font, FontStyle.Regular);
                btnSchedule.Image = Properties.Resources.calendar_24_black;
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }
    }
}
