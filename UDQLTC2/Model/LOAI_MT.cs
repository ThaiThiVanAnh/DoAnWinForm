namespace UDQLTC.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOAI_MT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAI_MT()
        {
            MUC_TIEU = new HashSet<MUC_TIEU>();
        }

        [Key]
        public int ID_LOAIMT { get; set; }

        [StringLength(50)]
        public string TEN_LOAIMT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUC_TIEU> MUC_TIEU { get; set; }
    }
}
