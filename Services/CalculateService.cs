using System;


namespace lab1.Services
{
    public class CalculateService : ICalculate
    {
        public int val1 { get; private set; }
        public int val2 { get; private set; }

        public CalculateService()
        {
            val1 = new Random().Next(0, 10);
            val2 = new Random().Next(0, 10);

        }

        public int Plus() => val1 + val2;
 

        public int Minus() =>  val1 - val2;
        

        public int Divided()
        {
            try
            {
                return val1 / val2;
            }
            catch (DivideByZeroException)
            {
                return -1;
            }
        }

        public int Multiply() => val1 * val2;
        

    }
}
