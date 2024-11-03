using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDQLTC.DAL.Model;

namespace UDQLTC.BUS
{
    public class KhoanChiService // Đảm bảo rằng lớp này là public
    {
        public List<KHOAN_CHI> GetAll()
        {
            using (Model1 context = new Model1())
            {
                return context.KHOAN_CHI.ToList();
            }
        }

        public void AddKhoanChi(KHOAN_CHI khoanChi)
        {
            using (var context = new Model1())
            {
                context.KHOAN_CHI.Add(khoanChi);
                context.SaveChanges();
            }
        }
    }
}
