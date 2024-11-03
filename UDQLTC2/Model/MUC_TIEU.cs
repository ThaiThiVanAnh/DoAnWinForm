namespace UDQLTC.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MUC_TIEU
    {
        [Key]
        public int ID_MT { get; set; }

        public int? ID_TK { get; set; }

        [StringLength(100)]
        public string TEN_MT { get; set; }

        public decimal? SOTIEN_MT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYBD_MT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYKT_MT { get; set; }

        public int? ID_LOAIMT { get; set; }

        public virtual LOAI_MT LOAI_MT { get; set; }

        public virtual TAI_KHOAN TAI_KHOAN { get; set; }
    }
}
