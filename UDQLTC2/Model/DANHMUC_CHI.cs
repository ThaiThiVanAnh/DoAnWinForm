namespace UDQLTC.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANHMUC_CHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANHMUC_CHI()
        {
            KHOAN_CHI = new HashSet<KHOAN_CHI>();
        }

        [Key]
        public int ID_DM_CHI { get; set; }

        [StringLength(50)]
        public string TEN_DM_CHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOAN_CHI> KHOAN_CHI { get; set; }
    }
}
