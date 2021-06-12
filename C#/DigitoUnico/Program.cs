using System;
using DigitoUnico.Entities;

namespace DigitoUnico
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            UnicDigit teste = new UnicDigit();

            Console.Write("Digite o valor de n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de k: ");
            k = int.Parse(Console.ReadLine());
            int num = teste.DigitUnic(teste.NKP(n, k));
            while(num.ToString().Length != 1)
            {
                num = teste.DigitUnic(num);
            }
            Console.WriteLine("n = " + n + " - k = " + k + " - P = " + teste.P);
            Console.WriteLine("Digito unico de P = " + num);
        }
    }
}
