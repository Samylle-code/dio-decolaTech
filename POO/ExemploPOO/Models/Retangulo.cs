using System;

namespace retangulo
{
    public class Retangulo
    {
        private double comprimento;
        private double altura;
        private bool valido;

        public void DefinirMedida(double comprimento, double altura)
        {
            if (comprimento > 0 && altura  > 0 ){
                this.comprimento = comprimento;
                this.altura = altura;
                valido = true; 
            }else{
                Console.WriteLine("valores invalidos");
            }
        }

        public double ObterArea()
        {
            if (valido){
               return comprimento * altura; 
            }
            else{
                System.Console.WriteLine("");
                return 0;
            }
        }
    }
}