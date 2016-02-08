namespace NUnit301
{
    public class ClassToExcludeFromCoverage
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Minus(double a, double b)
        {
            return a - b; 
        }

        public double Multiply(double a, double b)
        {
            return a*b;
        }

        public double Divide(double a, double b)
        {
            return a/b;
        }
    }
}
