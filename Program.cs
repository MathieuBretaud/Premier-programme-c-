using System;

namespace premier_programme
{
    internal class Program
    {

        static string DemanderNom()
        {
            string nom = "";

            while (nom == "")
            {
                Console.Write("Quel est ton nom ? ");
                nom = Console.ReadLine();
                nom = nom.Trim();
                if (nom == "")
                {
                    Console.WriteLine("Erreur: le nom ne doit pas être vide");
                }
            }
            return nom;
        }

        static int DemanderAge()
        {
            int age_num = 0;


            while (age_num <= 0)
            {
                //demande l'age de la personne
                Console.Write("Quel est votre age ? ");
                string age_str = Console.ReadLine();

                try
                {
                    age_num = int.Parse(age_str);

                    if (age_num < 0)
                    {
                        Console.WriteLine("Erreur : L'age doit pas être négatif");

                    }

                    if (age_num == 0)
                    {
                        Console.WriteLine("Erreur : L'age ne doit pas être égal à 0");
                    }

                }
                catch
                {
                    Console.WriteLine("Erreur : vous devez rentrez un age valide.");
                }
            }

            return age_num;
        }


        static void Main(string[] args)
        {

            string nom = DemanderNom();

            int age = DemanderAge();

            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age + " ans");

            int age_prochain = age + 1;
            Console.WriteLine("bientot vous aurez " + age_prochain + " ans");







        }
    }
}