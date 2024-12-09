
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebGestionDette.Data;

namespace WebGestionEcole.Controllers
{
    public class CoursController : Controller
    {
        private readonly WebGesEcoleContext _context;

        public CoursController(WebGesEcoleContext context)
        {
            _context = context;
        }

        // GET: Cours
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var etudiant = await _context.Etudiants.FindAsync(id);
            var DetailCours = await _context.DetailCours.Include(d => d.Cours).Include(d => d.Classe).Where(d => d.ClasseId == etudiant.ClasseId).ToListAsync();
            return View(DetailCours);
        }

    
    }
}