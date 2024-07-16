using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Food.Models
{
    public class FoodDbContext:DbContext
    {
        public FoodDbContext(DbContextOptions<FoodDbContext> options) : base(options)
        { }

        public virtual DbSet<Dish> Dishes { get; set; }
    }
}
