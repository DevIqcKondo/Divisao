using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            double n=0;
            double d=0;
            double f=0;
            
            Console.WriteLine("--------------------");
            Console.WriteLine("Dividindo os números");
            Console.WriteLine("--------------------");

            Console.ForegroundColor=ConsoleColor.Red;
            Console.Write("Digite um número: ");
            Console.ForegroundColor=ConsoleColor.Blue;
            n=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.ForegroundColor=ConsoleColor.Red;
            Console.Write("Digite outro número: ");
            Console.ForegroundColor=ConsoleColor.Blue;
            d=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            
            Console.WriteLine("Pressione qualquer tecla para ver o resultado.");
            Console.ReadKey();
            f=(n/d);

            if(d==0){
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("Não é possível dividir por zero.");
                Console.ResetColor();

            }if(n==0){
                Console.ForegroundColor=ConsoleColor.Magenta;
                Console.WriteLine(""+n+" dividido por "+d+" é "+f+" ");
                Console.ResetColor();

            }if(n>0){
                Console.ForegroundColor=ConsoleColor.Yellow;
                Console.WriteLine(""+n+" dividido por "+d+" é "+f+" ");
                Console.ResetColor();
            }
            Console.Beep();
        }
    }
}
