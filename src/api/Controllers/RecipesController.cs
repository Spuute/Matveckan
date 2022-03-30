using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using api.Entities;
using api.Services;

namespace api.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipesController(IRecipeService recipeService)
        {
            _recipeService = recipeService;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var recipes = await _recipeService.GetAllRecipes();
            return Ok("All Good");
        }


    }
}