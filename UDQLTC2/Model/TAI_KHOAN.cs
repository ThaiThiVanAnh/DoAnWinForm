namespace UDQLTC.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TAI_KHOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAI_KHOAN()
        {
            KHOAN_CHI = new HashSet<KHOAN_CHI>();
            KHOAN_THU = new HashSet<KHOAN_THU>();
            LIEN_KET = new HashSet<LIEN_KET>();
            LIEN_KET1 = new HashSet<LIEN_KET>();
            MUC_TIEU = new HashSet<MUC_TIEU>();
        }

        [Key]
        public int ID_TK { get; set; }

        [StringLength(100)]
        public string TEN_TK { get; set; }

        [StringLength(50)]
        public string PASSWORD { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(11)]
        public string STD { get; set; }

        public int? ID_PQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOAN_CHI> KHOAN_CHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOAN_THU> KHOAN_THU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIEN_KET> LIEN_KET { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIEN_KET> LIEN_KET1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUC_TIEU> MUC_TIEU { get; set; }

        public virtual PHAN_QUYEN PHAN_QUYEN { get; set; }
    }
}
