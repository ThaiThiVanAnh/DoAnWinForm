using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDQLTC
{
    public partial class ThongKeChi : Form
    {
        private int currentTaiKhoanId; // Biến lưu ID tài khoản
        public ThongKeChi(int taiKhoanId)
        {
            InitializeComponent();
            currentTaiKhoanId = taiKhoanId; // Gán giá trị ID tài khoản
        }

        private void ThongKeChi_Load(object sender, EventArgs e)
        {
            // Logic để tải dữ liệu khi form được mở có thể thêm ở đây
            LoadData();
        }
        private void LoadData()
        {
            // Thêm logic để lấy dữ liệu và hiển thị ở đây
        }
    }
}
