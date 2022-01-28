namespace ExemplosConstrutores.Models
{
    public class Calculadora
    {
        public delegate void DelegateCalculadora();

        public static event DelegateCalculadora EventoCalculadora;
        public static void Somar(int x, int y){
            if (EventoCalculadora != null)
            {
               System.Console.WriteLine($"Adição: {x+y}");
               EventoCalculadora(); //Executa
            } else{
                System.Console.WriteLine("nenhum inscrito");
            }
            
        }
        public static void Diminuir(int x, int y){
            if (EventoCalculadora != null)
            {
              System.Console.WriteLine($"Substração: {x - y}");
               EventoCalculadora(); //Executa
            } else{
                System.Console.WriteLine("nenhum inscrito");
            }
            
        }
    }
}