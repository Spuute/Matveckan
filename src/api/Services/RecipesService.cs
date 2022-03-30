using api.Entities;

namespace api.Services
{
    public class RecipesService : IRecipeService
    {
        public RecipesService() {
            
        }

        public Task<List<Recipe>> GetAllRecipes() {
            throw new NotImplementedException();
        }
    }
}