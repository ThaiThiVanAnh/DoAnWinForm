using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UDQLTC.Properties;

namespace UDQLTC
{
    public partial class TaiKhoan : Form

    {
        private NhapKhoanChi nhapkhoanchi;
        private NhapKhoanThu nhapkhoanthu;
        private ThongKe thongke;
        private MucTieu muctieu;
        private int currentTaiKhoanId; // Khai báo biến để lưu ID tài khoản
        private Setting setting;
        private ThongKeChi thongKeChi; // Thêm biến cho ThongKeChi

        public TaiKhoan(int taiKhoanId) // Thêm tham số taiKhoanId
        {
            InitializeComponent();
            currentTaiKhoanId = taiKhoanId; // Gán giá trị ID tài khoản
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            nhapkhoanchi = new NhapKhoanChi(currentTaiKhoanId);
            nhapkhoanchi.TopLevel = false;
            nhapkhoanchi.FormBorderStyle = FormBorderStyle.None;
            nhapkhoanchi.Location = new Point(210, 5);
            this.Controls.Add(nhapkhoanchi);
            nhapkhoanchi.Show();

        }

        private void button3_Click(object sender, EventArgs e) //Nhập khoản thu
        {

            // Ẩn form nhập khoản chi nếu nó đang hiển thị
            if (nhapkhoanchi != null && nhapkhoanchi.Visible)
            {
                nhapkhoanchi.Hide();
            }
            if (thongke != null && thongke.Visible)
            {
                thongke.Hide();
            }
            if (muctieu != null && muctieu.Visible)
            {
                muctieu.Hide();
            }
            if (setting != null && setting.Visible)
            {
                setting.Hide();
            }
            // Hiển thị form nhập khoản thu
            if (nhapkhoanthu == null || !nhapkhoanthu.Visible)
            {
                nhapkhoanthu = new NhapKhoanThu(currentTaiKhoanId);
                nhapkhoanthu.TopLevel = false;
                nhapkhoanthu.FormBorderStyle = FormBorderStyle.None;
                nhapkhoanthu.Location = new Point(210, 5);
                this.Controls.Add(nhapkhoanthu);
                nhapkhoanthu.Show();
            }
            
        }

        private void button1_Click(object sender, EventArgs e) //Nhập khoản chi
        {
            if (thongke != null && thongke.Visible)
            {
                thongke.Hide();
            }
            // Hiển thị form nhập khoản thu
            if (nhapkhoanthu != null && nhapkhoanthu.Visible)
            {
                nhapkhoanthu.Hide(); // Ẩn form nhập khoản chi nếu nó đang hiển thị
            }
            if (muctieu != null && muctieu.Visible)
            {
                muctieu.Hide();
            }
            if (setting != null && setting.Visible)
            {
                setting.Hide();
            }
            // Hiển thị form nhập khoản chi
            if (nhapkhoanchi == null || !nhapkhoanchi.Visible)
            {
                nhapkhoanchi = new NhapKhoanChi(currentTaiKhoanId);
                nhapkhoanchi.TopLevel = false;
                nhapkhoanchi.FormBorderStyle = FormBorderStyle.None;
                nhapkhoanchi.Location = new Point(210, 5);
                this.Controls.Add(nhapkhoanchi);
                nhapkhoanchi.Show();
            }


        }

        private void button4_Click(object sender, EventArgs e) // Nhập thống kê
        {
            if (nhapkhoanchi != null && nhapkhoanchi.Visible)
            {
                nhapkhoanchi .Hide(); // Ẩn form nhập khoản chi nếu nó đang hiển thị
            }
            if (nhapkhoanthu != null && nhapkhoanthu.Visible)
            {
                nhapkhoanthu.Hide();
            }
            if (muctieu != null && muctieu.Visible)
            {
                muctieu .Hide(); 
            }
            if (setting != null && setting.Visible)
            {
                setting.Hide();
            }


            if (thongke == null || !thongke.Visible)
            {
                thongke = new ThongKe(currentTaiKhoanId, this); // Truyền TaiKhoan vào constructor
                thongke.TopLevel = false;
                thongke.FormBorderStyle = FormBorderStyle.None;
                thongke.Location = new Point(210, 5);
                this.Controls.Add(thongke);
                thongke.Show();
            }

        }
        public void ShowThongKeChi()
        {
            if (thongKeChi == null || !thongKeChi.Visible)
            {
                thongKeChi = new ThongKeChi(currentTaiKhoanId);
                thongKeChi.TopLevel = false;
                thongKeChi.FormBorderStyle = FormBorderStyle.None;
                thongKeChi.Location = new Point(210, 5);
                this.Controls.Add(thongKeChi);
                thongKeChi.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e) // Nhập mục tiêu
        {

            if (nhapkhoanchi != null && nhapkhoanchi.Visible)
            {
                nhapkhoanchi.Hide(); // Ẩn form nhập khoản chi nếu nó đang hiển thị
            }
            if (nhapkhoanthu != null && nhapkhoanthu.Visible)
            {
                nhapkhoanthu.Hide();
            }
            if (thongke != null && thongke.Visible)
            {
                thongke.Hide();
            }
            if (setting != null && setting.Visible)
            {
                setting.Hide();
            }    
            if (muctieu == null || !muctieu.Visible)
            {
                muctieu = new MucTieu(currentTaiKhoanId); // Truyền ID tài khoản vào constructor
                muctieu.TopLevel = false;
                muctieu.FormBorderStyle = FormBorderStyle.None;
                muctieu.Location = new Point(210, 5);
                this.Controls.Add(muctieu);
                muctieu.Show();
            }

        }

        private void bttSetting_Click(object sender, EventArgs e)
        {
            if (nhapkhoanchi != null && nhapkhoanchi.Visible)
            {
                nhapkhoanchi.Hide(); // Ẩn form nhập khoản chi nếu nó đang hiển thị
            }
            if (nhapkhoanthu != null && nhapkhoanthu.Visible)
            {
                nhapkhoanthu.Hide();
            }
            if (thongke != null && thongke.Visible)
            {
                thongke.Hide();
            }
            if (setting == null || !setting.Visible)
            {
                setting = new Setting();
                setting.TopLevel = false;
                setting.FormBorderStyle = FormBorderStyle.None;
                setting.Location = new Point(210, 5);
                this.Controls.Add(setting);
                setting.Show();
            }
        }

        private void TaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (thongke != null && thongke.Visible)
            {
                thongke.Hide();
            }
            // Hiển thị form nhập khoản thu
            if (nhapkhoanchi != null && nhapkhoanchi.Visible)
            {
                nhapkhoanchi.Hide(); // Ẩn form nhập khoản chi nếu nó đang hiển thị
            }
            if (muctieu != null && muctieu.Visible)
            {
                muctieu.Hide();
            }
            if (setting != null && setting.Visible)
            {
                setting.Hide();
            }
            // Hiển thị form nhập khoản chi
            if (nhapkhoanthu == null || !nhapkhoanthu.Visible)
            {
                nhapkhoanthu = new NhapKhoanThu(currentTaiKhoanId);
                nhapkhoanthu.TopLevel = false;
                nhapkhoanthu.FormBorderStyle = FormBorderStyle.None;
                nhapkhoanthu.Location = new Point(210, 5);
                this.Controls.Add(nhapkhoanthu);
                nhapkhoanthu.Show();
            }
        }
    }
}
