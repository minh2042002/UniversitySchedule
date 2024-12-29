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
using UniversitySchedule.Models;
using UniversitySchedule.Utils;
using UniversitySchedule.View.ManageAccount;
using UniversitySchedule.View.ManageDepartment;

namespace UniversitySchedule.View.CreateSchedule
{
    public partial class uc_CreateSchedule_Action : UserControl
    {
        public uc_CreateSchedule_Action()
        {
            InitializeComponent();
        }

        private uc_CreateSchedule uc_CreateSchedule;
        private uc_ManageSchedule uc_ManageSchedule;

        private void FillUserControlToPanel(string userControl)
        {
            try
            {
                this.pnMain.Controls.Clear();
                switch (userControl)
                {
                    case "schedule":
                        if (this.uc_CreateSchedule == null)
                        {
                            this.uc_CreateSchedule = new uc_CreateSchedule();
                            this.pnMain.Controls.Add(uc_CreateSchedule);
                            this.uc_CreateSchedule.Dock = DockStyle.Fill;
                            this.uc_CreateSchedule.Location = new Point(0, 0);
                            this.uc_CreateSchedule.Size = new Size(pnMain.Width, pnMain.Height);
                            this.uc_CreateSchedule.TabIndex = 0;
                        }
                        else
                        {
                            this.pnMain.Controls.Add(uc_CreateSchedule);
                        }
                        break;
                    case "manage_schedule":
                        if (this.uc_ManageSchedule == null)
                        {
                            this.uc_ManageSchedule = new uc_ManageSchedule();
                            this.pnMain.Controls.Add(uc_ManageSchedule);
                            this.uc_ManageSchedule.Dock = DockStyle.Fill;
                            this.uc_ManageSchedule.Location = new Point(0, 0);
                            this.uc_ManageSchedule.Size = new Size(pnMain.Width, pnMain.Height);
                            this.uc_ManageSchedule.TabIndex = 0;
                        }
                        else
                        {
                            this.pnMain.Controls.Add(uc_ManageSchedule);
                        }
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
                    case "schedule":
                        pnSchedule.BackColor = Color.FromArgb(250, 82, 82);
                        btnSchedule.BackColor = Color.FromArgb(250, 232, 234);
                        btnSchedule.ForeColor = Color.FromArgb(250, 82, 82);
                        btnSchedule.Font = new Font(btnSchedule.Font, FontStyle.Bold);
                        btnSchedule.Image = Properties.Resources.schedule_24_red;
                        break;
                    case "manage_schedule":
                        pnManageSchedule.BackColor = Color.FromArgb(250, 82, 82);
                        btnManageSchedule.BackColor = Color.FromArgb(250, 232, 234);
                        btnManageSchedule.ForeColor = Color.FromArgb(250, 82, 82);
                        btnManageSchedule.Font = new Font(btnManageSchedule.Font, FontStyle.Bold);
                        btnManageSchedule.Image = Properties.Resources.note_24_red;
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
                btnSchedule.Image = Properties.Resources.schedule_24_black;

                pnManageSchedule.BackColor = Color.White;
                btnManageSchedule.BackColor = Color.White;
                btnManageSchedule.ForeColor = Color.Black;
                btnManageSchedule.Font = new Font(btnManageSchedule.Font, FontStyle.Regular);
                btnManageSchedule.Image = Properties.Resources.note_24_black;
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void uc_CreateSchedule_Action_Load(object sender, EventArgs e)
        {
            try
            {
                HighlightButtonClicked("schedule");
                FillUserControlToPanel("schedule");
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

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            HighlightButtonClicked("schedule");
            FillUserControlToPanel("schedule");
        }

        private void btnManageSchedule_Click(object sender, EventArgs e)
        {
            HighlightButtonClicked("manage_schedule");
            FillUserControlToPanel("manage_schedule");
        }
    }
}
