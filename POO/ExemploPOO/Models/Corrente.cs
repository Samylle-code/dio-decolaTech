
using Conta;

namespace Correntes
{
    public class Corrente: ContaC
    {
        public override void Creditar(double valor){
            base.saldo= valor; 
        }
    }
}