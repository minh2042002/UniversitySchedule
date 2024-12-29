using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySchedule.Controllers;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;
using UniversitySchedule.View.ManageAccount;

namespace UniversitySchedule.View.ManageDepartment
{
    public partial class uc_ManageDepartment_Action : UserControl
    {
        public uc_ManageDepartment_Action()
        {
            InitializeComponent();
            LoadFeatureButtonByRole();
        }

        private uc_ManageCourse uc_ManageCourse;
        private uc_ManageInstructor uc_ManageInstructor;

        private void LoadFeatureButtonByRole()
        {
            try
            {
                if (UserLogin.User.Role == Role.Admin)
                {
                    pnBackButtonAddDepartment.Visible = true;
                    pnBottomAddDepartment.Visible = true;

                    pnBackButtonAddCourse.Visible = true;
                    pnBottomAddCourse.Visible = true;

                    pnBackButtonManageCourse.Visible = true;
                    pnBottomManageCourse.Visible = true;

                    pnBackButtonManageInstructor.Visible = true;

                    pnBackButtonAddRoom.Visible = true;
                    pnBottomAddRoom.Visible = true;
                }
                else if (UserLogin.User.Role == Role.Head)
                {
                    pnBackButtonAddDepartment.Visible = false;
                    pnBottomAddDepartment.Visible = false;

                    pnBackButtonAddCourse.Visible = true;
                    pnBottomAddCourse.Visible = true;

                    pnBackButtonManageCourse.Visible = true;
                    pnBottomManageCourse.Visible = true;

                    pnBackButtonManageInstructor.Visible = true;

                    pnBackButtonAddRoom.Visible = false;
                    pnBottomAddRoom.Visible = false;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void FillUserControlToPanel(string userControl)
        {
            try
            {
                this.pnMain.Controls.Clear();
                switch (userControl)
                {
                    case "manage_course":
                        if (this.uc_ManageCourse == null)
                        {
                            this.uc_ManageCourse = new uc_ManageCourse();
                            this.pnMain.Controls.Add(uc_ManageCourse);
                            this.uc_ManageCourse.Dock = DockStyle.Fill;
                            this.uc_ManageCourse.Location = new Point(0, 0);
                            this.uc_ManageCourse.Size = new Size(pnMain.Width, pnMain.Height);
                            this.uc_ManageCourse.TabIndex = 0;
                        }
                        else
                        {
                            this.pnMain.Controls.Add(uc_ManageCourse);
                        }
                        break;
                    case "manage_instructor":
                        if (this.uc_ManageInstructor == null)
                        {
                            this.uc_ManageInstructor = new uc_ManageInstructor();
                            this.pnMain.Controls.Add(uc_ManageInstructor);
                            this.uc_ManageInstructor.Dock = DockStyle.Fill;
                            this.uc_ManageInstructor.Location = new Point(0, 0);
                            this.uc_ManageInstructor.Size = new Size(pnMain.Width, pnMain.Height);
                            this.uc_ManageInstructor.TabIndex = 0;
                        }
                        else
                        {
                            this.pnMain.Controls.Add(uc_ManageInstructor);
                        }
                        break;
                    case "room":

                        break;
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
                    case "add_department":
                        pnAddDepartment.BackColor = Color.FromArgb(250, 82, 82);
                        btnAddDepartment.BackColor = Color.FromArgb(250, 232, 234);
                        btnAddDepartment.ForeColor = Color.FromArgb(250, 82, 82);
                        btnAddDepartment.Font = new Font(btnAddDepartment.Font, FontStyle.Bold);
                        btnAddDepartment.Image = Properties.Resources.department_24_red;
                        break;
                    case "add_course":
                        pnAddCourse.BackColor = Color.FromArgb(250, 82, 82);
                        btnAddCourse.BackColor = Color.FromArgb(250, 232, 234);
                        btnAddCourse.ForeColor = Color.FromArgb(250, 82, 82);
                        btnAddCourse.Font = new Font(btnAddCourse.Font, FontStyle.Bold);
                        btnAddCourse.Image = Properties.Resources.book_24_red;
                        break;
                    case "add_room":
                        pnAddRoom.BackColor = Color.FromArgb(250, 82, 82);
                        btnAddRoom.BackColor = Color.FromArgb(250, 232, 234);
                        btnAddRoom.ForeColor = Color.FromArgb(250, 82, 82);
                        btnAddRoom.Font = new Font(btnAddRoom.Font, FontStyle.Bold);
                        btnAddRoom.Image = Properties.Resources.lecture_hall_24_red;
                        break;

                    case "manage_course":
                        pnManageCourse.BackColor = Color.FromArgb(250, 82, 82);
                        btnManageCourse.BackColor = Color.FromArgb(250, 232, 234);
                        btnManageCourse.ForeColor = Color.FromArgb(250, 82, 82);
                        btnManageCourse.Font = new Font(btnManageCourse.Font, FontStyle.Bold);
                        btnManageCourse.Image = Properties.Resources.note_24_red;
                        break;

                    case "manage_instructor":
                        pnManageInstructor.BackColor = Color.FromArgb(250, 82, 82);
                        btnManageInstructor.BackColor = Color.FromArgb(250, 232, 234);
                        btnManageInstructor.ForeColor = Color.FromArgb(250, 82, 82);
                        btnManageInstructor.Font = new Font(btnManageInstructor.Font, FontStyle.Bold);
                        btnManageInstructor.Image = Properties.Resources.teacher_24_red;
                        break;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void InitIconButton()
        {
            try
            {
                pnAddDepartment.BackColor = Color.White;
                btnAddDepartment.BackColor = Color.White;
                btnAddDepartment.ForeColor = Color.Black;
                btnAddDepartment.Font = new Font(btnAddDepartment.Font, FontStyle.Regular);
                btnAddDepartment.Image = Properties.Resources.department_24_black;

                pnAddCourse.BackColor = Color.White;
                btnAddCourse.BackColor = Color.White;
                btnAddCourse.ForeColor = Color.Black;
                btnAddCourse.Font = new Font(btnAddCourse.Font, FontStyle.Regular);
                btnAddCourse.Image = Properties.Resources.book_24_black;

                pnAddRoom.BackColor = Color.White;
                btnAddRoom.BackColor = Color.White;
                btnAddRoom.ForeColor = Color.Black;
                btnAddRoom.Font = new Font(btnAddRoom.Font, FontStyle.Regular);
                btnAddRoom.Image = Properties.Resources.lecture_hall_24_black;

                pnManageCourse.BackColor = Color.White;
                btnManageCourse.BackColor = Color.White;
                btnManageCourse.ForeColor = Color.Black;
                btnManageCourse.Font = new Font(btnManageCourse.Font, FontStyle.Regular);
                btnManageCourse.Image = Properties.Resources.note_24_black;

                pnManageInstructor.BackColor = Color.White;
                btnManageInstructor.BackColor = Color.White;
                btnManageInstructor.ForeColor = Color.Black;
                btnManageInstructor.Font = new Font(btnManageInstructor.Font, FontStyle.Regular);
                btnManageInstructor.Image = Properties.Resources.teacher_24_black;
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void uc_ManageDepartment_Action_Load(object sender, EventArgs e)
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
                InitIconButton();
                HighlightButtonClicked("manage_instructor");
                FillUserControlToPanel("manage_instructor");
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                HighlightButtonClicked("add_department");
                frm_AddDepartment frm_AddDepartment = new frm_AddDepartment();
                frm_AddDepartment.ShowDialog();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                HighlightButtonClicked("add_course");
                frm_AddCourse frm_AddCourse = new frm_AddCourse();
                frm_AddCourse.ShowDialog();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            try
            {
                HighlightButtonClicked("add_room");
                frm_AddRoom frm_AddRoom = new frm_AddRoom();
                frm_AddRoom.ShowDialog();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnManageCourse_Click(object sender, EventArgs e)
        {
            HighlightButtonClicked("manage_course");
            FillUserControlToPanel("manage_course");
        }

        private void btnManageInstructor_Click(object sender, EventArgs e)
        {
            HighlightButtonClicked("manage_instructor");
            FillUserControlToPanel("manage_instructor");
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
    }
}
