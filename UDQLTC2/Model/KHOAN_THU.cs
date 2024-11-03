namespace UDQLTC.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHOAN_THU
    {
        public string TenDanhMuc { get; set; }
        [Key]
        public int ID_THU { get; set; }

        public int? ID_TK { get; set; }

        public int? ID_DM_THU { get; set; }

        public decimal SO_TIEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAY_THU { get; set; }

        [StringLength(255)]
        public string MO_TA { get; set; }

        public virtual DANHMUC_THU DANHMUC_THU { get; set; }

        public virtual TAI_KHOAN TAI_KHOAN { get; set; }
    }
}
