using WebGestionDette.Data;
using WebGestionEcole.Data;
using WebGestionEcole.Models;
using WebGestionEcole.Models.Enum;

namespace WebGestionEcole.Data.Fixtures
{
    public class DataFixtures
    {
        private readonly WebGesEcoleContext _context;

        public DataFixtures(WebGesEcoleContext context)
        {
            _context = context;
        }

         public void LoadData()
    {
      if (!_context.Etudiants.Any())
      {


        var Etudiants = new List<Etudiant>();
        var Professeurs = new List<Professeur>();
        var Classes = new List<Classe>();
        var Cours = new List<Cours>();
        var Absences = new List<Absence>();

        for (int i = 1; i <= 25; i++)
        {
          var classe = new Classe
          {
            Libelle = $"Classe {i}",
            Filiere = Filiere.GLRS,
          };
          Classes.Add(classe);
          var Etudiant = new Etudiant
          {
            Nom = $"Etudiant {i}",
            Prenom = $"Prenom {i}",
            Adresse = $"Adresse {i}",
            Classe = classe,
          };

          Etudiants.Add(Etudiant);

          var Professeur = new Professeur
          {
            Nom = $"Professeur {i}",
            Prenom = $"Prenom {i}",
            Grade = Grade.Professeur,
            Specialite = Specialite.Informatique,
          };
          Professeurs.Add(Professeur);

          if (i % 2 == 0)
          {
            var Cour = new Cours
            {
              Date = DateTime.Now.ToUniversalTime(),
              Professeur = Professeur,
              HeureDebut = DateTime.Now.ToUniversalTime(),
              HeureFin = DateTime.Now.ToUniversalTime(),
              NombreHeures = 4,
              Semestre = Semestre.S1,
            };
            Cours.Add(Cour);

            if (i % 5 == 0)
            {
              var Absence = new Absence
              {
                Date = DateTime.Now.ToUniversalTime(),
                NbreHeure = DateTime.Now.Hour,
                Etudiant = Etudiant,
                Cours = Cour
              };
              Absences.Add(Absence);
            }
          }



          _context.Cours.AddRange(Cours);
          _context.Professeurs.AddRange(Professeurs);
          _context.Etudiants.AddRange(Etudiants);
          _context.Classes.AddRange(Classes);
          _context.Absences.AddRange(Absences);
          _context.SaveChanges();
        }

      }
    }
  }
}
