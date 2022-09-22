namespace EscolaParanoa.Modelos.Funcionarios
{
    public abstract class Funcionario
    {
        public Funcionario(string nome, int re, string escola)
        {
            Nome = nome;
            RE = re;
            Escola = escola;
        }

        public string Nome { get; private set; }
        public int RE { get; private set; }
        public string Escola { get; private set; }
    }
}
