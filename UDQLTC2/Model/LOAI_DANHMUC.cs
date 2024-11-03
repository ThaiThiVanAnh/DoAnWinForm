namespace UDQLTC.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOAI_DANHMUC
    {
        [Key]
        public int ID_DM { get; set; }

        [StringLength(50)]
        public string TEN_DM { get; set; }
    }
}
