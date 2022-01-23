using System;
using Interfaces;

namespace Calculo
{
    public class Calculator : ICalculator
    {
        public int Plus (int num1, int num2) {
            return num1 + num2;
        }
        public int Divide(int num1, int num2) {
            return num1 / num2;
        }
        public int Multiply(int num1, int num2) {
            return num1 * num2;
        }
        public int Minus(int num1, int num2) {
            return num1 - num2;
        }

          
    }
}


