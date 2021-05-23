

namespace lab1.Services
{
    public interface ICalculate
    {
        int val1 { get; }
        int val2 { get; }

        int Plus();
        int Minus();
        int Divided();
        int Multiply();

       
    }
}
