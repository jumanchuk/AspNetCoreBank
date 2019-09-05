using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreBank.Api.Models
{
    public class Client
    {
        public long Id { get; set; }
        public int Document { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime Date { get; set; }

    }
}