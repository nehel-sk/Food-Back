using Food.Models;

namespace Food.Services.Services_Dish
{
    public interface IDishService
    {
        public List<Dish> GetDish();
       
        bool TogglePublishStatus(int id);

    }
}
