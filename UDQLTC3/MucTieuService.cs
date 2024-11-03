using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDQLTC.DAL.Model;

namespace UDQLTC.BUS
{
    public class MucTieuService
    {
        public List<MUC_TIEU> GetAll()
        {
            using (var context = new Model1())
            {
                return context.MUC_TIEU.ToList();
            }
        }

        public void AddMucTieu(MUC_TIEU mucTieu)
        {
            using (var context = new Model1())
            {
                context.MUC_TIEU.Add(mucTieu);
                context.SaveChanges();
            }
        }

        public List<LOAI_MT> GetLoaiMucTieu()
        {
            using (var context = new Model1())
            {
                return context.LOAI_MT.ToList();
            }
        }

        
    }
}
