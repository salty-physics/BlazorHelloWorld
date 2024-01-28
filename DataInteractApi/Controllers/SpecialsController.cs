using DataInteractApi.Context;
using DataInteractApi.Services;
using DataInteractShared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataInteractApi.Controllers
{
    [Route("specials")]
    [ApiController]
    public class SpecialsController(
        PizzaStoreDbContext db,
        SeedDataService seed) : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
        {
            return await db.Specials.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> SeedData()
        {
            await seed.Initialize();
            return Ok();
        }
    }
}
