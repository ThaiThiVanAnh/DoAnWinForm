namespace UDQLTC.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHOAN_CHI
    {
        
        [Key]
        public int ID_CHI { get; set; }

        public int? ID_TK { get; set; }

        public int? ID_DM_CHI { get; set; }

        public decimal SO_TIEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAY_CHI { get; set; }

        [StringLength(255)]
        public string MO_TA { get; set; }

        public virtual DANHMUC_CHI DANHMUC_CHI { get; set; }

        public string TenDanhMuc => DANHMUC_CHI?.TEN_DM_CHI;
        public virtual TAI_KHOAN TAI_KHOAN { get; set; }
    }
}
