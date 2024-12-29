using Sunny.UI;
using System.Data;
using UniversitySchedule.Controllers;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;
using UniversitySchedule.View.ManageAccount;
using UniversitySchedule.View.ManageDepartment;

namespace UniversitySchedule.View.ManageSchedule
{
    public partial class uc_ManageSchedule_Action : UserControl
    {
        public uc_ManageSchedule_Action()
        {
            InitializeComponent();
        }

        private Schedule? currentSchedule = null;
        private Button currentButton;
        private List<Class> classes = new List<Class>();

        private void uc_ManageSchedule_Action_Load(object sender, EventArgs e)
        {
            try
            {
                if (UserLogin.User.Role == Role.Admin)
                {
                    btnAccountInformation.Enabled = false;
                    btnAccountInformation.Visible = false;
                }
                else
                {
                    btnAccountInformation.Enabled = true;
                    btnAccountInformation.Visible = true;
                }

                HighlightButtonClicked("schedule");
                LoadScheduleFromDatabase();
                if (UserLogin.User.Role == Role.Admin)
                {
                    showAllCalendar.Visible = false;
                    showTeach.Visible = false;
                    manageCourse.Visible = false;
                }
                else
                {
                    showAllCalendar.Visible = true;
                    showTeach.Visible = true;
                    manageCourse.Visible = true;
                }
            }
            catch (Exception ex)
            {
            }
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


        private void LoadScheduleFromDatabase()
        {
            try
            {
                currentSchedule = ScheduleController.Instance().GetScheduleActiveDetail();
                if (currentSchedule != null)
                {
                    currentSchedule.Classes
                                    .OrderBy(x => x.MeetingTime.Day)   // Sắp xếp theo DayOfWeek
                                    .ThenBy(x => x.MeetingTime.StartTime)    // Sắp xếp theo thời gian bắt đầu
                                    .ThenBy(x => x.MeetingTime.EndTime)      // Sắp xếp theo thời gian kết thúc
                                    .ToList()
                                    .ForEach(FillToDgvSchedule);
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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSchedule.Rows.Clear();
                LoadScheduleFromDatabase();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void showAllCalendar_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSchedule != null && currentSchedule.Classes.Count > 0)
                {
                    dgvSchedule.Rows.Clear();
                    currentSchedule.Classes
                                   .OrderBy(x => x.MeetingTime.Day)   // Sắp xếp theo DayOfWeek
                                   .ThenBy(x => x.MeetingTime.StartTime)    // Sắp xếp theo thời gian bắt đầu
                                   .ThenBy(x => x.MeetingTime.EndTime)      // Sắp xếp theo thời gian kết thúc
                                   .ToList()
                                   .ForEach(FillToDgvSchedule);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void showTeach_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSchedule != null && currentSchedule.Classes.Count > 0)
                {
                    dgvSchedule.Rows.Clear();
                    currentSchedule.Classes
                                   .Where(c => c.Instructor.UserId == UserLogin.User.Id)
                                   .OrderBy(x => x.MeetingTime.Day)   // Sắp xếp theo DayOfWeek
                                   .ThenBy(x => x.MeetingTime.StartTime)    // Sắp xếp theo thời gian bắt đầu
                                   .ThenBy(x => x.MeetingTime.EndTime)      // Sắp xếp theo thời gian kết thúc
                                   .ToList()
                                   .ForEach(FillToDgvSchedule);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnAccountInformation_Click(object sender, EventArgs e)
        {
            try
            {
                frm_UserInformation frm_UserInformation = new frm_UserInformation(UserLogin.User);
                frm_UserInformation.ShowDialog();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                UserLogin.User = null;
                Thread thread = new Thread(new ThreadStart(() =>
                {
                    try
                    {
                        frm_Login frm_Login = new frm_Login(isLogout: true);
                        frm_Login.ShowDialog();
                    }
                    catch (Exception ex) { Log4Net.LogException(ex, ""); }
                }));
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                Application.Exit();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void manageCourse_Click(object sender, EventArgs e)
        {
            try
            {
                Instructor currentInstructor = UserLogin.User.Instructor;
                frm_ChooseCourse frm_ChooseCourse = new frm_ChooseCourse(currentInstructor);
                frm_ChooseCourse.ShowDialog();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }
    }
}
