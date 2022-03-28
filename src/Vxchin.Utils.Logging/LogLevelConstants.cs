namespace Vxchin.Utils.Logging
{
    /// <summary>
    /// 一组表示日志级别的常量。改组常量与 <see cref="Microsoft.Extensions.Logging.LogLevel"/> 的值一一对应。
    /// </summary>
    public static class LogLevelConstants
    {
        /// <summary>包含最详细消息的日志。 这些消息可能包含敏感的应用程序数据。 这些消息在默认情况下被禁用，不应在生产环境中启用。</summary>
        public static string Trace = nameof(Trace);

        /// <summary>开发期间用于交互式调查的日志。 这些日志应该主要包含对调试有用的信息，并且没有长期价值。</summary>
        public static string Debug = nameof(Debug);

        /// <summary>跟踪应用程序一般流程的日志。 这些日志应该具有长期价值。</summary>
        public static string Information = nameof(Information);

        /// <summary>突出显示应用程序流中的异常或意外事件的日志，但不会导致应用程序执行停止。</summary>
        public static string Warning = nameof(Warning);

        /// <summary>突出显示当前执行流程因失败而停止的日志。 这些应该指示当前活动中的故障，而不是应用程序范围的故障。</summary>
        public static string Error = nameof(Error);

        /// <summary>描述不可恢复的应用程序或系统崩溃或需要立即关注的灾难性故障的日志。</summary>
        public static string Critical = nameof(Critical);

        /// <summary>不用于写入日志消息。 指定日志类别不应写入任何消息。</summary>
        public static string None = nameof(None);
    }
}