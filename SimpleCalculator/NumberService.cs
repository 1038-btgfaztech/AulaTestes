namespace SimpleCalculatorDomain
{
    public class NumberService : INumberService
    {

        public int GetNumberA()
        {
            var x = new Random();

            return x.Next(-10, 10);
        }

        public int GetNumberB()
        {
            var x = new Random();

            return x.Next(-100, 100);
        }
    }
}
