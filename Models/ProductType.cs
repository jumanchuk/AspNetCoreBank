using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreBank.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        
        public int Product_type { get; set; }
        public string name { get; set; }
        public int status { get; set; }

    }
}