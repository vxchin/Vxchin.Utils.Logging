namespace Vxchin.Utils.Logging.Samples.LibCalc
{
    public class Calculator : ICalculator
    {
        private readonly ILog _log = Log.CreateLogger<Calculator>();

        public decimal Add(decimal x, decimal y)
        {
            LogCalculating(x, y, '+');
            return x + y;
        }

        public decimal Subtract(decimal x, decimal y)
        {
            LogCalculating(x, y, '-');
            return x - y;
        }

        public decimal Multiply(decimal x, decimal y)
        {
            LogCalculating(x, y, '*');
            return x * y;
        }

        public decimal Divide(decimal x, decimal y)
        {
            LogCalculating(x, y, '/');
            return x / y;
        }

        private void LogCalculating(decimal x, decimal y, char op)
        {
            _log.Debug("Calculating {X} {Operator} {Y}", x, op, y);
        }
    }
}