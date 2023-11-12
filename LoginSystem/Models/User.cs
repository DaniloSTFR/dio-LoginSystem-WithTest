using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoginSystem.Models
{
    [Table("person")]
    public class User
    {
        [Key]
        [Column("idUser")]
        public int Id { get; set; }

        [Column("fullName")]
        public string FullName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("rolePosition")]
        public EnumRolePosition RolePosition { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("birthDate")]
        public DateTime BirthDate { get; set; }

        [Column("CreationDate")]
        public DateTime CreationDate { get; set; }
        
    }
}