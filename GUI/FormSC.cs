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
    public partial class FormSC : Form
    {
        public FormSC()
        {
            InitializeComponent();
        }
        //Button Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Button Xem
        private void btnView_Click(object sender, EventArgs e)
        {
            if (tbxInput.Text == "")
            {
                rtbShow.Text = "";
                MessageBox.Show("Nhập tên file!");
            }
            else rtbShow.Text = File_BUS.Instance.Read(tbxInput.Text);
        }
        //Button Xuất
        private void btnXuat_Click(object sender, EventArgs e)
        {
            if(!(File_BUS.Instance.Write(tbxOutput.Text)) || tbxOutput.Text == "")
            {
                MessageBox.Show("Xuất file thất bại!");
            }
            else
            {
                MessageBox.Show("Xuất file thành công!");
            }
        }
        //Các btton mã hóa và giải mã
        private void btnDchuyen_Click(object sender, EventArgs e)
        {
            if (File_BUS.Instance.MahoaDichuyen(Convert.ToInt32(tbxKey.Text)))
            {
                MessageBox.Show("Mã hóa thành công!");
                rtbShow.Text = File_BUS.Instance.Xem();
            }
            else
            {
                MessageBox.Show("Mã hóa thất bại!");
            }
        }
        
        private void btnHvi_Click(object sender, EventArgs e)
        {
            if (File_BUS.Instance.MahoaHoanvi(Convert.ToInt32(tbxKey.Text)))
            {
                MessageBox.Show("Mã hóa thành công!");
                rtbShow.Text = File_BUS.Instance.Xem();
            }
            else
            {
                MessageBox.Show("Mã hóa thất bại!");
            }
        }

        private void btnGiaiHV_Click(object sender, EventArgs e)
        {
            if (File_BUS.Instance.GiaimaHoanvi(Convert.ToInt32(tbxKey.Text)))
            {
                MessageBox.Show("Giải mã thành công!");
                rtbShow.Text = File_BUS.Instance.Xem();
            }
            else
            {
                MessageBox.Show("Giải mã hóa thất bại!");
            }
        }
        
        private void btnGiaiDc_Click(object sender, EventArgs e)
        {
            if (File_BUS.Instance.GiaimaDichuyen(Convert.ToInt32(tbxKey.Text)))
            {
                MessageBox.Show("Giải mã thành công!");
                rtbShow.Text = File_BUS.Instance.Xem();
            }
            else
            {
                MessageBox.Show("Giải mã hóa thất bại!");
            }
        }
    }
}
