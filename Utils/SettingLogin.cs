using Newtonsoft.Json.Linq;

namespace UniversitySchedule.Utils
{
    public class SettingLogin
    {
        private string path;
        private JObject json;

        public SettingLogin()
        {

            try
            {
                path = $"{Application.StartupPath}data\\settingLogin.json";
                CreateDirectoryIfNotExists(path);

                if (!File.Exists(path))
                {
                    File.WriteAllText(path, "{}");
                }
                json = JObject.Parse(File.ReadAllText(path));
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "");
                json = new JObject();
            }
        }

        public void Update(string key, object value)
        {
            try
            {
                json[key] = value.ToString();
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        public string GetValue(string key, string value = "")
        {
            string result = value;
            try
            {
                result = json.GetValue(key) != null ? json.GetValue(key).ToString() : value;
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "");
            }
            return result;
        }

        public bool GetValueBool(string key, bool value = false)
        {
            bool result = value;
            try
            {
                result = json[key] == null ? value : Convert.ToBoolean(json[key].ToString());
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "");
            }
            return result;
        }

        public int GetValueInt(string key, int value = 0)
        {
            int result = value;
            try
            {
                result = json[key] == null ? value : Convert.ToInt32(json[key].ToString());
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "");
            }
            return result;
        }

        public void Save()
        {
            try
            {
                File.WriteAllText(path, json.ToString());
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }

        public static void CreateDirectoryIfNotExists(string filePath)
        {
            try
            {
                // Lấy đường dẫn thư mục từ đường dẫn tệp
                string directory = Path.GetDirectoryName(filePath);

                // Kiểm tra xem thư mục có tồn tại không
                if (!Directory.Exists(directory))
                {
                    // Tạo thư mục nếu không tồn tại
                    Directory.CreateDirectory(directory);
                    Console.WriteLine("Directory created at: " + directory);
                }
                else
                {
                    Console.WriteLine("Directory already exists at: " + directory);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
        }
    }
}
