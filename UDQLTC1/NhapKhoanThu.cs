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
    public partial class NhapKhoanThu : Form
    {
        private DanhMucThuService danhMucThuService;
        private List<DANHMUC_THU> danhMucThu; // Danh sách danh mục chi
        private KhoanThuService khoanThuService; // Khai báo dịch vụ để thêm khoản thu
        private string Danhmucthu; // Biến để lưu danh mục thu đã chọn
        private List<PictureBox> pictureList;
        private int currentTaiKhoanId; // Sử dụng biến này thay cho idTaiKhoan
        private DANHMUC_THU selectedDanhMucThu;

        public NhapKhoanThu(int taiKhoanId)
        {
            InitializeComponent();
            danhMucThuService = new DanhMucThuService();
            khoanThuService = new KhoanThuService(); // Khởi tạo dịch vụ thêm khoản thu
            currentTaiKhoanId = taiKhoanId; // Gán giá trị ID tài khoản
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void NhapKhoanThu_Load(object sender, EventArgs e)
        {
            LoadDanhMucThu();
        }

        private void LoadDanhMucThu()
        {
            var danhMucthu = danhMucThuService.GetAll(); // Lấy danh sách danh mục từ service

            // Tạo danh sách các PictureBox
            pictureList = new List<PictureBox>
            {
              pictureBox1, pictureBox2, pictureBox9
            };

            // Duyệt qua danh sách danh mục và gán vào PictureBox
            for (int i = 0; i < danhMucthu.Count && i < pictureList.Count; i++)
            {
                var danhMuc = danhMucthu[i];
                pictureList[i].Tag = danhMuc; // Gán đối tượng danh mục vào Tag của PictureBox
                pictureList[i].Click += PictureBox_Click; // Gán sự kiện Click cho PictureBox
            }

        }
        
        private void PictureBox_Click(object sender, EventArgs e)
        {
            var pictureBox = sender as PictureBox;
            if (pictureBox != null && pictureBox.Tag is DANHMUC_THU danhMuc)
            {
                if (selectedDanhMucThu == danhMuc) // Nếu PictureBox đã chọn, thì bỏ chọn
                {
                    selectedDanhMucThu = null;
                    pictureBox.BorderStyle = BorderStyle.None; // Xóa viền khi bỏ chọn
                }
                else
                {
                    selectedDanhMucThu = danhMuc;
                    ResetPictureBoxBorders(); // Bỏ viền cho các PictureBox khác
                    pictureBox.BorderStyle = BorderStyle.Fixed3D; // Đánh dấu viền cho PictureBox được chọn
                }

            }
        }
        private void ResetPictureBoxBorders()
        {
            foreach (var pictureBox in pictureList)
            {
                pictureBox.BorderStyle = BorderStyle.None; // Bỏ viền cho tất cả PictureBox
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng đã chọn danh mục và đã nhập số tiền
            if (selectedDanhMucThu == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục thu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoTien.Text) || !decimal.TryParse(txtSoTien.Text, out decimal soTien))
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng khoản thu mới
            var khoanThuMoi = new KHOAN_THU
            {
                // Gán ID danh mục thu đã chọn từ selectedDanhMucThu
                ID_TK = currentTaiKhoanId, // Sử dụng currentTaiKhoanId
                ID_DM_THU = selectedDanhMucThu.ID_DM_THU,
                SO_TIEN = soTien,
                MO_TA = txtMoTa.Text, // Nếu có trường mô tả
                NGAY_THU = DateTime.Now // Có thể thay đổi thành ngày cụ thể nếu cần
            };

            // Thêm khoản thu mới vào CSDL qua KhoanThuService
            khoanThuService.AddKhoanThu(khoanThuMoi);
            MessageBox.Show("Thêm khoản thu thành công!");
        }
    }
}
