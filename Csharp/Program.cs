using System;
using Primeiro; 
using Classes;
using Interface;
using Enum;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.mateus;
            Pessoas pessoa3 = (Pessoas)3; 
            
            Animal animal = new Animal();

            animal.nome = "Mateus";
            animal.nomeDono = "Willian";
            animal.Especie =  "cachorro";

            Pessoa person = new Pessoa();

            person.nome= "giovanna";
            person.Idade = 18;
            person.Estado = "SP";

            var person2 = new Pessoa();

            person2.nome= "Samylle";
            person2.Idade = 18;
            person2.Estado = "Bahia";

           
            
            var classe = new classe();
            var classe2 = new Segundo.classe();

            Console.WriteLine(pessoa1);
            Console.WriteLine(pessoa2);
            Console.WriteLine(pessoa3);
        }
    }
}
