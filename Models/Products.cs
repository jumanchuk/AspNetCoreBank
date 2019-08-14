using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreBank.Models
{
    public class Products
    {
        public Guid Id { get; set; }
        public int Document { get; set; }
        public long Product_id { get; set; }
        
        public int Product_type { get; set; }
        public Decimal current_balance { get; set; }
        public Decimal status { get; set; }
        public DateTime Opening_date { get; set; }
        public DateTime? Closing_date { get; set; }

    }
}