using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDQLTC.DAL.Model;

namespace UDQLTC.BUS
{
    public class ThongKeService
    {
        private Model1 dbContext; // Khai báo biến cho DbContext
        public ThongKeService()
       {
            dbContext = new Model1(); // Khởi tạo context
        }

        public List<object> GetKhoanThu(int taiKhoanId, DateTime startDate, DateTime endDate)
        {
            // Sử dụng LINQ để lấy dữ liệu và tạo một đối tượng vô danh để chứa thông tin
            return dbContext.KHOAN_THU
                .Include(k => k.DANHMUC_THU) // Bao gồm danh mục thu
                .Where(k => k.ID_TK == taiKhoanId && k.NGAY_THU >= startDate && k.NGAY_THU <= endDate)
                .Select(k => new
                {
                    TenDanhMuc = k.DANHMUC_THU.TEN_DM_THU, // Tên danh mục
                    k.SO_TIEN,                            // Số tiền
                    k.NGAY_THU,                           // Ngày thu
                    k.MO_TA                                // Mô tả
                })
                .ToList<object>(); // Trả về danh sách các đối tượng vô danh
        }

        public List<object> GetKhoanChi(int taiKhoanId, DateTime startDate, DateTime endDate)
        {
            // Sử dụng LINQ để lấy dữ liệu và tạo một đối tượng vô danh để chứa thông tin
            return dbContext.KHOAN_CHI
                .Include(k => k.DANHMUC_CHI) // Bao gồm danh mục chi
                .Where(k => k.ID_TK == taiKhoanId && k.NGAY_CHI >= startDate && k.NGAY_CHI <= endDate)
                .Select(k => new
                {
                    TenDanhMuc = k.DANHMUC_CHI.TEN_DM_CHI, // Tên danh mục
                    k.SO_TIEN,                             // Số tiền
                    k.NGAY_CHI,                            // Ngày chi
                    k.MO_TA                                 // Mô tả
                })
                .ToList<object>(); // Trả về danh sách các đối tượng vô danh
        }
    }
}
