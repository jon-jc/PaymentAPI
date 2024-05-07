﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentAPI.Models
{
    public class PaymentDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Ensures auto-increment
        public int PaymentDetailId { get; set; }

<<<<<<< HEAD
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string CardOwnerName { get; set; } = string.Empty; // Default to an empty string
=======
        [Column(TypeName ="nvarchar(100)")]
        public string CardOwnerName { get; set; } = "";
>>>>>>> 7eea433636bffd190cba9525d22af8ed9bdf97aa

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string CardNumber { get; set; } = string.Empty; // Default to an empty string

        [Required]
        [Column(TypeName = "varchar(5)")]
        public string ExpirationDate { get; set; } = string.Empty; // Default to an empty string

        [Required]
        [Column(TypeName = "varchar(3)")]
        public string SecurityCode { get; set; } = string.Empty; // Default to an empty string
    }
}
