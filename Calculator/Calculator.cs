namespace Calculator
{
    public class Calculator : ICalculator
    {
        public int Sum(int n1, int n2) =>
            n1 + n2;
        public int Multiplication(int n1, int n2) =>
            n1 * n2;
        public int Division(int n1, int n2) => 
            n1 / n2;
        public int Subtraction(int n1, int n2) =>
            n1-n2;
    }
}
