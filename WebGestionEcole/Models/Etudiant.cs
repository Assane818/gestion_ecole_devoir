namespace WebGestionEcole.Models;

public class Etudiant : AbstractEntity
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Adresse { get; set; }
    public int ClasseId { get; set; }
    public Classe Classe { get; set; }
    public ICollection<Absence> Absences { get; set; }
}