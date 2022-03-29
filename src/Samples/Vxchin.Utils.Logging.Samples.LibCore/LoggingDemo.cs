using System;
using Vxchin.Utils.Logging.Samples.LibCalc;

namespace Vxchin.Utils.Logging.Samples.LibCore
{
    public static class LoggingDemo
    {
        public static void WriteLoggingMessages(ILog logger)
        {
            logger.Trace("This is a trace message");
            logger.Debug("This is a debug message");
            logger.Info("This is a info message");
            logger.Warn("This is a warning message");
            logger.Error(new InvalidOperationException(), "This is a error message");
        }

        public static void Calculate(ILog logger)
        {
            var calculator = new Calculator();
            var a = 3;
            var b = 4;
            var sum = calculator.Add(a, b);
            logger.Info("{A} + {B} = {Sum}", a, b, sum);

            try
            {
                _ = calculator.Divide(1, 0);
            }
            catch (Exception ex)
            {
                logger.Critical(ex, "This is a critical message");
            }
        }
    }
}
