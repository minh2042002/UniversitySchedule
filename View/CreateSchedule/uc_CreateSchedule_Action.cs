using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySchedule.Utils;

namespace UniversitySchedule.View.CreateSchedule
{
    public partial class uc_CreateSchedule_Action : UserControl
    {
        public uc_CreateSchedule_Action()
        {
            InitializeComponent();
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
            HighlightButtonClicked("schedule");
        }

        private void btnCreateSchedule_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {

        }

        private void showConsole_Click(object sender, EventArgs e)
        {

        }
    }
}
