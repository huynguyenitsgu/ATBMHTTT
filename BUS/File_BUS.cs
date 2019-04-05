using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class File_BUS
    {
        private static File_BUS instance;
        public static File_BUS Instance
        {
            get
            {
                if (instance == null) instance = new File_BUS();
                return instance;
            }
            private set { File_BUS.instance = value; }
        }
        private File_BUS() { }
        public string Read(string name)
        {
            return File_DAL.Instance.Read(name);
        }
        public bool Write(string name)
        {
            return File_DAL.Instance.Write(name);
        }
        public bool MahoaDichuyen(int key)
        {
            return File_DAL.Instance.MahoaDichuyen(key);
        }

        public bool MahoaHoanvi(int key)
        {
            return File_DAL.Instance.MahoaHoanvi(key);
        }
        public bool GiaimaDichuyen(int key)
        {
            return File_DAL.Instance.GiaimaDichuyen(key);
        }

        public bool GiaimaHoanvi(int key)
        {
            return File_DAL.Instance.GiaimaHoanvi(key);
        }
        public string Xem()
        {
            return File_DAL.Instance.Xem();
        }
    }
}
