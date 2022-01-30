using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatikaDevCodeFirst.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(11)]
        [Column(TypeName = "varchar(11)")]
        public string Number { get; set; }
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime CreateDate { get; set; }
        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime UpdateDate { get; set; }
    }
}
