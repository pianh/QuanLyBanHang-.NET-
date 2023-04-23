using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        // Hàm xemm danh mục
        void XemDanhMuc(int intDanhMuc)
        {
            Form frmXemDanhMuc = new frmXemDanhMuc();
            frmXemDanhMuc.Text = intDanhMuc.ToString();
            frmXemDanhMuc.ShowDialog();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            Form frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmTacGia = new frmTacGia();
            frmTacGia.Text = "Tác giả";
            frmTacGia.ShowDialog();
        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmHeThong = new frmHeThong();
            frmHeThong.Text = "Hệ thống";
            frmHeThong.ShowDialog();
        }

        private void cityCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(1);
        }

        private void customerCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(2);
        }

        private void staffCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(3);
        }

        private void productCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(4);
        }

        private void billCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(5);
        }

        private void detailBillCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(6);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDangNhap = new frmDangNhap();
            frmDangNhap.Text = "Đăng nhập hệ thống";
            frmDangNhap.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }
    }
}
