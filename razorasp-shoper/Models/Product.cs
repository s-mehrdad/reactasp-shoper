namespace razorasp_shoper.Models
{
        public class Product
        {
                public int Id { get; set; }
                public string Name { get; set; } = string.Empty;
                public string Model { get; set; } = string.Empty;
                public string Description { get; set; } = string.Empty;
                public string Category { get; set; } = string.Empty;
                public ICollection<Purchase>? Purchases { get; set; }
        }
}
