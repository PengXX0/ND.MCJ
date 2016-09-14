using System;
using System.IO;
using NLog;
using NLog.Config;

namespace ND.MCJ.AOP.Logging
{
    /// <summary>
    /// 全局日志类
    /// 1、使用NLog记录日志
    /// 2、简化日志记录层级，只包括DEBUG，INFO，ERROR三个层级
    /// 3、简化日志操作
    /// </summary>
    public static class Logger
    {
        private static ILogger _log;

        public static XmlLoggingConfiguration LogConfig { get; private set; }

        public static void Initialize(string filePath)
        {
            filePath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + filePath);
            LogConfig = new XmlLoggingConfiguration(filePath);
            LogManager.Configuration = LogConfig;
            _log = LogManager.GetLogger("GlobalLog");
        }

        public static ILogger GetLogger(string typeName)
        {
            return LogManager.GetLogger(typeName);
        }

        public static ILogger GetLogger(Type type)
        {
            return LogManager.GetCurrentClassLogger(type);
        }

        public static bool IsDebugEnabled
        {
            get { return _log.IsDebugEnabled; }
        }

        public static void Debug(object message)
        {
            _log.Debug(message);
        }

        public static void DebugFormat(string format, params object[] args)
        {
            _log.Debug(format, args);
        }

        public static void Error(object message)
        {
            _log.Error(message);
        }

        public static void Error(Exception exception, string message, params object[] args)
        {
            _log.Error(message, exception, args);
        }

        public static void ErrorFormat(string format, params object[] args)
        {
            _log.Error(format, args);
        }

        public static void Info(object message)
        {
            _log.Info(message);
        }

        public static void InfoFormat(string format, params object[] args)
        {
            _log.Info(format, args);
        }
    }
}
