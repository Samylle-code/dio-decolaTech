using System;
using Revisao;
using Media;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAlunos = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X"){
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do seu aluno");
                        var aluno = new Aluno();
                        aluno.nome = Console.ReadLine();

                        Console.WriteLine("informe a nota do aluno");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.nota = nota;
                        } 
                        else {
                            throw new ArgumentException("O valor da nota precisa ser decimal");
                        }
                        // var nota = decimal.Parse(Console.ReadLine());
                        // aluno.nota = nota;
                        alunos[indiceAlunos]=aluno;
                        indiceAlunos++;

                        break;

                    case "2":
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.nome)){
                                Console.WriteLine($"Aluno: {a.nome},  nota: {a.nota}");
                            }
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var numerosAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].nome))
                            {
                                notaTotal = notaTotal + alunos[i].nota; 
                                numerosAlunos++;
                            }
                        }
                        var MediaGeral = notaTotal / numerosAlunos;
                        Conceito ConceitoGeral;
                        if (MediaGeral < 2 ){

                            ConceitoGeral = Conceito.E;

                        }else if(MediaGeral < 4 ){

                            ConceitoGeral = Conceito.D;
                        
                        }else if(MediaGeral < 6 ){

                            ConceitoGeral = Conceito.C;
                        
                        }else if(MediaGeral < 8 ){

                            ConceitoGeral = Conceito.B;

                        }else{
                            ConceitoGeral = Conceito.A;
                        }
            

                        Console.WriteLine($"MÉDIA GERAL: {MediaGeral} - CONCEITO: {ConceitoGeral}");
                    break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("Informe o que quer fazer");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }   

    }

   
}
