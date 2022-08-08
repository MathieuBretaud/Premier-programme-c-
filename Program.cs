using System;

namespace premier_programme
{
    internal class Program
    {
        static void AfficherInfosPersonne(string nom, int age, float taille = 0)
        {
            Console.WriteLine();

            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age + " ans");
            Console.WriteLine($"Bonjour, vous vous appelez {nom}, vous avez {age} ans");

            Console.WriteLine("bientot vous aurez " + (age + 1) + " ans");

            
            if (age == 18)
            {
                Console.WriteLine("Vous êtes tout juste majeur");
            }
            else if (age == 17)
            {
                Console.WriteLine("Vous serez bientot majeur");
            }
            else if ((age >= 12) && (age < 18))
            {
                Console.WriteLine("Vous êtes adolescent");
            }
            else if ((age == 1) || (age == 2))
            {
                Console.WriteLine("Vous êtes un bébé");
            }
            else if (age >= 60)
            {
                Console.WriteLine("Vous êtes sénior");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Vous êtes majeur");
            }
            else if (age < 10)
            {
                Console.WriteLine("Vous êtes un enfant");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur");
            }
            if (taille != 0)
            {
                Console.WriteLine("Vous faites " + taille + "m de hauteur.");
            }
        }

        static string DemanderNom(int numeroPersonne)
        {
            string nom = "";

            while (nom == "")
            {
                Console.Write("Quel est ton nom de la personne numéro" + numeroPersonne + " ? ");
                nom = Console.ReadLine();
                nom = nom.Trim();
                if (nom == "")
                {
                    Console.WriteLine("Erreur: le nom ne doit pas être vide");
                }
            }
            return nom;
        }

        static int DemanderAge(string nom)
        {
            int age_num = 0;


            while (age_num <= 0)
            {
                //demande l'age de la personne
                Console.Write(nom + ", Quel est votre age ? ");
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

            //string nom1 = DemanderNom(1);
            //string nom2 = DemanderNom(2);
             string nom1 = "Jean";
             string nom2 = "Paul";

             int age1 = DemanderAge(nom1);
             int age2 = DemanderAge(nom2);

             //float taille = 1.75f;

             AfficherInfosPersonne(nom1, age1, 1.75f);
             AfficherInfosPersonne(nom2, age2);
            
            


        }
    }
}