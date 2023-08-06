using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace razorasp_shoper.Models
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
