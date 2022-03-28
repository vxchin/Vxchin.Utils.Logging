using Vxchin.Utils.Logging.Infrastructure;

namespace Vxchin.Utils.Logging
{
    /// <summary>
    /// 用于配置日志系统的配置器。
    /// </summary>
    public interface ILogConfigurator
    {
        /// <summary>
        /// 获取用于对日志系统的更多高级功能进行配置的配置器。
        /// </summary>
        /// <returns><see cref="ILogAdvancedConfigurator"/> 的实例。</returns>
        ILogAdvancedConfigurator Advanced();
    }
}