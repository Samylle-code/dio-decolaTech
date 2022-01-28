using System;
using System.Collections.Generic;
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
using direct;

namespace Name
{
  class Name
  {
    static void Main(string[] args){ 
      
      var  caminho = "C:/TrabalhoComArquivos";
      var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 3", "SubPastaTeste3");
      var caminhoArquivo = Path.Combine(caminho, "arquivo-texto-stream.txt");
      var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-texto.txt");
      var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
      var novoCaminhoArquivo = Path.Combine(caminho, "PastaTeste2", "arquivo-texto-stream.txt");

      var listString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
      var listStringC = new List<string> {"Linha 4", "Linha 5", "Linha 6"};

      FileHelper helper = new FileHelper();
      

      //helper.LerArquivosStream(caminhoArquivo);
      //helper.CriarArquivoTextoStream(caminhoArquivo, listString);
      //helper.AdicionarTextoStream(caminhoArquivo, listStringC);
      // helper.ListarArquivosDiretorios(caminho);
      //helper.CriarDirectory(caminhoPathCombine);
      //helper.ApagarDicerctory(caminhoPathCombine, true);
      //helper.CriarArquivoTexto(caminhoArquivo, "Olá, teste de arquivo txt!");
      //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo,false);
      //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
      
      // ICalculator calc = new Calculator();
      // System.Console.WriteLine(calc.Plus(10,20));

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
