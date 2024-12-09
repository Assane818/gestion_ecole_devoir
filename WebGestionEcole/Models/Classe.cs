using WebGestionEcole.Models.Enum;

namespace WebGestionEcole.Models
{
    public class Classe: AbstractEntity
    {
        public string Libelle { get; set; }
        public Filiere Filiere { get; set; }
        public ICollection<DetailCours> CoursClasses { get; set; }
    }
}