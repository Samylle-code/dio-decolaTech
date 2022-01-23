using System;
using EstudoObjeto;

namespace Alunos
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }
        public override void Apresentar()
        {
			Console.WriteLine($"Olá meu nome é {nome} e sou aluno de nota {Nota}.");
        }
	}
    
}

namespace Professores
{
    public class Professor : Pessoa {
    public double Salario { get; set; }
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {nome} e sou um professor, e ganho{Salario}");
        }
    }
}