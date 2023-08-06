// ===========================================================================
/// <summary>
/// Cart.cs
/// reactasp-shoper
/// created by Mehrdad Soleimanimajd on 01.08.2023
/// </summary>
/// <created>ʆϒʅ, 01.08.2023</created>
/// <changed>ʆϒʅ, 06.08.2023</changed>
// ===========================================================================


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi_shoper.Models
{
    public class Cart
    {
        public enum CartSize { small, medium, big }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        [DisplayFormat(NullDisplayText = "unspecified")]
        public CartSize? Size { get; set; }
        // discounted algorithms
        public ICollection<Purchase>? Purchases { get; set; }

    }
}
