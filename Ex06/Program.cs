using System;
using System.Collections.Generic;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 6. Escreva um programa que calcule a nota média de cada aluno e a média da turma. O
            programa deve receber o nome do aluno e a nota de cada bimestre (4 notas), ao
            informar no nome do aluno o valor “finalizar” o programa deve realizar os cálculos da
            média e apresentar na tela. */

            Dictionary<string, int> alunos = new Dictionary<string, int>();
            bool continua = true;
            int mediaTurma = 0;

            while (continua == true)
            {
                int mediaAluno = 0;
                Console.WriteLine("Nome do Aluno: (digite 'finalizar' para encerrar!)");
                string nomeAluno = Console.ReadLine();

                if (nomeAluno == "finalizar")
                {
                    continua = false;
                }
                else
                {
                    for(int i = 1; i <= 4; i++)
                    {
                        Console.WriteLine("Digite a nota do " + i + "° Bimestre:");
                        int notaAluno = int.Parse(Console.ReadLine());
                        mediaAluno += notaAluno;
                    }

                    mediaAluno /= 4;
                    mediaTurma += mediaAluno;
                    alunos.Add(nomeAluno, mediaAluno);
                }
            }

            foreach(var aluno in alunos)
            {
                Console.WriteLine("Aluno(a): "+aluno.Key+" - Média: "+aluno.Value);
            }

            if (alunos.Count != 0)
            {
                Console.WriteLine("Média da Turma: " + (mediaTurma / alunos.Count));
            }
        }
    }
}
