using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AspNetCoreBank.Models;

namespace AspNetCoreBank.Models
{
    public class MovementViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [Required]
        public decimal amount { get; set; }
        public int status { get; set; }
        public DateTime date { get; set; }
        public Products Products  { get; set; }
        public MovementsType MovementsType  { get; set; }

        public ProductType[] ProductTypes { get; set; }
    }
}