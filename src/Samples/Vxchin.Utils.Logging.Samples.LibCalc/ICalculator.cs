namespace Vxchin.Utils.Logging.Samples.LibCalc
{
    public interface ICalculator
    {
        decimal Add(decimal x, decimal y);

        decimal Subtract(decimal x, decimal y);

        decimal Multiply(decimal x, decimal y);

        decimal Divide(decimal x, decimal y);
    }
}