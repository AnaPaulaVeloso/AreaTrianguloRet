using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            double medidabase,medidaAltura,medidaArea;
            Console.Write("valor base.......:");
            medidabase = Convert.ToDouble(Console.ReadLine());

            Console.Write("valor altura.....:");
            medidaAltura = Convert.ToDouble(Console.ReadLine());
            medidaArea = (medidabase * medidaAltura)/2; 

            Console.WriteLine($"Área do Triângulo:{medidaArea}");


            
        }
    }
}
