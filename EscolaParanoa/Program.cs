using EscolaParanoa.Alunos;
using Humanizer;
using System;

namespace EscolaParanoa
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindos a Escola Paranoá!!!");
            Console.WriteLine("------------------------------------------------------------------------");

            Estudante estudante1 = new Estudante("João", 5);
            Console.WriteLine("Estudante " + estudante1.Nome);


            // Tempo para o fim do ano letivo
            DateTime datafimAnoLetivo = new DateTime(2022, 12, 01);
            DateTime dataAtual = DateTime.Now;
            string mensagem = $"Tempo para o fim do ano letivo: {TimeSpanHumanizeExtensions.Humanize(datafimAnoLetivo - dataAtual)}";
            Console.WriteLine(mensagem);

            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Pressione uma Tecla para Terminar o sistema!");
            Console.ReadKey();
        }
    }
}
