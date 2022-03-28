using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Vxchin.Utils.Logging.Internal
{
    internal static class StackTraceUtils
    {
        private static readonly Assembly[] IgnoredAssemblies =
            { typeof(StackTraceUtils).Assembly, typeof(string).Assembly, typeof(Debug).Assembly };

        private static readonly string[] IgnoredNamespaces =
            { "System.", "Microsoft.", "MS." };

        public static Type GetStackTraceClass()
        {
            return GetStackTraceMethod()?.ReflectedType;
        }

        public static MethodBase GetStackTraceMethod()
        {
            return new StackTrace().GetFrames()
                ?.Select(x => x.GetMethod()).FirstOrDefault(x =>
                    // 跳过特定的程序集
                    !IgnoredAssemblies.Contains(x.ReflectedType?.Assembly)
                    // 跳过 System.* 命名空间
                    && IgnoredNamespaces.All(ns => x.ReflectedType?.FullName?.IndexOf(ns, StringComparison.Ordinal) != 0)
                    // 跳过异步的 MoveNext
                    && !(x.Name == "MoveNext" && x.ReflectedType?.Name.IndexOf('<') == 0)
                    // 跳过匿名委托
                    && !(x.Name.IndexOf('<') == 0 && x.Name.IndexOf("__", StringComparison.Ordinal) >= 0 &&
                         x.Name.IndexOf('>') >= 0));
        }
    }
}