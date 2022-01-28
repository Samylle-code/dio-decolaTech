namespace ExemplosConstrutores.Models
{
    public class aluno : Pessoa
    {
        public aluno(string nome, string sobrenome, string disciplina) : base (nome, sobrenome)
        {
            System.Console.WriteLine("construtor classe aluno");
        }
        
    }
}