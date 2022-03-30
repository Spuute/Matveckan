using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using api.Entities;

namespace api.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllRecipes() {
            throw new NotImplementedException();
        }


    }
}