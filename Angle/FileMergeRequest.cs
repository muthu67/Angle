namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IDDev.FileMergeRequest")]
    public partial class FileMergeRequest
    {
        [Key]
        [Column(Order = 0)]
        public int RequestID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string DocumentList { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string FileAction { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string FileOutputType { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Status { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string FileConversionType { get; set; }

        [StringLength(50)]
        public string MergedFile { get; set; }

        public DateTime? RequestedDateTime { get; set; }
    }
}
