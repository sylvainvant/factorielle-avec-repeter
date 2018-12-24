using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorielle_avec_repeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration variable
            double n;
            string saissie;
            double resultat = 1;
            //debut
            Console.WriteLine("entrez la valeur n a calculer:");
            saissie = Console.ReadLine();
            n = Convert.ToDouble(saissie);

            if (n == 0 || n == 1)
            {
                Console.WriteLine("le factorielle de n avec repeter est:" + resultat);
            }
            else
            {
                do
                {
                    resultat = (resultat * n);
                    n = n - 1;

                } while (n > 1);
                Console.WriteLine("Le resultat aver pour est:" + resultat);

            }
            // permet de conserver affichage consol
            Console.ReadLine();

        }





    }

}
