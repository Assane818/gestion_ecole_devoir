namespace WebGestionEcole.Models;

public class DetailCours : AbstractEntity
{
    public int CoursId { get; set; }
    public Cours Cours { get; set; }
    public int ClasseId { get; set; }
    public Classe Classe { get; set; }
}