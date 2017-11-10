using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double dblVal1,dblVal2,dblRep = 0;
            bool bSaisieOpCorrect = true;
            Console.WriteLine("Calculatrice");
            Console.WriteLine("----------------------------");
            // Saisie des opérands avec vérification de ces dernières
            Console.Write("Saisire la 1ère valeur : ");
            while(!double.TryParse(Console.ReadLine(), out dblVal1))
            {
                Console.Write("Saisire à nouveau la 1ère valeur : ");
            }

            Console.Write("Saisire la 2ème valeur : ");
            while (!double.TryParse(Console.ReadLine(), out dblVal2))
            {
                Console.Write("Saisire à nouveau la 2ème valeur : ");
            }
            Console.Write("Opération à choix [+ - * / ^] :");
            while (bSaisieOpCorrect)
            {
                bSaisieOpCorrect = false;
                string strOp = Console.ReadLine();
                switch (strOp)
                {
                    case "+":
                        dblRep = dblVal1 + dblVal2;
                        break;
                    case "-":
                        dblRep = dblVal1 - dblVal2;
                        break;
                    case "*":
                        dblRep = dblVal1 * dblVal2;
                        break;
                    case "/":
                        dblRep = dblVal1 / dblVal2;
                        break;
                    case "^":
                        dblRep = Math.Pow(dblVal1, dblVal2);
                        break;
                    default:
                        Console.WriteLine("Opération non reconnue par le système");
                        Console.Write("Veuillez saisir à nouveau l'opérateur [+ - * / ^] : ");
                        bSaisieOpCorrect = true;
                        break;
                }
            }

            Console.WriteLine(dblRep);
            Console.ReadKey();
        }
    }
}
