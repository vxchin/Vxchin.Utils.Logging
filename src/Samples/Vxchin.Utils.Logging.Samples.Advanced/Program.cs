using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Vxchin.Utils.Logging.Samples.LibCore;

namespace Vxchin.Utils.Logging.Samples.Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 配置并使用自定义的 ILoggerFactory 对象。
            Log.GlobalConfig().Advanced().UseFactory(CreateLoggerFactory());
            // 或者，使用从依赖注入系统中获取的 ILoggerFactory 对象。
            // Log.GlobalConfig().Advanced().UseFactory(CreateLoggerFactoryWithDependencyInjection());

            // 2. 创建 ILog 的实例
            var logger = Log.CreateLogger<Program>();

            // 3. 记录日志
            LoggingDemo.WriteLoggingMessages(logger);
            LoggingDemo.Calculate(logger);

            // 4. 关闭日志系统并进行必要的清理
            Log.Lifetime().Shutdown();
        }

        private static ILoggerFactory CreateLoggerFactory()
        {
            return LoggerFactory.Create(logging => { logging.AddConsole().SetMinimumLevel(LogLevel.Trace); });
        }

        private static ILoggerFactory CreateLoggerFactoryWithDependencyInjection()
        {
            return CreateServiceProvider().GetRequiredService<ILoggerFactory>();

            IServiceProvider CreateServiceProvider() => new ServiceCollection()
                .AddLogging(logging => logging.AddConsole().SetMinimumLevel(LogLevel.Trace))
                .BuildServiceProvider();
        }
    }
}