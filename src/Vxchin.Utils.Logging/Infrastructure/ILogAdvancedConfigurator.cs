using Microsoft.Extensions.Logging;

namespace Vxchin.Utils.Logging.Infrastructure
{
    /// <summary>
    /// 用于对日志系统的更多高级功能进行配置的配置器。
    /// </summary>
    public interface ILogAdvancedConfigurator
    {
        /// <summary>
        /// 获取基础的配置器。
        /// </summary>
        ILogConfigurator Configurator { get; }

        /// <summary>
        /// 指定 <see cref="Log"/> 使用给定的 <see cref="ILoggerFactory"/> 实例创建 <see cref="ILogger"/> 的实例。
        /// </summary>
        /// <param name="loggerFactory">给定的 <see cref="ILoggerFactory"/> 对象。</param>
        ILogAdvancedConfigurator UseFactory(ILoggerFactory loggerFactory);

        /// <summary>
        /// 指定 <see cref="Log"/> 使用给定的 <see cref="ILogAdapter"/> 实例进行从 <see cref="ILogger"/> 到 <see cref="ILog"/> 的转换。
        /// </summary>
        /// <param name="adapter">给定的 <see cref="ILogAdapter"/> 对象，指定 <see langword="null"/> 表示使用默认的 <see cref="ILogAdapter"/> 实现。</param>
        ILogAdvancedConfigurator UseAdapter(ILogAdapter adapter);
    }
}