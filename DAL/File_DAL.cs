using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class File_DAL
    {
        private static File_DAL instance;
        public static File_DAL Instance
        {
            get
            {
                if (instance == null) instance = new File_DAL();
                return instance;
            }
            private set { File_DAL.instance = value; }
        }
        private File_DAL() { }
        //File + Chức năng chung
        string temp;
        public string Read(string name)
        {
            temp = IOFile.Instance.Read(name);
            return temp;
        }
        public bool Write(string name)
        {
            try
            {
                IOFile.Instance.Write(name, temp);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string Xem()
        {
            return temp;
        }
        //Thuật toán mã hóa
        public bool MahoaDichuyen(int key)
        {
            try
            {
                string mh = "";
                //Mã hóa
                temp = mh;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool MahoaHoanvi(int key)
        {
            try
            {
                string mh = "";
                //Mã hóa
                temp = mh;
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Thuật toán giải mã
        public bool GiaimaDichuyen(int key)
        {
            try
            {
                string mh = "";
                //Mã hóa
                temp = mh;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool GiaimaHoanvi(int key)
        {
            try
            {
                string mh = "";
                //Mã hóa
                temp = mh;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
