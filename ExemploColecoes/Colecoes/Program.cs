using System;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] { 6, 4, 2, 9, 3};
            int[] arrayCopia = new int[10];
            string[] arrayString = op.ConverterParaArrayDeString(array);
            // int valorProcurado = 4;

            System.Console.WriteLine($"Capacidade atual do array: {array.Length}");
            op.RedimensionarArray( ref array, array.Length * 2);
             System.Console.WriteLine($"Capacidade atual do array dps de redimensionar: {array.Length}");

            // int indice = op.ObterIndice(array, valorProcurado);

            // if (indice > -1)
            // {
            //     System.Console.WriteLine("O indice do elmento {0} é : {1}", valorProcurado, indice);
            // }
            // else
            
            // {
            //     System.Console.WriteLine("valor nao ecistente na array");
            // }



            // int valorAchado = op.ObterValor(array,valorProcurado);
            // if (valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }else{
            //     System.Console.WriteLine("nao encontrei");
            // }

            // bool TodosMaiorQue = op.TodosMaiorQue(array,valorProcurado);

            // if(TodosMaiorQue){
            //     System.Console.WriteLine("Todos os valores sao maior que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existe valores que não são maiores do que {0}",valorProcurado);
            // }

    
        //    bool existe = op.Existe(array,valorProcurado);

        //    if (existe)
        //    {
        //        System.Console.WriteLine("encontrei o valor");
        //    }else{
        //        System.Console.WriteLine("nao envontrei o valor");
        //    }
            // System.Console.WriteLine("Array original");
            // op.imprimirArray(array);

            // //op.OrdenarBubbleSort(ref array);
            // op.Ordenar(ref array);

            // System.Console.WriteLine("array ordenado");
            // op.imprimirArray(array);

            // System.Console.WriteLine("array antes da cópia");
            // op.imprimirArray(arrayCopia);

            // op.CopiarArray(ref array, ref arrayCopia);
            // System.Console.WriteLine("array depois da copia");
            // op.imprimirArray(arrayCopia);

        //     int[,] matriz = new int[4,2]
        //     {
        //    // matriz[0,0] = 5; 
        //         { 0, 0 },
        //         { 10, 20},
        //         { 50, 100},
        //         { 90, 200}
        //     };
        //     // para linha 
        //     for (int i = 0; i < matriz.GetLength(0); i++)
        //     {
        //      // para coluna
        //         for (int j = 0; j < matriz.GetLength(1); j++)
        //         {
        //             System.Console.WriteLine(matriz [i,j]);
        //         }
        //     }

        // // int[] arrayInteiros = new int[3];

        // arrayInteiros[0] = 10;
        // arrayInteiros[1] = 20;
        // arrayInteiros[2] = 30; 

        // for (int i = 0; i < arrayInteiros.Length; i++)
        // {
        //     System.Console.WriteLine(arrayInteiros[i]);
        // }
    

        // foreach (int item in arrayInteiros)
        // {
        //     System.Console.WriteLine(item);
        // }

        // }

    }
}
}
