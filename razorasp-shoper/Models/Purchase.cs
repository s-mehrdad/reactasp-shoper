namespace razorasp_shoper.Models
{
        public class Purchase
        {
                public int Id { get; set; }
                public int CartId { get; set; }
                public int ProductId { get; set; }

                public Product? Product { get; set; }
                public Cart? Cart { get; set; }
        }
}
