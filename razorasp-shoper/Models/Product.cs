// ===========================================================================
/// <summary>
/// Product.cs
/// razorasp-shoper
/// created by Mehrdad Soleimanimajd on 02.08.2023
/// </summary>
/// <created>ʆϒʅ, 02.08.2023</created>
/// <changed>ʆϒʅ, 12.08.2023</changed>
// ===========================================================================

using System.ComponentModel.DataAnnotations;

namespace razorasp_shoper.Models
{
    public enum Categories { Wearables, لوازم, Appliance, Gadgets, Tech, Tools, Categories }
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [DisplayFormat(NullDisplayText = "uncategorized")]
        public Categories? Category { get; set; }
        public string Image { get; set; } = string.Empty;
        public ICollection<Purchase>? Purchases { get; set; }

    }
}
