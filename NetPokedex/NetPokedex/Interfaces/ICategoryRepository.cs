using NetPokedex.Models;

namespace NetPokedex.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int categoryId);
        ICollection<Pokemon> GetPokemonsByCategoryId(int categoryId);
        bool CategoryExists(int categoryId);
        
    }
}
