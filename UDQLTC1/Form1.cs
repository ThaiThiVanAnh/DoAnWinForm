using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UDQLTC.BUS;

namespace UDQLTC
{
    public partial class Form1 : Form
    {
        private TaiKhoanService taiKhoanService;
        public Form1()
        {
            InitializeComponent();
            taiKhoanService = new TaiKhoanService();
            txtMatKhau.UseSystemPasswordChar = true;

            // Đăng ký các sự kiện cho ptbHienMK
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave; // Đảm bảo ẩn mật khẩu khi chuột ra ngoài
            txtMatKhau.UseSystemPasswordChar = true; // Mặc định ẩn mật khẩu

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;

            int userId = taiKhoanService.Login(username, password);
            if (userId != -1) // Nếu đăng nhập thành công
            {
                TaiKhoan form3 = new TaiKhoan(userId); // Truyền ID_TK vào
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            // Mở form tạo tài khoản
            Form2 taoTKForm = new Form2();
            taoTKForm.ShowDialog();

            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true; // Ẩn mật khẩu
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false; // Hiện mật khẩu
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true; // Ẩn mật khẩu khi chuột ra ngoài
        }
    }
}
