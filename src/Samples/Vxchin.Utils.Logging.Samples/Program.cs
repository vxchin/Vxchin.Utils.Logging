using System;
using Microsoft.Extensions.Logging;
using Vxchin.Utils.Logging.Samples.LibCalc;
using Vxchin.Utils.Logging.SimpleConsole;

namespace Vxchin.Utils.Logging.Samples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 可选的配置
            Log.GlobalConfig().UseSimpleConsole(LogLevel.Trace, printStackTrace: true);

            // 2. 创建 ILog 的实例
            var log = Log.CreateLogger<Program>();

            // 3. 记录日志
            log.Trace("This is a trace message");
            log.Debug("This is a debug message");
            log.Info("This is a info message");
            log.Warn("This is a warning message");
            log.Error(new InvalidOperationException(), "This is a error message");

            var calculator = new Calculator();
            var a = 3;
            var b = 4;
            var sum = calculator.Add(a, b);
            log.Info("{A} + {B} = {Sum}", a, b, sum);

            try
            {
                _ = calculator.Divide(1, 0);
            }
            catch (Exception ex)
            {
                log.Critical(ex, "This is a critical message");
            }

            // 4. 关闭日志系统并进行必要的清理
            Log.Lifetime().Shutdown();
        }
    }
}