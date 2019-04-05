using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DTO;
using System.Reflection;

namespace DAL
{
    public class IOFile
    {
        private static IOFile instance;
        public static IOFile Instance
        {
            get
            {
                if (instance == null) instance = new IOFile();
                return instance;
            }
            private set { IOFile.instance = value; }
        }
        private IOFile() { }
        //Đọc file (auto đọc và lưu ở Attack_05/GUI/Bin/Debug)
        public string Read(string name)
        {
            string s;
            try
            {
                string txtFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
                string txtDir = Path.GetDirectoryName(txtFile);
                string fullPath = Path.Combine(txtDir, name);
                FileStream fs = new FileStream(name, FileMode.Open);
                using (StreamReader rd = new StreamReader(fs, Encoding.UTF8))
                {
                    s = rd.ReadToEnd();
                }
            }
            catch
            {
                s = "Không thể kết nối file!";
            }
            return s;
        }
        //Ghi file
        public void Write(string name ,string text)
        {;
            string txtFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string txtDir = Path.GetDirectoryName(txtFile);
            string fullPath = Path.Combine(txtDir, name);
            FileStream fs = new FileStream(fullPath, FileMode.Create);
            StreamWriter wr = new StreamWriter(fs, Encoding.UTF8);
            wr.Write(text);            
            fs.Close();
        }
    }
}
