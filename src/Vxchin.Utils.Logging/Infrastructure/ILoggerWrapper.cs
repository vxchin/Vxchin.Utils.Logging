using Microsoft.Extensions.Logging;

namespace Vxchin.Utils.Logging.Infrastructure
{
    /// <summary>
    /// 表示一个 <see cref="ILogger"/> 的包装器。
    /// </summary>
    public interface ILoggerWrapper
    {
        /// <summary>
        /// 获取包装器包装的 <see cref="ILogger"/> 实例。
        /// </summary>
        ILogger Logger { get; }
    }
}
