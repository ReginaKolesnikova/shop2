using Microsoft.AspNetCore.Mvc;

namespace ShopTARgv24.Controllers
{
    public class SpaceshipsController : Controller
    {
        public readonly ShopTARgv24Context _context;

        public SpaceshipsController 
            (
            ShopTARgv24Context context
            )
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var result = _context.Spaceships
                .Select(x => new SpaceshipsIndexViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    TypeName = x.TypeName,
                    BuiltDate = x.BuiltDate,
                    Crew = x.Crew
                });

            return View(result);
        }
    }
}
