using System;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using Vxchin.Utils.Logging.Infrastructure;

namespace Vxchin.Utils.Logging
{
    /// <summary>
    /// 用于使用 <see cref="ILog"/> 进行日志记录操作的一组扩展方法。
    /// </summary>
    public static class LogExtensions
    {
        #region Trace

        /// <summary>
        /// 格式化并写入一条不带参数的跟踪日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">要记录的日志消息。</param>
        public static void Trace(this ILog log, [StructuredMessageTemplate] string message)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, message);
        }

        /// <summary>
        /// 格式化并写入一条具有一个参数的跟踪日志消息。
        /// </summary>
        /// <typeparam name="T">要格式化的对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg">要格式化的对象。</param>
        public static void Trace<T>(this ILog log, [StructuredMessageTemplate] string message, T arg)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, message, arg);
        }

        /// <summary>
        /// 格式化并写入一条具有两个参数的跟踪日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        public static void Trace<T1, T2>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, message, arg1, arg2);
        }

        /// <summary>
        /// 格式化并写入一条具有三个参数的跟踪日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        public static void Trace<T1, T2, T3>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, message, arg1, arg2, arg3);
        }

        /// <summary>
        /// 格式化并写入一条具有四个参数的跟踪日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        public static void Trace<T1, T2, T3, T4>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, message, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 格式化并写入一条具有五个参数的跟踪日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        public static void Trace<T1, T2, T3, T4, T5>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, message, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 格式化并写入一条具有六个参数的跟踪日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        public static void Trace<T1, T2, T3, T4, T5, T6>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3,
            T4 arg4, T5 arg5, T6 arg6)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, message, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 格式化并写入一条具有七个参数的跟踪日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        public static void Trace<T1, T2, T3, T4, T5, T6, T7>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3,
            T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 格式化并写入一条具有八个参数的跟踪日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <typeparam name="T8">要格式化的第八个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        /// <param name="arg8">要格式化的第八个对象。</param>
        public static void Trace<T1, T2, T3, T4, T5, T6, T7, T8>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 格式化并写入一条跟踪日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="args">一个对象数组，其中包含零个或多个要格式化的对象。</param>
        public static void Trace(this ILog log, [StructuredMessageTemplate] string message, params object[] args)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, message, args);
        }

        #endregion

        #region Debug

        /// <summary>
        /// 格式化并写入一条不带参数的调试日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">要记录的日志消息。</param>
        public static void Debug(this ILog log, [StructuredMessageTemplate] string message)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, message);
        }

        /// <summary>
        /// 格式化并写入一条具有一个参数的调试日志消息。
        /// </summary>
        /// <typeparam name="T">要格式化的对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg">要格式化的对象。</param>
        public static void Debug<T>(this ILog log, [StructuredMessageTemplate] string message, T arg)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, message, arg);
        }

        /// <summary>
        /// 格式化并写入一条具有两个参数的调试日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        public static void Debug<T1, T2>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, message, arg1, arg2);
        }

        /// <summary>
        /// 格式化并写入一条具有三个参数的调试日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        public static void Debug<T1, T2, T3>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, message, arg1, arg2, arg3);
        }

        /// <summary>
        /// 格式化并写入一条具有四个参数的调试日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        public static void Debug<T1, T2, T3, T4>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, message, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 格式化并写入一条具有五个参数的调试日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        public static void Debug<T1, T2, T3, T4, T5>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, message, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 格式化并写入一条具有六个参数的调试日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        public static void Debug<T1, T2, T3, T4, T5, T6>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3,
            T4 arg4, T5 arg5, T6 arg6)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, message, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 格式化并写入一条具有七个参数的调试日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        public static void Debug<T1, T2, T3, T4, T5, T6, T7>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3,
            T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 格式化并写入一条具有八个参数的调试日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <typeparam name="T8">要格式化的第八个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        /// <param name="arg8">要格式化的第八个对象。</param>
        public static void Debug<T1, T2, T3, T4, T5, T6, T7, T8>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 格式化并写入一条调试日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="args">一个对象数组，其中包含零个或多个要格式化的对象。</param>
        public static void Debug(this ILog log, [StructuredMessageTemplate] string message, params object[] args)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, message, args);
        }

        #endregion

        #region Info

        /// <summary>
        /// 格式化并写入一条不带参数的信息性日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">要记录的日志消息。</param>
        public static void Info(this ILog log, [StructuredMessageTemplate] string message)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, message);
        }

        /// <summary>
        /// 格式化并写入一条具有一个参数的信息性日志消息。
        /// </summary>
        /// <typeparam name="T">要格式化的对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg">要格式化的对象。</param>
        public static void Info<T>(this ILog log, [StructuredMessageTemplate] string message, T arg)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, message, arg);
        }

        /// <summary>
        /// 格式化并写入一条具有两个参数的信息性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        public static void Info<T1, T2>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, message, arg1, arg2);
        }

        /// <summary>
        /// 格式化并写入一条具有三个参数的信息性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        public static void Info<T1, T2, T3>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, message, arg1, arg2, arg3);
        }

        /// <summary>
        /// 格式化并写入一条具有四个参数的信息性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        public static void Info<T1, T2, T3, T4>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, message, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 格式化并写入一条具有五个参数的信息性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        public static void Info<T1, T2, T3, T4, T5>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, message, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 格式化并写入一条具有六个参数的信息性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        public static void Info<T1, T2, T3, T4, T5, T6>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3,
            T4 arg4, T5 arg5, T6 arg6)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, message, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 格式化并写入一条具有七个参数的信息性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        public static void Info<T1, T2, T3, T4, T5, T6, T7>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3,
            T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 格式化并写入一条具有八个参数的信息性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <typeparam name="T8">要格式化的第八个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        /// <param name="arg8">要格式化的第八个对象。</param>
        public static void Info<T1, T2, T3, T4, T5, T6, T7, T8>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 格式化并写入一条信息性日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="args">一个对象数组，其中包含零个或多个要格式化的对象。</param>
        public static void Info(this ILog log, [StructuredMessageTemplate] string message, params object[] args)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, message, args);
        }

        #endregion

        #region Warn

        /// <summary>
        /// 格式化并写入一条不带参数的警告日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">要记录的日志消息。</param>
        public static void Warn(this ILog log, [StructuredMessageTemplate] string message)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, message);
        }

        /// <summary>
        /// 格式化并写入一条具有一个参数的警告日志消息。
        /// </summary>
        /// <typeparam name="T">要格式化的对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg">要格式化的对象。</param>
        public static void Warn<T>(this ILog log, [StructuredMessageTemplate] string message, T arg)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, message, arg);
        }

        /// <summary>
        /// 格式化并写入一条具有两个参数的警告日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        public static void Warn<T1, T2>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, message, arg1, arg2);
        }

        /// <summary>
        /// 格式化并写入一条具有三个参数的警告日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        public static void Warn<T1, T2, T3>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, message, arg1, arg2, arg3);
        }

        /// <summary>
        /// 格式化并写入一条具有四个参数的警告日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        public static void Warn<T1, T2, T3, T4>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, message, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 格式化并写入一条具有五个参数的警告日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        public static void Warn<T1, T2, T3, T4, T5>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, message, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 格式化并写入一条具有六个参数的警告日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        public static void Warn<T1, T2, T3, T4, T5, T6>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3,
            T4 arg4, T5 arg5, T6 arg6)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, message, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 格式化并写入一条具有七个参数的警告日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        public static void Warn<T1, T2, T3, T4, T5, T6, T7>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3,
            T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 格式化并写入一条具有八个参数的警告日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <typeparam name="T8">要格式化的第八个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        /// <param name="arg8">要格式化的第八个对象。</param>
        public static void Warn<T1, T2, T3, T4, T5, T6, T7, T8>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 格式化并写入一条警告日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="args">一个对象数组，其中包含零个或多个要格式化的对象。</param>
        public static void Warn(this ILog log, [StructuredMessageTemplate] string message, params object[] args)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, message, args);
        }

        #endregion

        #region Error

        /// <summary>
        /// 格式化并写入一条不带参数的错误日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">要记录的日志消息。</param>
        public static void Error(this ILog log, [StructuredMessageTemplate] string message)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, message);
        }

        /// <summary>
        /// 格式化并写入一条具有一个参数的错误日志消息。
        /// </summary>
        /// <typeparam name="T">要格式化的对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg">要格式化的对象。</param>
        public static void Error<T>(this ILog log, [StructuredMessageTemplate] string message, T arg)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, message, arg);
        }

        /// <summary>
        /// 格式化并写入一条具有两个参数的错误日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        public static void Error<T1, T2>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, message, arg1, arg2);
        }

        /// <summary>
        /// 格式化并写入一条具有三个参数的错误日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        public static void Error<T1, T2, T3>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, message, arg1, arg2, arg3);
        }

        /// <summary>
        /// 格式化并写入一条具有四个参数的错误日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        public static void Error<T1, T2, T3, T4>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, message, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 格式化并写入一条具有五个参数的错误日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        public static void Error<T1, T2, T3, T4, T5>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, message, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 格式化并写入一条具有六个参数的错误日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        public static void Error<T1, T2, T3, T4, T5, T6>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3,
            T4 arg4, T5 arg5, T6 arg6)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, message, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 格式化并写入一条具有七个参数的错误日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        public static void Error<T1, T2, T3, T4, T5, T6, T7>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3,
            T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 格式化并写入一条具有八个参数的错误日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <typeparam name="T8">要格式化的第八个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        /// <param name="arg8">要格式化的第八个对象。</param>
        public static void Error<T1, T2, T3, T4, T5, T6, T7, T8>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 格式化并写入一条错误日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="args">一个对象数组，其中包含零个或多个要格式化的对象。</param>
        public static void Error(this ILog log, [StructuredMessageTemplate] string message, params object[] args)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, message, args);
        }

        #endregion

        #region Critical

        /// <summary>
        /// 格式化并写入一条不带参数的关键性日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">要记录的日志消息。</param>
        public static void Critical(this ILog log, [StructuredMessageTemplate] string message)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, message);
        }

        /// <summary>
        /// 格式化并写入一条具有一个参数的关键性日志消息。
        /// </summary>
        /// <typeparam name="T">要格式化的对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg">要格式化的对象。</param>
        public static void Critical<T>(this ILog log, [StructuredMessageTemplate] string message, T arg)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, message, arg);
        }

        /// <summary>
        /// 格式化并写入一条具有两个参数的关键性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        public static void Critical<T1, T2>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, message, arg1, arg2);
        }

        /// <summary>
        /// 格式化并写入一条具有三个参数的关键性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        public static void Critical<T1, T2, T3>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, message, arg1, arg2, arg3);
        }

        /// <summary>
        /// 格式化并写入一条具有四个参数的关键性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        public static void Critical<T1, T2, T3, T4>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, message, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 格式化并写入一条具有五个参数的关键性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        public static void Critical<T1, T2, T3, T4, T5>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            T5 arg5)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, message, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 格式化并写入一条具有六个参数的关键性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        public static void Critical<T1, T2, T3, T4, T5, T6>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3,
            T4 arg4, T5 arg5, T6 arg6)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, message, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 格式化并写入一条具有七个参数的关键性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        public static void Critical<T1, T2, T3, T4, T5, T6, T7>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2, T3 arg3,
            T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 格式化并写入一条具有八个参数的关键性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <typeparam name="T8">要格式化的第八个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        /// <param name="arg8">要格式化的第八个对象。</param>
        public static void Critical<T1, T2, T3, T4, T5, T6, T7, T8>(this ILog log, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 格式化并写入一条关键性日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="args">一个对象数组，其中包含零个或多个要格式化的对象。</param>
        public static void Critical(this ILog log, [StructuredMessageTemplate] string message, params object[] args)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, message, args);
        }

        #endregion

        #region Trace with exception

        /// <summary>
        /// 格式化并写入一条不带参数的跟踪日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">要记录的日志消息。</param>
        public static void Trace(this ILog log, Exception exception, [StructuredMessageTemplate] string message = null)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, exception, message);
        }

        /// <summary>
        /// 格式化并写入一条具有一个参数的跟踪日志消息。
        /// </summary>
        /// <typeparam name="T">要格式化的第一个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg">要格式化的第一个对象。</param>
        public static void Trace<T>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T arg)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, exception, message, arg);
        }

        /// <summary>
        /// 格式化并写入一条具有两个参数的跟踪日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        public static void Trace<T1, T2>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, exception, message, arg1, arg2);
        }

        /// <summary>
        /// 格式化并写入一条具有三个参数的跟踪日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        public static void Trace<T1, T2, T3>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, exception, message, arg1, arg2, arg3);
        }

        /// <summary>
        /// 格式化并写入一条具有四个参数的跟踪日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        public static void Trace<T1, T2, T3, T4>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, exception, message, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 格式化并写入一条具有五个参数的跟踪日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        public static void Trace<T1, T2, T3, T4, T5>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, exception, message, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 格式化并写入一条具有六个参数的跟踪日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        public static void Trace<T1, T2, T3, T4, T5, T6>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, exception, message, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 格式化并写入一条具有七个参数的跟踪日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        public static void Trace<T1, T2, T3, T4, T5, T6, T7>(this ILog log, Exception exception, [StructuredMessageTemplate] string message,
            T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, exception, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 格式化并写入一条具有八个参数的跟踪日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <typeparam name="T8">要格式化的第八个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        /// <param name="arg8">要格式化的第八个对象。</param>
        public static void Trace<T1, T2, T3, T4, T5, T6, T7, T8>(this ILog log, Exception exception, [StructuredMessageTemplate] string message,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, exception, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 格式化并写入一条跟踪日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="args">一个对象数组，其中包含零个或多个要格式化的对象。</param>
        public static void Trace(this ILog log, Exception exception, [StructuredMessageTemplate] string message, params object[] args)
        {
            if (!log.IsEnabled(LogLevel.Trace)) return;
            log.Log(LogLevel.Trace, exception, message, args);
        }

        #endregion

        #region Debug with exception

        /// <summary>
        /// 格式化并写入一条不带参数的调试日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">要记录的日志消息。</param>
        public static void Debug(this ILog log, Exception exception, [StructuredMessageTemplate] string message = null)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, exception, message);
        }

        /// <summary>
        /// 格式化并写入一条具有一个参数的调试日志消息。
        /// </summary>
        /// <typeparam name="T">要格式化的第一个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg">要格式化的第一个对象。</param>
        public static void Debug<T>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T arg)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, exception, message, arg);
        }

        /// <summary>
        /// 格式化并写入一条具有两个参数的调试日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        public static void Debug<T1, T2>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, exception, message, arg1, arg2);
        }

        /// <summary>
        /// 格式化并写入一条具有三个参数的调试日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        public static void Debug<T1, T2, T3>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, exception, message, arg1, arg2, arg3);
        }

        /// <summary>
        /// 格式化并写入一条具有四个参数的调试日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        public static void Debug<T1, T2, T3, T4>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, exception, message, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 格式化并写入一条具有五个参数的调试日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        public static void Debug<T1, T2, T3, T4, T5>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, exception, message, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 格式化并写入一条具有六个参数的调试日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        public static void Debug<T1, T2, T3, T4, T5, T6>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, exception, message, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 格式化并写入一条具有七个参数的调试日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        public static void Debug<T1, T2, T3, T4, T5, T6, T7>(this ILog log, Exception exception, [StructuredMessageTemplate] string message,
            T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, exception, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 格式化并写入一条具有八个参数的调试日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <typeparam name="T8">要格式化的第八个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        /// <param name="arg8">要格式化的第八个对象。</param>
        public static void Debug<T1, T2, T3, T4, T5, T6, T7, T8>(this ILog log, Exception exception, [StructuredMessageTemplate] string message,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, exception, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 格式化并写入一条调试日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="args">一个对象数组，其中包含零个或多个要格式化的对象。</param>
        public static void Debug(this ILog log, Exception exception, [StructuredMessageTemplate] string message, params object[] args)
        {
            if (!log.IsEnabled(LogLevel.Debug)) return;
            log.Log(LogLevel.Debug, exception, message, args);
        }

        #endregion

        #region Info with exception

        /// <summary>
        /// 格式化并写入一条不带参数的信息性日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">要记录的日志消息。</param>
        public static void Info(this ILog log, Exception exception, [StructuredMessageTemplate] string message = null)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, exception, message);
        }

        /// <summary>
        /// 格式化并写入一条具有一个参数的信息性日志消息。
        /// </summary>
        /// <typeparam name="T">要格式化的第一个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg">要格式化的第一个对象。</param>
        public static void Info<T>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T arg)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, exception, message, arg);
        }

        /// <summary>
        /// 格式化并写入一条具有两个参数的信息性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        public static void Info<T1, T2>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, exception, message, arg1, arg2);
        }

        /// <summary>
        /// 格式化并写入一条具有三个参数的信息性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        public static void Info<T1, T2, T3>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, exception, message, arg1, arg2, arg3);
        }

        /// <summary>
        /// 格式化并写入一条具有四个参数的信息性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        public static void Info<T1, T2, T3, T4>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, exception, message, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 格式化并写入一条具有五个参数的信息性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        public static void Info<T1, T2, T3, T4, T5>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, exception, message, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 格式化并写入一条具有六个参数的信息性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        public static void Info<T1, T2, T3, T4, T5, T6>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, exception, message, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 格式化并写入一条具有七个参数的信息性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        public static void Info<T1, T2, T3, T4, T5, T6, T7>(this ILog log, Exception exception, [StructuredMessageTemplate] string message,
            T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, exception, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 格式化并写入一条具有八个参数的信息性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <typeparam name="T8">要格式化的第八个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        /// <param name="arg8">要格式化的第八个对象。</param>
        public static void Info<T1, T2, T3, T4, T5, T6, T7, T8>(this ILog log, Exception exception, [StructuredMessageTemplate] string message,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, exception, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 格式化并写入一条信息性日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="args">一个对象数组，其中包含零个或多个要格式化的对象。</param>
        public static void Info(this ILog log, Exception exception, [StructuredMessageTemplate] string message, params object[] args)
        {
            if (!log.IsEnabled(LogLevel.Information)) return;
            log.Log(LogLevel.Information, exception, message, args);
        }

        #endregion

        #region Warn with exception

        /// <summary>
        /// 格式化并写入一条不带参数的警告日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">要记录的日志消息。</param>
        public static void Warn(this ILog log, Exception exception, [StructuredMessageTemplate] string message = null)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, exception, message);
        }

        /// <summary>
        /// 格式化并写入一条具有一个参数的警告日志消息。
        /// </summary>
        /// <typeparam name="T">要格式化的第一个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg">要格式化的第一个对象。</param>
        public static void Warn<T>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T arg)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, exception, message, arg);
        }

        /// <summary>
        /// 格式化并写入一条具有两个参数的警告日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        public static void Warn<T1, T2>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, exception, message, arg1, arg2);
        }

        /// <summary>
        /// 格式化并写入一条具有三个参数的警告日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        public static void Warn<T1, T2, T3>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, exception, message, arg1, arg2, arg3);
        }

        /// <summary>
        /// 格式化并写入一条具有四个参数的警告日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        public static void Warn<T1, T2, T3, T4>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, exception, message, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 格式化并写入一条具有五个参数的警告日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        public static void Warn<T1, T2, T3, T4, T5>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, exception, message, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 格式化并写入一条具有六个参数的警告日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        public static void Warn<T1, T2, T3, T4, T5, T6>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, exception, message, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 格式化并写入一条具有七个参数的警告日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        public static void Warn<T1, T2, T3, T4, T5, T6, T7>(this ILog log, Exception exception, [StructuredMessageTemplate] string message,
            T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, exception, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 格式化并写入一条具有八个参数的警告日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <typeparam name="T8">要格式化的第八个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        /// <param name="arg8">要格式化的第八个对象。</param>
        public static void Warn<T1, T2, T3, T4, T5, T6, T7, T8>(this ILog log, Exception exception, [StructuredMessageTemplate] string message,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, exception, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 格式化并写入一条警告日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="args">一个对象数组，其中包含零个或多个要格式化的对象。</param>
        public static void Warn(this ILog log, Exception exception, [StructuredMessageTemplate] string message, params object[] args)
        {
            if (!log.IsEnabled(LogLevel.Warning)) return;
            log.Log(LogLevel.Warning, exception, message, args);
        }

        #endregion

        #region Error with exception

        /// <summary>
        /// 格式化并写入一条不带参数的错误日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">要记录的日志消息。</param>
        public static void Error(this ILog log, Exception exception, [StructuredMessageTemplate] string message = null)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, exception, message);
        }

        /// <summary>
        /// 格式化并写入一条具有一个参数的错误日志消息。
        /// </summary>
        /// <typeparam name="T">要格式化的第一个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg">要格式化的第一个对象。</param>
        public static void Error<T>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T arg)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, exception, message, arg);
        }

        /// <summary>
        /// 格式化并写入一条具有两个参数的错误日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        public static void Error<T1, T2>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, exception, message, arg1, arg2);
        }

        /// <summary>
        /// 格式化并写入一条具有三个参数的错误日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        public static void Error<T1, T2, T3>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, exception, message, arg1, arg2, arg3);
        }

        /// <summary>
        /// 格式化并写入一条具有四个参数的错误日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        public static void Error<T1, T2, T3, T4>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, exception, message, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 格式化并写入一条具有五个参数的错误日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        public static void Error<T1, T2, T3, T4, T5>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, exception, message, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 格式化并写入一条具有六个参数的错误日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        public static void Error<T1, T2, T3, T4, T5, T6>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, exception, message, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 格式化并写入一条具有七个参数的错误日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        public static void Error<T1, T2, T3, T4, T5, T6, T7>(this ILog log, Exception exception, [StructuredMessageTemplate] string message,
            T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, exception, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 格式化并写入一条具有八个参数的错误日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <typeparam name="T8">要格式化的第八个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        /// <param name="arg8">要格式化的第八个对象。</param>
        public static void Error<T1, T2, T3, T4, T5, T6, T7, T8>(this ILog log, Exception exception, [StructuredMessageTemplate] string message,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, exception, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 格式化并写入一条错误日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="args">一个对象数组，其中包含零个或多个要格式化的对象。</param>
        public static void Error(this ILog log, Exception exception, [StructuredMessageTemplate] string message, params object[] args)
        {
            if (!log.IsEnabled(LogLevel.Error)) return;
            log.Log(LogLevel.Error, exception, message, args);
        }

        #endregion

        #region Critical with exception

        /// <summary>
        /// 格式化并写入一条不带参数的关键性日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">要记录的日志消息。</param>
        public static void Critical(this ILog log, Exception exception, [StructuredMessageTemplate] string message = null)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, exception, message);
        }

        /// <summary>
        /// 格式化并写入一条具有一个参数的关键性日志消息。
        /// </summary>
        /// <typeparam name="T">要格式化的第一个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg">要格式化的第一个对象。</param>
        public static void Critical<T>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T arg)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, exception, message, arg);
        }

        /// <summary>
        /// 格式化并写入一条具有两个参数的关键性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        public static void Critical<T1, T2>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, exception, message, arg1, arg2);
        }

        /// <summary>
        /// 格式化并写入一条具有三个参数的关键性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        public static void Critical<T1, T2, T3>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, exception, message, arg1, arg2, arg3);
        }

        /// <summary>
        /// 格式化并写入一条具有四个参数的关键性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        public static void Critical<T1, T2, T3, T4>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, exception, message, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// 格式化并写入一条具有五个参数的关键性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        public static void Critical<T1, T2, T3, T4, T5>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, exception, message, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// 格式化并写入一条具有六个参数的关键性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        public static void Critical<T1, T2, T3, T4, T5, T6>(this ILog log, Exception exception, [StructuredMessageTemplate] string message, T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, exception, message, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// 格式化并写入一条具有七个参数的关键性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        public static void Critical<T1, T2, T3, T4, T5, T6, T7>(this ILog log, Exception exception, [StructuredMessageTemplate] string message,
            T1 arg1,
            T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, exception, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// 格式化并写入一条具有八个参数的关键性日志消息。
        /// </summary>
        /// <typeparam name="T1">要格式化的第一个对象的类型。</typeparam>
        /// <typeparam name="T2">要格式化的第二个对象的类型。</typeparam>
        /// <typeparam name="T3">要格式化的第三个对象的类型。</typeparam>
        /// <typeparam name="T4">要格式化的第四个对象的类型。</typeparam>
        /// <typeparam name="T5">要格式化的第五个对象的类型。</typeparam>
        /// <typeparam name="T6">要格式化的第六个对象的类型。</typeparam>
        /// <typeparam name="T7">要格式化的第七个对象的类型。</typeparam>
        /// <typeparam name="T8">要格式化的第八个对象的类型。</typeparam>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="arg1">要格式化的第一个对象。</param>
        /// <param name="arg2">要格式化的第二个对象。</param>
        /// <param name="arg3">要格式化的第三个对象。</param>
        /// <param name="arg4">要格式化的第四个对象。</param>
        /// <param name="arg5">要格式化的第五个对象。</param>
        /// <param name="arg6">要格式化的第六个对象。</param>
        /// <param name="arg7">要格式化的第七个对象。</param>
        /// <param name="arg8">要格式化的第八个对象。</param>
        public static void Critical<T1, T2, T3, T4, T5, T6, T7, T8>(this ILog log, Exception exception, [StructuredMessageTemplate] string message,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, exception, message, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// 格式化并写入一条关键性日志消息。
        /// </summary>
        /// <param name="log">要写入到的 <see cref="ILog"/>。</param>
        /// <param name="exception">要记录的异常。</param>
        /// <param name="message">消息模板格式的日志消息格式字符串。 示例：<c>“用户 {User} 从 {Address} 登录”</c></param>
        /// <param name="args">一个对象数组，其中包含零个或多个要格式化的对象。</param>
        public static void Critical(this ILog log, Exception exception, [StructuredMessageTemplate] string message, params object[] args)
        {
            if (!log.IsEnabled(LogLevel.Critical)) return;
            log.Log(LogLevel.Critical, exception, message, args);
        }

        #endregion
    }
}