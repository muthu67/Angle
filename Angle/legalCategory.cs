namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IDDev.legalCategory")]
    public partial class legalCategory
    {
        [Key]
        public int categoryId { get; set; }

        [StringLength(50)]
        public string categoryName { get; set; }

        [StringLength(50)]
        public string categorytype { get; set; }

        public string Country { get; set; }
    }
}
