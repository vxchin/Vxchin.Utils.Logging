using Microsoft.Extensions.Logging;

namespace Vxchin.Utils.Logging.SimpleConsole
{
    /// <summary>
    /// 与 SimpleConsole 有关的选项。
    /// </summary>
    public class SimpleConsoleOptions
    {
        /// <summary>
        /// 指定要打印的最小日志级别。默认为 <see cref="LogLevel.Information"/>。
        /// </summary>
        public LogLevel MinimumLogLevel { get; set; } = LogLevel.Information;

        /// <summary>
        /// 指定是否打印异常的堆栈跟踪。默认为 <see langword="false"/>
        /// </summary>
        public bool PrintStackTrace { get; set; }

        /// <summary>
        /// 指定用于将日志级别转换为字符串的格式化器。
        /// </summary>
        public ILogLevelConverter<string> LogLevelConverter { get; set; } = new LogLevelStringConverter();
    }
}