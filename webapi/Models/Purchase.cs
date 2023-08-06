// ===========================================================================
/// <summary>
/// Purchase.cs
/// reactasp-shoper
/// created by Mehrdad Soleimanimajd on 01.08.2023
/// </summary>
/// <created>ʆϒʅ, 01.08.2023</created>
/// <changed>ʆϒʅ, 06.08.2023</changed>
// ===========================================================================

namespace webapi_shoper.Models
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
