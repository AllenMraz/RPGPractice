using System.ComponentModel.DataAnnotations;

namespace RPGPreactice.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        public int Level { get; set; }


    }
}
