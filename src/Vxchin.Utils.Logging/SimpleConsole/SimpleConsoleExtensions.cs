using System;
using Microsoft.Extensions.Logging;

namespace Vxchin.Utils.Logging.SimpleConsole
{
    /// <summary>
    /// 一组用于启用 <see cref="SimpleConsoleLogger"/> 的扩展方法。
    /// </summary>
    public static class SimpleConsoleLoggerExtensions
    {
        /// <summary>
        /// 配置日志系统使用 <see cref="SimpleConsoleLogger"/> 将日志消息输出到命令行。
        /// </summary>
        /// <param name="configurator"><see cref="ILogConfigurator"/> 的实例。</param>
        /// <param name="printStackTrace">指示是否输出异常的调用堆栈。</param>
        /// <returns><see cref="ILogConfigurator"/> 的实例。</returns>
        public static ILogConfigurator UseSimpleConsole(
            this ILogConfigurator configurator, bool printStackTrace = false)
        {
            return configurator.UseSimpleConsole(options => options.PrintStackTrace = printStackTrace);
        }

        /// <summary>
        /// 配置日志系统使用 <see cref="SimpleConsoleLogger"/> 将日志消息输出到命令行。
        /// </summary>
        /// <param name="configurator"><see cref="ILogConfigurator"/> 的实例。</param>
        /// <param name="minimumLogLevel">记录器记录的最低日志级别。</param>
        /// <param name="printStackTrace">指示是否输出异常的调用堆栈。</param>
        /// <returns><see cref="ILogConfigurator"/> 的实例。</returns>
        /// <exception cref="ArgumentException">当指定的日志级别不是有效的 <see cref="LogLevel"/> 时抛出。</exception>
        public static ILogConfigurator UseSimpleConsole(
            this ILogConfigurator configurator, LogLevel minimumLogLevel, bool printStackTrace = false)
        {
            return configurator.UseSimpleConsole(options =>
            {
                options.MinimumLogLevel = minimumLogLevel;
                options.PrintStackTrace = printStackTrace;
            });
        }

        /// <summary>
        /// 配置日志系统使用 <see cref="SimpleConsoleLogger"/> 将日志消息输出到命令行。
        /// </summary>
        /// <param name="configurator"><see cref="ILogConfigurator"/> 的实例。</param>
        /// <param name="configureOptions">用于配置 <see cref="SimpleConsoleLogger"/> 相关选项的操作。</param>
        /// <returns><see cref="ILogConfigurator"/> 的实例。</returns>
        public static ILogConfigurator UseSimpleConsole(
            this ILogConfigurator configurator, Action<SimpleConsoleOptions> configureOptions)
        {
            var options = new SimpleConsoleOptions();
            configureOptions?.Invoke(options);
            return configurator.UseSimpleConsole(options);
        }

        /// <summary>
        /// 配置日志系统使用 <see cref="SimpleConsoleLogger"/> 将日志消息输出到命令行。
        /// </summary>
        /// <param name="configurator"><see cref="ILogConfigurator"/> 的实例。</param>
        /// <param name="options">与 <see cref="SimpleConsoleLogger"/> 有关的选项。</param>
        /// <returns><see cref="ILogConfigurator"/> 的实例。</returns>
        public static ILogConfigurator UseSimpleConsole(
            this ILogConfigurator configurator, SimpleConsoleOptions options)
        {
            return configurator.Advanced().UseFactory(new SimpleConsoleLoggerFactory(options)).Configurator;
        }
    }
}