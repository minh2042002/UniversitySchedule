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
    public partial class frm_AddRoom : Form
    {
        public frm_AddRoom()
        {
            InitializeComponent();
        }

        private Room currentRoom;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Room room = new Room();
                if (!txtNameRoom.Text.Trim().IsNullOrEmpty() && numCapacity.Value > 0)
                {
                    room.Name = txtNameRoom.Text.Trim();
                    room.Capacity = ((int)numCapacity.Value);
                    txtNameRoom.Clear();
                    numCapacity.Value = 1;
                    int addResult = RoomController.Instance().InsertRoom(room);
                    if (addResult == 0)
                    {
                        MessageBox.Show("Đã tồn tại phòng học này!", "Thông Báo");
                    }
                    else if (addResult == -1)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại!", "Thông Báo");
                    }
                    else if (addResult == 1)
                    {
                        MessageBox.Show("Thêm phòng học thành công.", "Thông báo");
                        LoadRoomFromDatabase();
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNameRoom.Text.Trim().IsNullOrEmpty() && numCapacity.Value > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn cập nhật dữ liệu phòng học này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        currentRoom.Name = txtNameRoom.Text.Trim();
                        currentRoom.Capacity = (int)numCapacity.Value;
                        int updateResult = RoomController.Instance().UpdateRoom(currentRoom);
                        if (updateResult == 0)
                        {
                            MessageBox.Show("Không tồn tại phòng học này!", "Thông Báo");
                        }
                        else if (updateResult == -1)
                        {
                            MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại!", "Thông Báo");
                        }
                        else if (updateResult == 1)
                        {
                            MessageBox.Show("Cập nhật phòng học thành công.", "Thông báo");
                            LoadRoomFromDatabase();
                        }
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa phòng học này không ?\n Việc xóa phòng học sẽ xóa tất cả dữ liệu liên quan đến phòng học này!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Room room = (Room)dgvRoom.CurrentRow.Tag;
                    int deleteResult = RoomController.Instance().DeleteRoom(currentRoom);
                    if (deleteResult == 0)
                    {
                        MessageBox.Show("Không tồn tại phòng học này!", "Thông Báo");
                    }
                    else if (deleteResult == -1)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại!", "Thông Báo");
                    }
                    else if (deleteResult == 1)
                    {
                        MessageBox.Show("Xóa phòng học thành công.", "Thông báo");
                        LoadRoomFromDatabase();
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void FillTodgvRoom(Room room)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                cell1.Value = (dgvRoom.Rows.Count + 1).ToString();
                row.Cells.Add(cell1);

                DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                cell2.Value = room.Id;
                row.Cells.Add(cell2);

                DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
                cell3.Value = room.Name;
                row.Cells.Add(cell3);

                DataGridViewTextBoxCell cell4 = new DataGridViewTextBoxCell();
                cell4.Value = room.Capacity;
                row.Cells.Add(cell4);

                row.Tag = room;

                Invoke(new MethodInvoker(delegate ()
                {
                    dgvRoom.Rows.Add(row);
                }));
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void LoadRoomFromDatabase()
        {
            try
            {
                dgvRoom.Rows.Clear();
                List<Room> rooms = RoomController.Instance().GetAllRoom();
                foreach (Room room in rooms)
                {
                    FillTodgvRoom(room);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        private void frm_AddRoom_Load(object sender, EventArgs e)
        {
            LoadRoomFromDatabase();
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                currentRoom = (Room)dgvRoom.CurrentRow.Tag;
                txtNameRoom.Text = currentRoom.Name;
                numCapacity.Value = currentRoom.Capacity;
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }
    }
}
