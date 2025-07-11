using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhaCorreta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SenhaC = 2811;
            Console.Write("Digite uma senha: ");
            int Senha = int.Parse(Console.ReadLine());
            while (Senha != SenhaC)
            {
                Console.WriteLine("SENHA INCORRETA");
                Console.Write("Tente novamente: ");
                Senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha Correta!");
        }
    }
}
