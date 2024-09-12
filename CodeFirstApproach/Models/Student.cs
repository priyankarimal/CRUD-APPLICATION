﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }


        [Column("StudentName", TypeName ="varchar(100)")]
        [Required]
        public string Name { get; set; }


        [Column("StudentGender", TypeName = "varchar(20)")]
        [Required]
        public string Gender { get; set; }


        [Required]
        [Range(1,100)]

        public int? Age { get; set; }

        [Required]
        public int? Standard { get; set; }

    }
}
