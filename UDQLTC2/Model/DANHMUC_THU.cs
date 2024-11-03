namespace UDQLTC.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANHMUC_THU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANHMUC_THU()
        {
            KHOAN_THU = new HashSet<KHOAN_THU>();
        }

        [Key]
        public int ID_DM_THU { get; set; }

        [StringLength(50)]
        public string TEN_DM_THU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOAN_THU> KHOAN_THU { get; set; }
    }
}
