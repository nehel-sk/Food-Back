using Food.Models;

namespace Food.Repositories.Repositories_Dish
{
    public interface IDishRepository
    {
        List<Dish> GetDish();

       
        bool TogglePublishStatus(int id);
    }
}
