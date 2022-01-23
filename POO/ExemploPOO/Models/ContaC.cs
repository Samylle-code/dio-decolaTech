namespace Conta
{
    public abstract class ContaC
    {
        protected double saldo;
        public abstract void Creditar(double valor);
        
        public void ExibirSaldo(){
            System.Console.WriteLine($"Seu saldo é: {saldo}");
        }
    }
}