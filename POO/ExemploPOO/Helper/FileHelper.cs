using System.Collections.Generic;

namespace direct
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*",SearchOption.AllDirectories);
            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios(string caminho){
                var retornoArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);
                foreach (var retorno in retornoArquivos)
                {
                    System.Console.WriteLine(retorno);
                }
        }

        public void CriarDirectory(string caminho)
        {

            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);

        }

        public void ApagarDicerctory(string caminho, bool ApagarArquivos)
        {
            Directory.Delete(caminho, ApagarArquivos);
           
        }

        public void CriarArquivoTexto(string Caminho, string Conteudo){

            if (!File.Exists(Caminho))
            {
                File.WriteAllText(Caminho, Conteudo);
            }
            
        }
    
        public void CriarArquivoTextoStream (string caminho, List<string> conteudo )
        {
           using (var stream = File.CreateText(caminho))
           {
               foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
           }
        }

        public void AdicionarLinhas(string caminho, string conteudo)
        {
            File.AppendAllText(caminho,conteudo);
        }

        public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }
        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);
            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }

        public void LerArquivosStream(string caminho)
        {
            string linha = string.Empty;
            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }
        public void MoverArquivo (string caminho, string novocaminho, bool sobrescrever)
        {
            File.Move(caminho, novocaminho, sobrescrever);
        }

        public void CopiarArquivo (string caminho, string novocaminho, bool sobrescrever)
        {
                File.Copy(caminho, novocaminho, sobrescrever);
        }

        public void DeleteArquive(string caminho)
        {
            File.Delete(caminho);
        }
    }
}