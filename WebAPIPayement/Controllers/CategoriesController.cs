using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using WebAPIPayement.Models;

namespace WebAPIPayement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        
        //Get:api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        {
            return await _context.Categories.ToListAsync();
        }
        
        //GET:api/Categories/id

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            return category;
        }
    }
}