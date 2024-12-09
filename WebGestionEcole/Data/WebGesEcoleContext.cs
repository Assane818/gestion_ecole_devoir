using Microsoft.EntityFrameworkCore;
using WebGestionEcole.Models;

namespace WebGestionDette.Data
{
    public class WebGesEcoleContext :DbContext
    {
        public WebGesEcoleContext(DbContextOptions<WebGesEcoleContext> options) : base(options) { }
        public DbSet<Absence> Absences { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<DetailCours> DetailCours { get; set; }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
    }
}