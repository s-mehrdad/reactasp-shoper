// ===========================================================================
/// <summary>
/// Purchase.cs
/// razorasp-shoper
/// created by Mehrdad Soleimanimajd on 02.08.2023
/// </summary>
/// <created>ʆϒʅ, 02.08.2023</created>
/// <changed>ʆϒʅ, 12.08.2023</changed>
// ===========================================================================

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
