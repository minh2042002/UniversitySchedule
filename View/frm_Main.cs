using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;
using UniversitySchedule.View.CreateSchedule;
using UniversitySchedule.View.ManageAccount;
using UniversitySchedule.View.ManageDepartment;
using UniversitySchedule.View.ManageSchedule;

namespace UniversitySchedule.View
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
            LoadUserControlAction();
            LoadFeatureButtonByRole();
        }

        private uc_ManageSchedule_Action uc_ManageSchedule_Action;
        private uc_ManageDepartment_Action uc_ManageDepartment_Action;
        private uc_ManageAccount_Action uc_ManageAccount_Action;
        private uc_CreateSchedule_Action uc_CreateSchedule_Action;

        private void LoadFeatureButtonByRole()
        {
            try
            {
                if (UserLogin.User.Role == Role.Admin)
                {
                    btnManageDepartment.Enabled = true;
                    btnManageDepartment.Visible = true;

                    btnManageAccount.Enabled = true;
                    btnManageAccount.Visible = true;

                    btnCreateSchedule.Enabled = true;
                    btnCreateSchedule.Visible = true;
                }
                else if (UserLogin.User.Role == Role.Head)
                {
                    btnManageDepartment.Enabled = true;
                    btnManageDepartment.Visible = true;

                    btnManageAccount.Enabled = false;
                    btnManageAccount.Visible = false;

                    btnCreateSchedule.Enabled = false;
                    btnCreateSchedule.Visible = false;
                }
                else if (UserLogin.User.Role == Role.Instructor)
                {
                    btnManageDepartment.Enabled = false;
                    btnManageDepartment.Visible = false;

                    btnManageAccount.Enabled = false;
                    btnManageAccount.Visible = false;

                    btnCreateSchedule.Enabled = false;
                    btnCreateSchedule.Visible = false;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void LoadUserControlAction()
        {
            try
            {
                if (uc_ManageSchedule_Action == null)
                {
                    uc_ManageSchedule_Action = new uc_ManageSchedule_Action();
                    uc_ManageSchedule_Action.Dock = DockStyle.Fill;
                    uc_ManageSchedule_Action.Location = new Point(0, 0);
                    uc_ManageSchedule_Action.Size = new Size(pnMain.Width, pnMain.Height);
                    uc_ManageSchedule_Action.TabIndex = 0;
                }

                if (uc_ManageDepartment_Action == null && (int)UserLogin.User.Role == 0)
                {
                    uc_ManageDepartment_Action = new uc_ManageDepartment_Action();
                    uc_ManageDepartment_Action.Dock = DockStyle.Fill;
                    uc_ManageDepartment_Action.Location = new Point(0, 0);
                    uc_ManageDepartment_Action.Size = new Size(pnMain.Width, pnMain.Height);
                    uc_ManageDepartment_Action.TabIndex = 0;
                }

                if (uc_ManageAccount_Action == null && (int)UserLogin.User.Role == 0)
                {
                    uc_ManageAccount_Action = new uc_ManageAccount_Action();
                    uc_ManageAccount_Action.Dock = DockStyle.Fill;
                    uc_ManageAccount_Action.Location = new Point(0, 0);
                    uc_ManageAccount_Action.Size = new Size(pnMain.Width, pnMain.Height);
                    uc_ManageAccount_Action.TabIndex = 0;
                }

                if (uc_CreateSchedule_Action == null && (int)UserLogin.User.Role == 0)
                {
                    uc_CreateSchedule_Action = new uc_CreateSchedule_Action();
                    uc_CreateSchedule_Action.Dock = DockStyle.Fill;
                    uc_CreateSchedule_Action.Location = new Point(0, 0);
                    uc_CreateSchedule_Action.Size = new Size(pnMain.Width, pnMain.Height);
                    uc_CreateSchedule_Action.TabIndex = 0;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void HighlightButtonClicked(string panel)
        {
            try
            {
                InitIconButton();
                switch (panel)
                {
                    case "manage_schedule":
                        btnManageSchedule.BackColor = Color.White;
                        btnManageSchedule.ForeColor = Color.FromArgb(250, 82, 82);
                        btnManageSchedule.Image = Properties.Resources.calendar_24_red;
                        btnManageSchedule.FlatAppearance.BorderColor = Color.FromArgb(250, 82, 82);
                        btnManageSchedule.FlatAppearance.BorderSize = 2;
                        break;
                    case "manage_department":
                        btnManageDepartment.BackColor = Color.White;
                        btnManageDepartment.ForeColor = Color.FromArgb(250, 82, 82);
                        btnManageDepartment.Image = Properties.Resources.unit_24_red;
                        btnManageDepartment.FlatAppearance.BorderColor = Color.FromArgb(250, 82, 82);
                        btnManageDepartment.FlatAppearance.BorderSize = 2;
                        break;
                    case "manage_account":
                        btnManageAccount.BackColor = Color.White;
                        btnManageAccount.ForeColor = Color.FromArgb(250, 82, 82);
                        btnManageAccount.Image = Properties.Resources.user_24_red;
                        btnManageAccount.FlatAppearance.BorderColor = Color.FromArgb(250, 82, 82);
                        btnManageAccount.FlatAppearance.BorderSize = 2;
                        break;
                    case "create_schedule":
                        btnCreateSchedule.BackColor = Color.White;
                        btnCreateSchedule.ForeColor = Color.FromArgb(250, 82, 82);
                        btnCreateSchedule.Image = Properties.Resources.schedule_24_red;
                        btnCreateSchedule.FlatAppearance.BorderColor = Color.FromArgb(250, 82, 82);
                        btnCreateSchedule.FlatAppearance.BorderSize = 2;
                        break;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void InitIconButton()
        {
            try
            {
                btnManageSchedule.Image = Properties.Resources.calendar_24_black;
                btnManageSchedule.BackColor = Color.FromArgb(233, 235, 238);
                btnManageSchedule.FlatAppearance.BorderColor = Color.FromArgb(233, 235, 238);
                btnManageSchedule.FlatAppearance.BorderSize = 1;
                btnManageSchedule.ForeColor = Color.FromArgb(28, 28, 28);
                btnManageSchedule.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

                btnManageDepartment.Image = Properties.Resources.unit_24_black;
                btnManageDepartment.BackColor = Color.FromArgb(233, 235, 238);
                btnManageDepartment.FlatAppearance.BorderColor = Color.FromArgb(233, 235, 238);
                btnManageDepartment.FlatAppearance.BorderSize = 1;
                btnManageDepartment.ForeColor = Color.FromArgb(28, 28, 28);
                btnManageDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

                btnManageAccount.Image = Properties.Resources.user_24_black;
                btnManageAccount.BackColor = Color.FromArgb(233, 235, 238);
                btnManageAccount.FlatAppearance.BorderColor = Color.FromArgb(233, 235, 238);
                btnManageAccount.FlatAppearance.BorderSize = 1;
                btnManageAccount.ForeColor = Color.FromArgb(28, 28, 28);
                btnManageAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

                btnCreateSchedule.Image = Properties.Resources.schedule_24_black;
                btnCreateSchedule.BackColor = Color.FromArgb(233, 235, 238);
                btnCreateSchedule.FlatAppearance.BorderColor = Color.FromArgb(233, 235, 238);
                btnCreateSchedule.FlatAppearance.BorderSize = 1;
                btnCreateSchedule.ForeColor = Color.FromArgb(28, 28, 28);
                btnCreateSchedule.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void FillUserControlToMain(string panel)
        {
            try
            {
                pnMain.Controls.Clear();
                switch (panel)
                {
                    case "manage_schedule":
                        if (uc_ManageSchedule_Action == null)
                        {
                            uc_ManageSchedule_Action = new uc_ManageSchedule_Action();
                            pnMain.Controls.Add(uc_ManageSchedule_Action);
                            uc_ManageSchedule_Action.Dock = DockStyle.Fill;
                            uc_ManageSchedule_Action.Location = new Point(0, 0);
                            uc_ManageSchedule_Action.Size = new Size(pnMain.Width, pnMain.Height);
                            uc_ManageSchedule_Action.TabIndex = 0;
                        }
                        else
                        {
                            pnMain.Controls.Add(uc_ManageSchedule_Action);
                        }
                        break;
                    case "manage_department":
                        if (uc_ManageDepartment_Action == null)
                        {
                            uc_ManageDepartment_Action = new uc_ManageDepartment_Action();
                            pnMain.Controls.Add(uc_ManageDepartment_Action);
                            uc_ManageDepartment_Action.Dock = DockStyle.Fill;
                            uc_ManageDepartment_Action.Location = new Point(0, 0);
                            uc_ManageDepartment_Action.Size = new Size(pnMain.Width, pnMain.Height);
                            uc_ManageDepartment_Action.TabIndex = 0;
                        }
                        else
                        {
                            pnMain.Controls.Add(uc_ManageDepartment_Action);
                        }
                        break;
                    case "manage_account":
                        if (uc_ManageAccount_Action == null)
                        {
                            uc_ManageAccount_Action = new uc_ManageAccount_Action();
                            pnMain.Controls.Add(uc_ManageAccount_Action);
                            uc_ManageAccount_Action.Dock = DockStyle.Fill;
                            uc_ManageAccount_Action.Location = new Point(0, 0);
                            uc_ManageAccount_Action.Size = new Size(pnMain.Width, pnMain.Height);
                            uc_ManageAccount_Action.TabIndex = 0;
                        }
                        else
                        {
                            pnMain.Controls.Add(uc_ManageAccount_Action);
                        }
                        break;
                    case "create_schedule":
                        if (uc_CreateSchedule_Action == null)
                        {
                            uc_CreateSchedule_Action = new uc_CreateSchedule_Action();
                            pnMain.Controls.Add(uc_CreateSchedule_Action);
                            uc_CreateSchedule_Action.Dock = DockStyle.Fill;
                            uc_CreateSchedule_Action.Location = new Point(0, 0);
                            uc_CreateSchedule_Action.Size = new Size(pnMain.Width, pnMain.Height);
                            uc_CreateSchedule_Action.TabIndex = 0;
                        }
                        else
                        {
                            pnMain.Controls.Add(uc_CreateSchedule_Action);
                        }
                        break;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }
        private void btnManageSchedule_Click(object sender, EventArgs e)
        {
            HighlightButtonClicked("manage_schedule");
            FillUserControlToMain("manage_schedule");
        }

        private void btnManageDepartment_Click(object sender, EventArgs e)
        {
            HighlightButtonClicked("manage_department");
            FillUserControlToMain("manage_department");
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            HighlightButtonClicked("manage_account");
            FillUserControlToMain("manage_account");
        }

        private void btnCreateSchedule_Click(object sender, EventArgs e)
        {
            HighlightButtonClicked("create_schedule");
            FillUserControlToMain("create_schedule");
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            btnManageSchedule_Click(sender, e);
        }
    }
}
