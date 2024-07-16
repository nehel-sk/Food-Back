using Food.Models;
using Food.Exception;
using Food.Repositories.Repositories_Dish;


namespace Food.Services.Services_Dish
{
    public class DishService : IDishService
    {
        private readonly IDishRepository repo;

        public DishService(IDishRepository repo)
        {

            this.repo = repo;
        }
        public List<Dish> GetDish()
        {
            return repo.GetDish();
        }

        public bool TogglePublishStatus(int id)
        {
            return repo.TogglePublishStatus(id);
        }
    }
}
