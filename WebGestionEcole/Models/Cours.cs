using WebGestionEcole.Models.Enum;

namespace WebGestionEcole.Models;
public class Cours : AbstractEntity
{
    public DateTime Date { get; set; }
    public DateTime Heure { get; set; }
    public DateTime HeureDebut { get; set; }
    public DateTime HeureFin { get; set; }
    public int NombreHeures { get; set; }
    public Semestre Semestre { get; set; }
    public int ProfesseurId { get; set; }
    public Professeur Professeur { get; set; }
    public int ModuleId { get; set; }
    public Module Module { get; set; }
    public ICollection<DetailCours> CoursClasses { get; set; }
}