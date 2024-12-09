namespace WebGestionEcole.Models
{
    public class Absence : AbstractEntity
    {
        public int EtudiantId { get; set; }
        public Etudiant Etudiant { get; set; }
        public int CoursId { get; set; }
        public Cours Cours { get; set; }
        public DateTime Date { get; set; }
        public int NbreHeure { get; set; }
    }
}