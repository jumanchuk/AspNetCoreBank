namespace AspNetCoreBank.Models
{
    public class ProductsViewModel
    {
        public Products[] Products { get; set; }

        public Products[] ProductDetail { get; set; }

        public Movements[] ProductMovements { get; set; }
    }
}