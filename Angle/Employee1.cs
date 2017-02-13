namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IDDev.Employee")]
    public partial class Employee1
    {
        [Key]
        public int employeeId { get; set; }

        [StringLength(50)]
        public string employeeName { get; set; }

        [StringLength(50)]
        public string employeeLocation { get; set; }
    }
}
