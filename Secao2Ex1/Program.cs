using System;

namespace Secao2Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeUsuario;
            byte idadeUsuario;
            int anoNascimentoUsuario;
            int anoAtual = DateTime.Now.Year;

            Console.WriteLine("Olá, Qual o seu nome?");
            nomeUsuario = Console.ReadLine();

            Console.WriteLine("E sua idade?");
            idadeUsuario = Convert.ToByte(Console.ReadLine());

            anoNascimentoUsuario = anoAtual - idadeUsuario;

            Console.WriteLine(nomeUsuario + " você nasceu aproximadamente em: " + anoNascimentoUsuario);
        }
    }
}
