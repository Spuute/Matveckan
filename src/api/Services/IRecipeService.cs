using api.Entities;

namespace api.Services
{
    public interface IRecipeService
    {
        public Task<List<Recipe>> GetAllRecipes();
    }
}