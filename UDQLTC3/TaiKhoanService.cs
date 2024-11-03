using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDQLTC.DAL.Model;

namespace UDQLTC.BUS
{
    public class TaiKhoanService
    {
        private Model1 model; // Khai báo biến UserDAL

        public TaiKhoanService()
        {
            model = new Model1(); // Khởi tạo UserDAL trong constructor
        }

        public int Login(string username, string password)
        {
            var user = model.TAI_KHOAN
        .FirstOrDefault(u => u.TEN_TK == username && u.PASSWORD == password);

            return user != null ? user.ID_TK : -1; // Nếu tìm thấy người dùng, trả về ID_TK, ngược lại trả về -1
        }

        public bool CreateAccount(string username, string password, string email, string SDT)
        {
            using (var context = new Model1())
            {
                // Kiểm tra xem tên đăng nhập đã tồn tại chưa
                if (context.TAI_KHOAN.Any(tk => tk.TEN_TK == username))
                {
                    return false; // Tên đăng nhập đã tồn tại
                }

                // Tạo đối tượng TAI_KHOAN mới
                var newAccount = new TAI_KHOAN
                {
                    //ID_TK = Guid.NewGuid(), // Tạo ID bằng GUID
                    TEN_TK = username,
                    PASSWORD = password,
                    EMAIL = email,
                    STD = SDT
                };

                context.TAI_KHOAN.Add(newAccount);
                context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                return true; // Tạo tài khoản thành công
            }
        }
    }
}
