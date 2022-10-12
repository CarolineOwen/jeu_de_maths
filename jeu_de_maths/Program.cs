// See https://aka.ms/new-console-template for more information
static bool PoserQuestion(int min, int max)
    {
    int reponse_nombre = 0;
    Random rand = new Random();
    while(true)//boucler de manière infini
    {
        int a = rand.Next(min, max+1);
        int b = rand.Next(min, max+1);
        Console.WriteLine($"quel est le résultat de {a} + {b} ?");
        string reponse = Console.ReadLine();

        try
        {
            reponse_nombre = int.Parse(reponse);
            if (reponse_nombre == a + b)
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

int min = 1;
int max = 10;

bool bonneReponse = PoserQuestion(min, max);
if (bonneReponse)
{
    Console.WriteLine("Bonne réponse");
}
else
{
    Console.WriteLine("mauvaise réponse");
}
