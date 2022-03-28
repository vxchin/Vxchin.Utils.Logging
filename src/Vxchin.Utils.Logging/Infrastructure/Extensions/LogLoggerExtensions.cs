using System;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Vxchin.Utils.Logging.Infrastructure
{
    /// <summary>
    /// 一组用于在 <see cref="ILog"/> 和 <see cref="ILogger"/> 的实例之间进行转换的扩展方法。
    /// </summary>
    public static class LogLoggerExtensions
    {
        /// <summary>
        /// 获取给定的 <see cref="ILog"/> 对象中包装的 <see cref="ILogger"/> 实例。
        /// </summary>
        /// <param name="log"></param>
        /// <returns><see cref="ILogger"/> 对象。如果给定的 ILog 不是 <see cref="ILoggerWrapper"/> 的实例，则返回 <see langword="null"/>。</returns>
        public static ILogger GetLogger(this ILog log)
        {
            return log is ILoggerWrapper wrapper ? wrapper.Logger : NullLogger.Instance;
        }

        internal static bool IsEnabled(this ILog log, LogLevel logLevel)
        {
            return GetLogger(log).IsEnabled(logLevel);
        }

        internal static void Log(this ILog log, LogLevel logLevel, [StructuredMessageTemplate] string message,
            params object[] args)
        {
            log.Log(logLevel, null, message, args);
        }

        internal static void Log(this ILog log, LogLevel logLevel, Exception exception,
            [StructuredMessageTemplate] string message, params object[] args)
        {
            // ReSharper disable once TemplateIsNotCompileTimeConstantProblem
            log.GetLogger().Log(logLevel, exception, message, args);
        }
    }
}