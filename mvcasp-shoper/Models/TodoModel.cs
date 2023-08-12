// ===========================================================================
/// <summary>
/// TodoModel.cs
/// mvcasp-shoper
/// created by Mehrdad Soleimanimajd on 02.08.2023
/// </summary>
/// <created>ʆϒʅ, 02.08.2023</created>
/// <changed>ʆϒʅ, 12.08.2023</changed>
// ===========================================================================

using System.ComponentModel.DataAnnotations;

namespace mvcasp_shoper.Models
{
    public class TodoModel
    {
        [Key, Required]
        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;

        public bool IsDone { get; set; } = false;
    }

}