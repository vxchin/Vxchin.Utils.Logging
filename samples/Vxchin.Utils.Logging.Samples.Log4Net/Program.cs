using Vxchin.Utils.Logging.Log4Net;
using Vxchin.Utils.Logging.Samples.LibCore;

namespace Vxchin.Utils.Logging.Samples.Log4Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 配置 log4net
            Log.GlobalConfig().UseLog4Net();

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