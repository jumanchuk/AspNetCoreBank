using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreBank.Models
{
    public class ClientRow
    {
        public Guid Id { get; set; }

        public int Document { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Lastname { get; set; }

        public DateTime Date { get; set; }

    }
}