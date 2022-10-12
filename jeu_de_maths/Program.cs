// See https://aka.ms/new-console-template for more information

namespace jeu_de_maths
{
    class Program
    {
        enum e_Operateur
        {
            ADDITION = 1,
            MULTIPLICATION = 2,
            SOUSTRACTION = 3
        }


        static bool PoserQuestion(int min, int max)
        {
            int reponse_nombre = 0;
            Random rand = new Random();
            while (true)//boucler de manière infini
            {
                int a = rand.Next(min, max + 1);
                int b = rand.Next(min, max + 1);
                e_Operateur o = (e_Operateur)rand.Next(1, 4);
                int resultatAttendu = 0;

                switch(o)
                {
                    case e_Operateur.ADDITION:
                        Console.WriteLine($"quel est le résultat de {a} + {b} ?");
                        resultatAttendu = a + b;
                        break;
                    case e_Operateur.MULTIPLICATION:
                        Console.WriteLine($"quel est le résultat de {a} * {b} ?");
                        resultatAttendu = b * a;
                        break;
                    case e_Operateur.SOUSTRACTION:
                        Console.WriteLine($"quel est le résultat de {a} - {b} ?");
                        resultatAttendu = a - b;
                        break;
                }
                
              

                string reponse = Console.ReadLine();

                try
                {
                    reponse_nombre = int.Parse(reponse);
                    if (reponse_nombre == resultatAttendu)
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                    Console.WriteLine("le format de réponse n'est pas valide");

                }
            }

        }

        static void Main(string[] args)
        {
            int min = 1;
            int max = 10;
            int nbQuestions = 4;
            int points = 0;

            for (int i = 0; i < nbQuestions; i++)
            {
                Console.WriteLine($"Question n° {i + 1} / {nbQuestions}");
                bool bonneReponse = PoserQuestion(min, max);
                if (bonneReponse)
                {
                    Console.WriteLine("Bonne réponse");
                    points++;
                }
                else
                {
                    Console.WriteLine("mauvaise réponse");
                }
                Console.WriteLine();

            }
            Console.WriteLine($"Vous avez obtenu {points} / {nbQuestions} points");
            int average = nbQuestions / 2;

            if (points == nbQuestions)
            {
                Console.WriteLine("Excelent");
            }
            else if (points == 0)
            {
                Console.WriteLine("Révisez vos Maths");
            }
            else if (points >= average)
            {
                Console.WriteLine("pas mal");
            }
            else
            {
                Console.WriteLine("peu mieux faire");
            }
        }
        
}
}

