namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IDDev.EmployeeDetails")]
    public partial class EmployeeDetail
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string FirstName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string LastName { get; set; }

        public string Address { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(6)]
        public string Pincode { get; set; }

        [StringLength(250)]
        public string State { get; set; }

        [StringLength(250)]
        public string Country { get; set; }
    }
}
