namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentDetail")]
    public partial class DocumentDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string DocumentDetailID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClientID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DocumentModuleID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DocumentTypeID { get; set; }

        [StringLength(150)]
        public string FileName { get; set; }

        [StringLength(5)]
        public string FileType { get; set; }

        public int? FileSize { get; set; }

        [StringLength(10)]
        public string DirectoryName { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsArchived { get; set; }

        public bool? IsPrivate { get; set; }

        [StringLength(50)]
        public string MimeType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UploadedDate { get; set; }

        [StringLength(100)]
        public string UploadedBy { get; set; }
    }
}
