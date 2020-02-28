using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aumento_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double Salario = 0.00f;
            double Reajuste;
            int Porcetagen;

            Salario = double.Parse(Console.ReadLine());


            if (Salario <= 400.00 && Salario >= 0)
            {
                Porcetagen = 15;
                Reajuste = Salario * 0.15;
                Salario = Salario + Reajuste;
                Console.WriteLine("Novo salario: " + Salario.ToString("#0.00"));
                Console.WriteLine("Reajuste ganho: " + Reajuste.ToString("#0.00"));
                Console.WriteLine("Em percentual: " + Porcetagen + " % ");
            }
            else if (Salario <= 800.00 && Salario >= 400.01)
            {
                Porcetagen = 12;
                Reajuste = Salario * 0.12;
                Salario = Salario + Reajuste;
                Console.WriteLine("Novo salario: " + Salario.ToString("#0.00"));
                Console.WriteLine("Reajuste ganho: " + Reajuste.ToString("#0.00"));
                Console.WriteLine("Em percentual: " + Porcetagen + " % ");
            }
            else if (Salario <= 1200.00 && Salario >= 800.01)
            {
                Porcetagen = 10;
                Reajuste = Salario * 0.10;
                Salario = Salario + Reajuste;
                Console.WriteLine("Novo salario: " + Salario.ToString("#0.00"));
                Console.WriteLine("Reajuste ganho: " + Reajuste.ToString("#0.00"));
                Console.WriteLine("Em percentual: " + Porcetagen + " % ");
            }
            else if (Salario <= 2000.00 && Salario >= 1200.01)
            {
                Porcetagen = 7;
                Reajuste = Salario * 0.07;
                Salario = Salario + Reajuste;
                Console.WriteLine("Novo salario: " + Salario.ToString("#0.00"));
                Console.WriteLine("Reajuste ganho: " + Reajuste.ToString("#0.00"));
                Console.WriteLine("Em percentual: " + Porcetagen + " % ");
            }
            else if (Salario >= 2000.01)
            {
                Porcetagen = 4;
                Reajuste = Salario * 0.04;
                Salario = Salario + Reajuste;
                Console.WriteLine("Novo salario: " + Salario.ToString("#0.00"));
                Console.WriteLine("Reajuste ganho: " + Reajuste.ToString("#0.00"));
                Console.WriteLine("Em percentual: " + Porcetagen + " % ");
            }




            Console.ReadKey();
        }
    }
}
