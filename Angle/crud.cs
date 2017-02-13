namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IDDev.crud")]
    public partial class crud
    {
        public int id { get; set; }

        [StringLength(67)]
        public string City { get; set; }

        [StringLength(78)]
        public string Address { get; set; }

        [StringLength(56)]
        public string Name { get; set; }
    }
}
