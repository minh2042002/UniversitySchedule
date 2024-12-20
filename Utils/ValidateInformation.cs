using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace UniversitySchedule.Utils
{
    public class ValidateInformation
    {
        public class Phone
        {
            public static (bool, string) IsPhoneNumber(string phoneNumber)
            {
                if (string.IsNullOrWhiteSpace(phoneNumber))
                    return (false, "Số điện thoại không được để trống!");

                // Kiểm tra tất cả các ký tự đều là số
                if (phoneNumber.All(char.IsDigit))
                {
                    return (true, "");
                }
                else return (false, "Số điện thoại không phải định dạng số!");
            }

        }
        public class Email
        {
            public static (bool, string) Validate(string email)
            {
                if (string.IsNullOrWhiteSpace(email))
                    return (false, "Email không được để trống!");

                string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (Regex.IsMatch(email, emailPattern))
                {
                    return (true, "");
                }
                else return (false, "Không đúng định dạng mail!");
            }
        }

        public class Password
        {
            // Hàm kiểm tra định dạng mật khẩu
            public static (bool isValid, string message) Validate(string password)
            {
                // Kiểm tra độ dài mật khẩu (tối thiểu 8 ký tự)
                if (password.Length < 8)
                {
                    return (false, "Mật khẩu phải có ít nhất 8 ký tự.");
                }

                // Kiểm tra mật khẩu có chứa chữ cái viết hoa
                if (!Regex.IsMatch(password, @"[A-Z]"))
                {
                    return (false, "Mật khẩu phải có ít nhất một chữ cái viết hoa.");
                }

                // Kiểm tra mật khẩu có chứa chữ cái viết thường
                if (!Regex.IsMatch(password, @"[a-z]"))
                {
                    return (false, "Mật khẩu phải có ít nhất một chữ cái viết thường.");
                }

                // Kiểm tra mật khẩu có chứa số
                if (!Regex.IsMatch(password, @"[0-9]"))
                {
                    return (false, "Mật khẩu phải có ít nhất một số.");
                }

                // Kiểm tra mật khẩu có chứa ký tự đặc biệt
                if (!Regex.IsMatch(password, @"[!@#$%^&*(),.?\""{}|<>]"))
                {
                    return (false, "Mật khẩu phải có ít nhất một ký tự đặc biệt (!@#$%^&*(),.?\"{}|<>).");
                }

                // Nếu tất cả các điều kiện đều hợp lệ
                return (true, "Mật khẩu hợp lệ.");
            }

            public static string Hash(string password)
            {
                using (var sha256 = SHA256.Create())
                {
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                    byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                    return Convert.ToBase64String(hashBytes); // Trả về chuỗi băm dưới dạng Base64
                }
            }

            public static bool Verify(string password, string hashed)
            {
                // Băm mật khẩu người dùng nhập vào và so sánh với mật khẩu đã băm trong cơ sở dữ liệu
                string hashedEnteredPassword = Hash(password);
                return hashedEnteredPassword == hashed;
            }
        }
    }
}
