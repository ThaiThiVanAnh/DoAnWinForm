using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UDQLTC.BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UDQLTC
{
    public partial class Form2 : Form
    {
        private TaiKhoanService taiKhoanService;
        private string otpCode; // Thêm biến này để lưu trữ mã OTP
        public Form2()
        {
            InitializeComponent();
            taiKhoanService = new TaiKhoanService();
            txtMatKhau.UseSystemPasswordChar = true;

            // Đăng ký các sự kiện cho ptbHienMK
            pictureBox2.MouseDown += pictureBox2_MouseDown_1;
            pictureBox2.MouseUp += pictureBox2_MouseUp;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave_1; // Đảm bảo ẩn mật khẩu khi chuột ra ngoài
            txtMatKhau.UseSystemPasswordChar = true; // Mặc định ẩn mật khẩu
            
            txtNhapLaiMatKhau.UseSystemPasswordChar = true;

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            string email = txtEmail.Text; // Nếu cần thêm email
            string SDT = txtSDT.Text; // Lấy số điện thoại

            // Kiểm tra tính hợp lệ của mật khẩu trước khi tạo tài khoản
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Mật khẩu không đáp ứng các yêu cầu: \n- Ít nhất 1 ký tự hoa \n- Ít nhất 1 ký tự số \n- Ít nhất 1 ký tự đặc biệt \n- Độ dài tối thiểu 8 ký tự.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidPhoneNumber(SDT))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra tính hợp lệ của email trước khi tạo tài khoản
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không đúng định dạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OTPService otpService = new OTPService();
            otpCode = otpService.GenerateOTP(); // Tạo mã OTP
            otpService.SendOTPEmail(email, otpCode); // Gửi mã OTP đến email

            MessageBox.Show("Mã OTP đã được gửi đến email của bạn. Vui lòng kiểm tra và nhập mã để xác minh tài khoản.");

            // Hiển thị form xác thực OTP
            OTP otpForm = new OTP(otpCode);
            if (otpForm.ShowDialog() == DialogResult.OK)
            {
                // Tiến hành tạo tài khoản
                taiKhoanService.CreateAccount(username, password, email, SDT); // Thực hiện lưu tài khoản vào cơ sở dữ liệu
                
            }
        }

        private bool IsValidPhoneNumber(string SDT)
        {
            string phonePattern = @"^\d{10}$"; // Mẫu cho số điện thoại 10 chữ số
            return Regex.IsMatch(SDT, phonePattern);
        }
        private bool IsValidEmail(string email)
        {
            // Biểu thức chính quy kiểm tra định dạng email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsValidPassword(string password)
        {
            // Ràng buộc 1: Mật khẩu phải chứa ít nhất một ký tự viết hoa
            if (!password.Any(char.IsUpper))
                return false;

            // Ràng buộc 2: Mật khẩu phải chứa ít nhất một chữ số
            if (!password.Any(char.IsDigit))
                return false;

            // Ràng buộc 3: Mật khẩu phải chứa ít nhất một ký tự đặc biệt
            // Chuỗi ký tự đặc biệt cần được thoát đúng cách trong Regex
            if (!Regex.IsMatch(password, @"[!@#\$%\^&\*\(\),\.?""\:\{\}\|\<\>\[\]]"))
                return false;

            // Ràng buộc 4: Mật khẩu phải có độ dài tối thiểu là 8 ký tự
            if (password.Length < 8)
                return false;

            return true;

        }


        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true; // Ẩn mật khẩu
            txtNhapLaiMatKhau.UseSystemPasswordChar = true;
        }
    

      

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true; // Ẩn mật khẩu khi chuột ra ngoài
            txtNhapLaiMatKhau.UseSystemPasswordChar = true;
        }

        private void pictureBox2_MouseDown_1(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false; // Hiện mật khẩu
            txtNhapLaiMatKhau.UseSystemPasswordChar = false;
        }
    }
}
