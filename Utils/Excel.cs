using ClosedXML.Excel;
using UniversitySchedule.Dto;

namespace UniversitySchedule.Utils
{
    public class Excel
    {
        public static void ExportCoursesToExcelWithDialog(List<ClassDto> Classes)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Save an Excel File";
                    saveFileDialog.FileName = "Schedule.xlsx";
                    saveFileDialog.DefaultExt = "xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Courses");

                            // Tạo Header
                            worksheet.Cell(1, 1).Value = "STT";
                            worksheet.Cell(1, 2).Value = "Bộ môn";
                            worksheet.Cell(1, 3).Value = "Môn học";
                            worksheet.Cell(1, 4).Value = "Thứ";
                            worksheet.Cell(1, 5).Value = "Kíp học";
                            worksheet.Cell(1, 6).Value = "Phòng học"; 
                            worksheet.Cell(1, 7).Value = "Giảng viên"; 
                            worksheet.Cell(1, 8).Value = "Số lượng sinh viên";

                            // Format Header
                            var headerRange = worksheet.Range("A1:H1");
                            headerRange.Style.Font.Bold = true;
                            headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;

                            // Thêm dữ liệu
                            int row = 2;
                            int index = 0;
                            foreach (var classdto in Classes)
                            {
                                worksheet.Cell(row, 1).Value = ++index;
                                worksheet.Cell(row, 2).Value = classdto.Department.Name;
                                worksheet.Cell(row, 3).Value = classdto.Course.Name;
                                worksheet.Cell(row, 4).Value = (int)classdto.MeetingTime.Day +1;
                                worksheet.Cell(row, 5).Value = classdto.MeetingTime.ToString();
                                worksheet.Cell(row, 6).Value = classdto.Room.ToString();
                                worksheet.Cell(row, 7).Value = classdto.Instructor.Name;
                                worksheet.Cell(row, 8).Value = classdto.Course.MaxStudent;
                                row++;
                            }

                            worksheet.Columns().AdjustToContents();
                            workbook.SaveAs(filePath);
                        }

                        MessageBox.Show("Xuất file excel thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "Error exporting courses to Excel");
            }
        }
    }
}
