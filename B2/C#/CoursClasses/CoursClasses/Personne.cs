using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursClasses
{
    public class Personne
    {
        private string nom, prenom;

        /// <summary>
        /// Constructeur de la classe 
        /// appelé au moment du new (instanciation)
        /// </summary>
        /// <param name="n">Nom de la personne</param>
        public Personne(string n, string p = "?")
        {
            nom = n;
            prenom = p;
            // Ou appeler Renommer(n);
        }
        public void Renommer(string nouveauNom)
        {
            if(nouveauNom.Length==0)
            {
                throw new ArgumentException("Le nom ne peut être vide");
                // Pas bien : Console.Error.WriteLine("")
                // TODO : Faire une bonne gestion d'erreur
            }
            nom = nouveauNom;
        }
        public string GetNomUsuel()
        {
            return $"{prenom} {nom}";
        }
        public string GetNomUsuel2() => $"{prenom} {nom}";

        /// <summary>
        /// Propriété s'utilise comme un champ, se code comme une méthode
        /// </summary>
        public string NomUsuel
        {
            get
            {
                return $"{prenom} {nom}";
            }
            set
            {
                var parties = value.Split(' ');
                prenom = parties[0];
                nom = parties[1]; // TODO : Gérer l'absence de seconde partie
            }
        }
        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                if(value.Length == 0)
                {

                }
                nom = value;
            }
        }
        public string Prenom
        {
            get => prenom;
     
        }
        /// <summary>
        /// Propriété automatique (le champ est implicite)
        /// </summary>
        public int Age { get; init; }
    }
}
