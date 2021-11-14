using System;
using System.Text;

namespace ConsoleRomaine
{
    public class NumerationRomaine
    {
        private record Puissance(int Valeur, string Entier, string Demi)
        {
            private void Repeter(
                StringBuilder resultat, ref int nombre,
                string lettre, int valeur
            )
            {
                if (nombre < 0)
                {
                    resultat.Insert(resultat.Length - 1, lettre);
                    nombre += valeur;
                }
                while (nombre >= valeur)
                {
                    resultat.Append(lettre);
                    nombre -= valeur;
                }
            }
            private void Traiter(
                StringBuilder resultat, ref int nombre,
                string lettre, int valeur, int unite
            )
            {
                if (nombre >= valeur - unite)
                {
                    resultat.Append(lettre);
                    nombre -= valeur;
                }
            }
            public void Convertir(StringBuilder resultat, ref int nombre)
            {
                var dixieme = Valeur / 10;

                Repeter(resultat, ref nombre, Entier, Valeur);
                Traiter(resultat, ref nombre, Entier, Valeur, dixieme);
                Traiter(resultat, ref nombre, Demi, Valeur / 2, dixieme);
            }
        }

        private static readonly Puissance[] Puissances = {
            new Puissance(1000, "M", "D"),
            new Puissance( 100, "C", "L"),
            new Puissance(  10, "X", "V"),
            new Puissance(   1, "I", "")
        };

        public static string Convertir(int nombre)
        {
            if (nombre < 1)
            {
                throw new NotSupportedException("Pas de représentation romaine en dessous de 1");
            }
            var resultat = new StringBuilder();

            foreach (var p in Puissances)
            {
                p.Convertir(resultat, ref nombre);
            }
            return resultat.ToString();
        }
    }
}
