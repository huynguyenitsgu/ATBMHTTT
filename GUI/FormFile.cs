using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class FormFile : Form
    {
        public FormFile()
        {
            InitializeComponent();
            Loadfile();
        }
        //Loadfile nhóm
        private void Loadfile()
        {
            rtbShow.Text = File_BUS.Instance.Read("Introduce.txt");
        }
        //Button Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
