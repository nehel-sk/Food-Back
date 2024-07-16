using Food.Models;
using Microsoft.EntityFrameworkCore;

namespace Food.Repositories.Repositories_Dish
{
    public class DishRepository : IDishRepository
    {
        private readonly FoodDbContext db;

        public DishRepository(FoodDbContext db)
        {
            this.db = db;
        }
        public List<Dish> GetDish()
        {
            return db.Dishes.ToList();
        }

       
        public bool TogglePublishStatus(int id)
        {
            var dish = db.Dishes.Find(id);
            if (dish == null)
            {
                return false;
            }
            dish.IsPublished = !dish.IsPublished;
            db.SaveChanges();

            return true;
        }
    }
}
