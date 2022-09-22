using System;

namespace EscolaParanoa.Alunos
{
    /// <summary>
    /// Define um Estudante na Escola Paranoa.
    /// </summary>
    public class Estudante
    {
        /// <summary>
        /// Cria uma instância de Estudante com os Argumentos utilizados.
        /// </summary>
        /// <param name="nome">Representa o valor da propriedade <see cref="Nome"/>.</param>
        /// <param name="idade">Representa o valor da propriedade <see cref="Idade"/> e deve possuir o valor maior que 0</param>
        /// <exception cref="ArgumentException">Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="idade"/>.</exception>
        public Estudante(string nome, int idade)
        {
            if(idade <= 0)
            {
                throw new ArgumentException("A idade deve ser maior que 0");
            }

            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public double Media { get; private set; }
    }
}
