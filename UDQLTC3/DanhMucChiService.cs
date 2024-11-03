using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDQLTC.DAL.Model;

namespace UDQLTC.BUS
{
    public class DanhMucChiService
    {
        public List<DANHMUC_CHI> GetAll()
        {
                Model1 context = new Model1();
                return context.DANHMUC_CHI.ToList();
        }

        public void Add(DANHMUC_CHI danhMucChi)
        {
            using (var context = new Model1())
            {
                context.DANHMUC_CHI.Add(danhMucChi);
                context.SaveChanges();
            }
        }

    }
}
