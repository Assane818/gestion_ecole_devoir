using WebGestionEcole.Models.Enum;

namespace WebGestionEcole.Models
{
    public class Professeur: AbstractEntity
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Specialite Specialite { get; set; }
        public Grade Grade { get; set; }
    }
}