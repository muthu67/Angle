namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentType")]
    public partial class DocumentType
    {
        public int DocumentTypeID { get; set; }

        public int? DocumentModuleID { get; set; }

        public int? ClientID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public bool? IsActive { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }
    }
}
