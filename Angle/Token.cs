namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IDDev.Tokens")]
    public partial class Token
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TokenID { get; set; }

        public int? UserID_ { get; set; }

        [Required]
        [StringLength(250)]
        public string AuthToken { get; set; }

        public DateTime IssuedOn { get; set; }

        public DateTime ExpiresOn { get; set; }

        public virtual User_ User_ { get; set; }

        public virtual User_ User_1 { get; set; }
    }
}
