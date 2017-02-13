namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IDDev.Student")]
    public partial class Student
    {
        public int studentId { get; set; }

        [StringLength(50)]
        public string studentName { get; set; }

        [StringLength(50)]
        public string studentLocation { get; set; }
    }
}
