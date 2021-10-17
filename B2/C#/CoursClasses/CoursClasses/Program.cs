using System;

namespace CoursClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var toto = new Personne("Toto");
            var titi = new Personne("Titi");

            toto.Renommer("toto");
            string n = toto.NomUsuel;
            toto.NomUsuel = "Sarah Connors";
        }
    }
}
