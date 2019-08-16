using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreBank.Models
{
    public class Movements
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [Required]
        public decimal amount { get; set; }
        public int status { get; set; }
        public DateTime date { get; set; }
        public virtual Products Products  { get; set; }
        public virtual MovementsType MovementsType  { get; set; }
    }

}