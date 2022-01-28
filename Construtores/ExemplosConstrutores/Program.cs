using System;
using ExemplosConstrutores.Models;


namespace ExemplosConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args) 
        { 

            Matematica m = new Matematica(10,20);
            m.Calcula ();
            //Operacao op = Calculadora.Somar
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Diminuir;
            // op.Invoke(10,10);
            //op(10,10);

            // Data data = new();
            // // data.setMes(20);

            // data.Mes = 12;
            // //System.Console.WriteLine(data.Mes);

            // data.ApresentarMes();
            // // aluno p1 =  new aluno("teste","nome","disciplina");
            // // p1.Apresentar();


            // log log = log.getInstance();
            // log.PropriedadeLog = "Teste instancia";

            // log log2 = log.getInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            // Pessoa p1 = new Pessoa ();
            // p1.Apresentar();

         }
    }
}

