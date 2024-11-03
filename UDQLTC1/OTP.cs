using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace UDQLTC
{
    public partial class OTP : Form
    {
        private string otpCode;
        public OTP(string otp)
        {
            InitializeComponent();
            otpCode = otp; // Lưu mã OTP
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            string enteredOTP = txtOTP.Text; // TextBox cho người dùng nhập mã OTP

            if (enteredOTP == otpCode) // Kiểm tra mã OTP
            {
                MessageBox.Show("Xác minh thành công! Tài khoản đã được tạo.");
                // Thực hiện các bước tiếp theo như lưu tài khoản vào cơ sở dữ liệu
                this.DialogResult = DialogResult.OK; // Trả về kết quả OK
                this.Close(); // Đóng form xác thực
            }
            else
            {
                MessageBox.Show("Mã OTP không đúng. Vui lòng kiểm tra lại.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
