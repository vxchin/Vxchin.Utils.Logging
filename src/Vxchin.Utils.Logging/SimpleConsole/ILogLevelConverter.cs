using Microsoft.Extensions.Logging;

namespace Vxchin.Utils.Logging.SimpleConsole
{
    /// <summary>
    /// 用于对 <see cref="LogLevel"/> 类型的值进行转换的转换器。
    /// </summary>
    public interface ILogLevelConverter<out T>
    {
        /// <summary>
        /// 将 <see cref="LogLevel"/> 类型的值转换为字符串。
        /// </summary>
        /// <param name="logLevel"><see cref="LogLevel"/> 类型的值。</param>
        /// <returns>转换后的结果。</returns>
        T Convert(LogLevel logLevel);
    }
}