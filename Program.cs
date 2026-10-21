namespace Braquage_train;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes :
           - Utiliser une première boucle pour parcourir les quatre wagons.
           - Utiliser une deuxième boucle à l'intérieur pour parcourir les trois coffres de chaque wagon.
           - Afficher chaque coffre inspecté avec son numéro de wagon.
           - Compter le nombre total de coffres inspectés.
           
           Exemple :
               Inspection des 4 wagons du train
               Wagon 1 - Coffre 1 inspecté
               Wagon 1 - Coffre 2 inspecté
               Wagon 1 - Coffre 3 inspecté
               Wagon 2 - Coffre 1 inspecté
               ...
               Total : 12 coffres inspectés.
            
            BONUS 1 : permettre à l'utilisateur de choisir le nombre de wagons
            BONUS 2 : enregistrer l'ensemble du butin trouvé et l'afficher à la fin
         */
       
        int totalEx1 = 0;
        Console.WriteLine("Inspection des 4 wagons du train");

        for (int i = 1; i < 5; i++)
        {
            for (int j = 1; j < 4; j++)
            {
                Console.WriteLine("Wagon" + i + " - Coffre " + j + " inspecté");
                totalEx1++;
            }
            
        }Console.WriteLine("TOTAL : " + totalEx1 + " coffres inspectés");
        
        
        int totalEx2 = 0;
        Console.WriteLine("Entrez le nombre de wagons");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inspection des " + number + " wagons du train");

        for (int i = 1; i < (number + 1); i++)
        {
            for (int j = 1; j < 4; j++)
            {
                Console.WriteLine("Wagon" + i + " - Coffre " + j + " inspecté");
                totalEx2++;
            }
        }
        Console.WriteLine("TOTAL : " + totalEx2 + " coffres inspectés");
        
    }
    } 