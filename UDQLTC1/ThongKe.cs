using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UDQLTC.BUS;

namespace UDQLTC
{
    public partial class ThongKe : Form
    {
        ThongKeService thongKeService;
        private int currentTaiKhoanId; // Sử dụng biến này thay cho idTaiKhoan
        private TaiKhoan taiKhoan; // Tham chiếu đến form TaiKhoan

        public ThongKe(int taiKhoanId, TaiKhoan taiKhoan)
        {
            InitializeComponent();
            currentTaiKhoanId = taiKhoanId;
            this.taiKhoan = taiKhoan; // Lưu tham chiếu để sử dụng sau này
            thongKeService = new ThongKeService(); // Khởi tạo dịch vụ ThongKeService
        }
    

        private void ThongKe_Load(object sender, EventArgs e)
        {
           
        }
        private void LoadData()
        {
            DateTime startDate = dateTimePicker2.Value; // lấy từ control (ví dụ: DateTimePicker)
            DateTime endDate = dateTimePicker1.Value; // lấy từ control (ví dụ: DateTimePicker)

            // Lấy dữ liệu khoản thu và hiển thị
            var khoanThuData = thongKeService.GetKhoanThu(currentTaiKhoanId, startDate, endDate);
            dataGridView2.DataSource = khoanThuData;

            // Lấy dữ liệu khoản chi và hiển thị
            var khoanChiData = thongKeService.GetKhoanChi(currentTaiKhoanId, startDate, endDate);
            dataGridView1.DataSource = khoanChiData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           LoadData();
        }

        private void TKCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Đặt khoảng thời gian bạn muốn lọc
    DateTime startDate = dateTimePicker2.Value; // lấy từ control (ví dụ: DateTimePicker)
            DateTime endDate = dateTimePicker1.Value; // lấy từ control (ví dụ: DateTimePicker)

            // Lấy dữ liệu khoản thu và hiển thị
            var khoanChiData = thongKeService.GetKhoanChi(currentTaiKhoanId, startDate, endDate);
            dataGridView1.DataSource = khoanChiData;

            // Đặt dữ liệu của khoản chi thành null để không hiển thị
            dataGridView2.DataSource = null;

        }
        private bool IsFormOpen(Type formType)
        {
            // Kiểm tra xem form đã mở hay chưa
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == formType)
                {
                    form.BringToFront(); // Nếu đã mở, đưa nó lên trên
                    return true;
                }
            }
            return false;
        }

        private void TKTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Đặt khoảng thời gian bạn muốn lọc
    DateTime startDate = dateTimePicker2.Value; // lấy từ control (ví dụ: DateTimePicker)
            DateTime endDate = dateTimePicker1.Value; // lấy từ control (ví dụ: DateTimePicker)

            // Lấy dữ liệu khoản thu và hiển thị
            var khoanThuData = thongKeService.GetKhoanThu(currentTaiKhoanId, startDate, endDate);
            dataGridView2.DataSource = khoanThuData;

            // Đặt dữ liệu của khoản chi thành null để không hiển thị
            dataGridView1.DataSource = null;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
