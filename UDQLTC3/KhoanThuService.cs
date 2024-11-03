using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDQLTC.DAL.Model;

namespace UDQLTC.BUS
{
    public class KhoanThuService
    {
        public List<KHOAN_THU> GetAll()
        {
            Model1 context = new Model1();
            return context.KHOAN_THU.ToList();
        }
        public void AddKhoanThu(KHOAN_THU khoanThu)
        {
            using (var context = new Model1())
            {
                context.KHOAN_THU.Add(khoanThu);
                context.SaveChanges();
            }
        }
    }

    
}
