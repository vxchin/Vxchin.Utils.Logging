using Microsoft.Extensions.Logging;
using Vxchin.Utils.Logging.Internal;

namespace Vxchin.Utils.Logging.Infrastructure
{
    /// <summary>
    /// 一组用于对日志系统进行高级设置的扩展方法。
    /// </summary>
    public static class LogAdvancedConfiguratorExtensions
    {
        /// <summary>
        /// 指定 <see cref="Log"/> 使用给定的 <see cref="ILoggerProvider"/> 实例创建 <see cref="ILogger"/> 的实例。
        /// </summary>
        /// <param name="configurator">配置器对象。</param>
        /// <param name="provider">给定的 <see cref="ILoggerFactory"/> 对象。</param>
        public static ILogAdvancedConfigurator UseProvider(this ILogAdvancedConfigurator configurator, ILoggerProvider provider)
        {
            return configurator.UseFactory(SimpleLoggerFactory.Create(provider));
        }
    }
}
