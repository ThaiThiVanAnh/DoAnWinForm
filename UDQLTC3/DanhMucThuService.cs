using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDQLTC.DAL.Model;

namespace UDQLTC.BUS
{
    public class DanhMucThuService
    {
        public List<DANHMUC_THU> GetAll()
        {
            Model1 context = new Model1();
            return context.DANHMUC_THU.ToList();
        }

        public void Add(DANHMUC_THU danhMucThu)
        {
            using (var context = new Model1())
            {
                context.DANHMUC_THU.Add(danhMucThu);
                context.SaveChanges();
            }
        }
    }
}
