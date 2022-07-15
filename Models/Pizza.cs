using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    [Table("Pizza")]
    public class Pizza
    {
        [Key]
        public int PizzaId { get; set; }
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        public string ImgPath { get; set; }
    }
}
