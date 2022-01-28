namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        public void OrdenarBubbleSort(ref int[] array)
        {
            int temp = 0; 
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if(array[i] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;  
                    }
                }
            }
        }

        public void imprimirArray(int[] array)
        {

            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);
            // for (int i = 0; i < array.Length; i++)
            // {
            //     System.Console.WriteLine(array[i]);
            // }
        }

        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }
        public void CopiarArray(ref int[] array, ref int[] DestinoArray)
        {
            Array.Copy(array, DestinoArray, array.Length);
        }

        public bool Existe(int[] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }
        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }
        public int ObterValor(int[] array, int valor){
            return Array.Find(array, element => element == valor);
        }
        public int ObterIndice(int[] array, int valor){
            return Array.IndexOf(array,valor);
        }

        public void RedimensionarArray(ref int[] array, int novoTamanho){
            Array.Resize(ref array, novoTamanho);
        }

        public string[] ConverterParaArrayDeString(int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }
    }
}