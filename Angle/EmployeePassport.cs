namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeePassport")]
    public partial class EmployeePassport
    {
        [Key]
        public int PassportID { get; set; }

        [StringLength(50)]
        public string PassportNo { get; set; }

        [StringLength(250)]
        public string GivenName { get; set; }

        [StringLength(250)]
        public string FamilyName { get; set; }
    }
}
