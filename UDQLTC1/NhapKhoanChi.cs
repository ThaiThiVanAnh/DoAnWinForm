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
    
    public partial class NhapKhoanChi : Form

    {
        private DanhMucChiService danhMucChiService;
        private List<DANHMUC_CHI> danhMucChis; // Danh sách danh mục chi
        private string selectedCategory; // Biến để lưu danh mục chi đã chọn
        private KhoanChiService khoanChiService; // Khai báo dịch vụ để thêm khoản chi
        private List<PictureBox> pictureList;
        private int currentTaiKhoanId; // Sử dụng biến này thay cho idTaiKhoan
        private DANHMUC_CHI selectedDanhMuc; // Biến để lưu danh mục đã chọn

        public NhapKhoanChi(int taiKhoanId)
        {
            InitializeComponent();
            danhMucChiService = new DanhMucChiService();
            khoanChiService = new KhoanChiService(); // Khởi tạo dịch vụ thêm khoản chi
            currentTaiKhoanId = taiKhoanId; // Gán giá trị ID tài khoản
        }
        
        private void Form4_Load(object sender, EventArgs e)
        {
            LoadDanhMucChi();

        }

        private void LoadDanhMucChi()
        {
            var danhMucs = danhMucChiService.GetAll(); // Lấy danh sách danh mục từ service

            // Tạo danh sách các PictureBox
            pictureList = new List<PictureBox>
            {
        pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
        pictureBox6, pictureBox7, pictureBox8, pictureBox9
            };

            // Duyệt qua danh sách danh mục và gán vào PictureBox
            for (int i = 0; i < danhMucs.Count && i < pictureList.Count; i++)
            {
                var danhMuc = danhMucs[i];
                pictureList[i].Tag = danhMuc; // Gán đối tượng danh mục vào Tag của PictureBox
                pictureList[i].Click += PictureBox_Click; // Gán sự kiện Click cho PictureBox
            }

        }

      

        private void PictureBox_Click(object sender, EventArgs e)
        {
            var pictureBox = sender as PictureBox;
            if (pictureBox != null && pictureBox.Tag is DANHMUC_CHI danhMuc)
            {
                if (selectedDanhMuc == danhMuc) // Nếu PictureBox đã chọn, thì bỏ chọn
                {
                    selectedDanhMuc = null;
                    pictureBox.BorderStyle = BorderStyle.None; // Xóa viền khi bỏ chọn
                }
                else
                {
                    selectedDanhMuc = danhMuc;
                    ResetPictureBoxBorders(); // Bỏ viền cho các PictureBox khác
                    pictureBox.BorderStyle = BorderStyle.Fixed3D; // Đánh dấu viền cho PictureBox được chọn
                }
               
            }
        }

        // Hàm reset viền cho tất cả các PictureBox (bỏ chọn tất cả)
        private void ResetPictureBoxBorders()
        {
            foreach (var pictureBox in pictureList)
            {
                pictureBox.BorderStyle = BorderStyle.None; // Bỏ viền cho tất cả PictureBox
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng đã chọn danh mục và đã nhập số tiền
            if (selectedDanhMuc == null)
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
            var khoanChiMoi = new KHOAN_CHI
            {
                // Gán ID danh mục thu đã chọn từ selectedDanhMucThu
                ID_TK = currentTaiKhoanId, // Sử dụng currentTaiKhoanId
                ID_DM_CHI = selectedDanhMuc.ID_DM_CHI,
                SO_TIEN = soTien,
                MO_TA = txtMoTa.Text, // Nếu có trường mô tả
                NGAY_CHI = DateTime.Now // Có thể thay đổi thành ngày cụ thể nếu cần
            };

            // Thêm khoản thu mới vào CSDL qua KhoanThuService
            khoanChiService.AddKhoanChi(khoanChiMoi);
            MessageBox.Show("Thêm khoản chi thành công!");
        }
    }
}
