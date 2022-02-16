using System;
using System.Collections.Generic;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 11.Faça um programa que dada o nome e idade de um nadador, classifique - o em uma das
            seguintes categorias:
            -Infantil A = 5 a 7 anos
            - Infantil B = 8 a 11 anos
            - Juvenil A = 12 a 13 anos
            - Juvenil B = 14 a 17 anos
            - Adultos = Maiores de 18 anos
            Ao final apresente as categorias e o nome dos nadadores e idade de cada uma dentro
            das suas respectivas categorias de natação. */

            Dictionary<string, int> infantilA = new Dictionary<string, int>();
            Dictionary<string, int> infantilB = new Dictionary<string, int>();
            Dictionary<string, int> juvenilA = new Dictionary<string, int>();
            Dictionary<string, int> juvenilB = new Dictionary<string, int>();
            Dictionary<string, int> adultos = new Dictionary<string, int>();
            bool continua = true;

            while (continua == true)
            {
                Console.WriteLine("Nome do Nadador: (digite 'finalizar' para encerrar!)");
                string nomeNadador = Console.ReadLine();

                if (nomeNadador == "finalizar")
                {
                    continua = false;
                }
                else
                {
                    Console.Write("Idade do Nadador: ");
                    int idadeNadador = int.Parse(Console.ReadLine());

                    if (idadeNadador >= 5 & idadeNadador <= 7)
                    {
                        infantilA.Add(nomeNadador, idadeNadador);
                    }
                    else if (idadeNadador >= 8 & idadeNadador <= 11)
                    {
                        infantilB.Add(nomeNadador, idadeNadador);
                    }
                    else if (idadeNadador == 12 | idadeNadador == 13)
                    {
                        juvenilA.Add(nomeNadador, idadeNadador);
                    }
                    else if (idadeNadador >= 14 & idadeNadador <= 17)
                    {
                        juvenilB.Add(nomeNadador, idadeNadador);
                    }
                    else if(idadeNadador>=18)
                    {
                        adultos.Add(nomeNadador, idadeNadador);
                    }
                    else
                    {
                        Console.WriteLine("Idade Não Permitida!");
                    }
                }
            }

            if (infantilA.Count != 0)
            {
                foreach (var nadadores in infantilA)
                {
                    Console.WriteLine("Categoria Infantil A - Nadador(a): " + nadadores.Key + " - " + nadadores.Value+" anos.");
                }
            }

            if (infantilB.Count != 0)
            {
                foreach (var nadadores in infantilB)
                {
                    Console.WriteLine("Categoria Infantil B - Nadador(a): " + nadadores.Key + " - " + nadadores.Value + " anos.");
                }
            }

            if (juvenilA.Count != 0)
            {
                foreach (var nadadores in juvenilA)
                {
                    Console.WriteLine("Categoria Juvenil A - Nadador(a): " + nadadores.Key + " - " + nadadores.Value + " anos.");
                }
            }

            if (juvenilB.Count != 0)
            {
                foreach (var nadadores in juvenilB)
                {
                    Console.WriteLine("Categoria Juvenil B - Nadador(a): " + nadadores.Key + " - " + nadadores.Value + " anos.");
                }
            }

            if (adultos.Count != 0)
            {
                foreach (var nadadores in adultos)
                {
                    Console.WriteLine("Categoria Adultos - Nadador(a): " + nadadores.Key + " - " + nadadores.Value + " anos.");
                }
            }
        }
    }
}
