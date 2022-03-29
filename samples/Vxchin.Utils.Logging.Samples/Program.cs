using Microsoft.Extensions.Logging;
using Vxchin.Utils.Logging.Samples.LibCore;
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
            var logger = Log.CreateLogger<Program>();

            // 3. 记录日志
            LoggingDemo.WriteLoggingMessages(logger);
            LoggingDemo.Calculate(logger);

            // 4. 关闭日志系统并进行必要的清理
            Log.Lifetime().Shutdown();
        }
    }
}