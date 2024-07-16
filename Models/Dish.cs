using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        public string DishName { get; set; }

        public string ImageUrl { get; set; }

        public bool IsPublished { get; set; }


    }
}
