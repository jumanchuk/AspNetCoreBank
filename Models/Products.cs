using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreBank.Models
{
    public class Products
    {
        public int Id { get; set; }
        public int ClientId {get; set;}
        public decimal current_balance { get; set; }
        public decimal status { get; set; }
        public DateTime Opening_date { get; set; }
        public DateTime? Closing_date { get; set; }
        public virtual Client Client { get; set; }
        public virtual ProductType ProductType  { get; set; }
    }

}