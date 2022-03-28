using Microsoft.Extensions.Logging;

namespace Vxchin.Utils.Logging.Internal
{
    internal static class LoggerToLogExtensions
    {
        /// <summary>
        /// 使用给定的 <see cref="ILogger"/> 对象创建一个 <see cref="ILog"/> 的实例。
        /// </summary>
        /// <param name="logger">给定的 <see cref="ILogger"/> 对象。</param>
        /// <param name="options">保存各种选项的 <see cref="LogOptions"/> 实例。</param>
        /// <returns></returns>
        public static ILog ToLog(this ILogger logger, LogOptions options)
        {
            return options.LogAdapter.Adapt(logger);
        }
    }
}