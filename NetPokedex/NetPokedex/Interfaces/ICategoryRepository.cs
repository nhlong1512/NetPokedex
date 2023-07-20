﻿using NetPokedex.Models;

namespace NetPokedex.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int categoryId);
        ICollection<Pokemon> GetPokemonsByCategoryId(int categoryId);
        bool CategoryExists(int categoryId);
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory (Category category);
        bool Save();
        
    }
}
