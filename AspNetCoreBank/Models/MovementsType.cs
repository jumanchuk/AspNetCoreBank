using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreBank.Models
{
    public class MovementsType
    {
        public int Id { get; set; }
        public int Movements_type { get; set; }
        public string name { get; set; }
        public int status { get; set; }

    }

}