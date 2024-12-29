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
using UniversitySchedule.Utils;

namespace UniversitySchedule.View.CreateSchedule
{
    public partial class frm_Schedule : Form
    {
        public frm_Schedule()
        {
            InitializeComponent();
        }

        public static string Name;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameSchedule.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Vui lòng nhập tên thời khóa biểu!", "Thông báo");
                    return;
                }

                Name = txtNameSchedule.Text;
                this.Close();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void frm_Schedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (txtNameSchedule.Text.IsNullOrEmpty())
                {
                    Name = string.Empty;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }
    }
}
