namespace UDQLTC.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LIEN_KET
    {
        [Key]
        public int ID_LK { get; set; }

        public int? ID_TK { get; set; }

        public int? LINKED_USER_ID { get; set; }

        public virtual TAI_KHOAN TAI_KHOAN { get; set; }

        public virtual TAI_KHOAN TAI_KHOAN1 { get; set; }
    }
}
