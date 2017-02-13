namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblStudent
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        [StringLength(50)]
        public string StudentName { get; set; }

        public bool IsActive { get; set; }
    }
}
