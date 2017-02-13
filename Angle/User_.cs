namespace Angle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IDDev.User_")]
    public partial class User_
    {
        public User_()
        {
            Tokens = new HashSet<Token>();
            Tokens1 = new HashSet<Token>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Token> Tokens { get; set; }

        public virtual ICollection<Token> Tokens1 { get; set; }
    }
}
