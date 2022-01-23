using System;
using EstudoObjeto;
using retangulo;
using Alunos;
using Professores; 
using Calculo;
using Conta;
using Correntes;
using Diretoria;
using Rede;
using Interfaces;

namespace Name
{
  class Name
  {
    static void Main(string[] args){ 

      ICalculator calc = new Calculator();
      System.Console.WriteLine(calc.Plus(10,20));

      // Computador comp = new Computador();
      // System.Console.WriteLine(comp.ToString());

      // Corrente c = new Corrente();
      // c.Creditar(100);
      // c.ExibirSaldo();

      // Calculadora calc = new Calculadora();
      // Console.WriteLine("Resultado da Primeira soma é .... " + calc.Somar(10,10));
      // Console.WriteLine("Resultado da Primeira soma é .... " + calc.Somar(10,10,10));


        // Aluno p1 = new Aluno();
        // p1.Nota = 10;
        // p1.nome = "Bob";
        // p1.Idade = 20;
        // p1.Documento = "12345";
        // p1.Apresentar();


        // Retangulo r = new Retangulo();
        // r.DefinirMedida(30,30);
        // Console.WriteLine($"a Area{r.ObterArea()}");

          // Pessoa p1 = new Pessoa();

          // p1.nome = "bob";
          // p1.Idade = 20;

          // p1.Apresentar();

         
    }
  }
}
