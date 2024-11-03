using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UDQLTC.BUS;
using UDQLTC.DAL.Model;

namespace UDQLTC
{
    public partial class MucTieu : Form
    {
        private MucTieuService mucTieuService; // Khai báo biến để lưu trữ MucTieuService
        private int currentTaiKhoanId; // Sử dụng biến này thay cho idTaiKhoan

        public MucTieu(int taiKhoanId) // Constructor nhận ID tài khoản
        {
            InitializeComponent();
            currentTaiKhoanId = taiKhoanId; // Gán giá trị ID tài khoản
            mucTieuService = new MucTieuService(); // Khởi tạo service
        }


        private void MucTieu_Load(object sender, EventArgs e)
        {
            // Gọi phương thức load loại mục tiêu vào ComboBox1
            LoadLoaiMucTieu();
        }
        private void LoadLoaiMucTieu()
        {
            // Lấy danh sách loại mục tiêu từ MucTieuService
            var loaiMucTieuList = mucTieuService.GetLoaiMucTieu();

            // Thiết lập nguồn dữ liệu cho ComboBox1
            comboBox1.DataSource = loaiMucTieuList;
            comboBox1.DisplayMember = "TEN_LOAIMT"; // Tên cột sẽ hiển thị
            comboBox1.ValueMember = "ID_LOAIMT"; // Giá trị của mỗi item
        }


        private void MTRToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtNgayBatDau.Value >= dtNgayKetThuc.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Ngưng thực hiện nếu điều kiện không thỏa mãn
            }

            var mucTieuMoi = new MUC_TIEU
            {
                ID_TK = currentTaiKhoanId, // Sử dụng currentTaiKhoanId
                TEN_MT = txtTenMucTieu.Text,
                SOTIEN_MT = decimal.Parse(txtSoTien.Text),
                NGAYBD_MT = dtNgayBatDau.Value,
                NGAYKT_MT = dtNgayKetThuc.Value,
                ID_LOAIMT = (int)comboBox1.SelectedValue // Lấy ID loại mục tiêu từ ComboBox
            };

            // Thêm mục tiêu mới vào CSDL qua MucTieuService
            mucTieuService.AddMucTieu(mucTieuMoi);

            MessageBox.Show("Thêm mục tiêu thành công!");
        }
    }
}
