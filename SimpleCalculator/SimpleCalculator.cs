using System.Reflection.Metadata.Ecma335;

namespace SimpleCalculatorDomain
{
    public class SimpleCalculator
    {
        private readonly INumberService numberService;

        public SimpleCalculator(INumberService numberService)
        {
            this.numberService = numberService;
        }

        public int Div()
        {
            return numberService.GetNumberA() / numberService.GetNumberB();
        }

        public int Sub(int a, int b)
        {

            return a - b;
        }

        public int Sum(int a, int b)
        { 
            return a + b;
        }

        public int Times(int a, int b)
        {
            return a * b;
        }
    }
}