using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ZooKeeperNet
{
    /// <summary>
    /// 用于替换log4net
    /// </summary>
    public class LogManager
    {
        private static Func<Type, ILog> _func = t => new InnerLog(t.Name);
        /// <summary>
        /// 设置log获取方式
        /// </summary>
        /// <param name="func"></param>
        public static void SetHowToGetLogger(Func<Type, ILog> func)
        {
            _func = func;
        }

        public static ILog GetLogger(Type type)
        {
            return _func(type);
        }

        class InnerLog:ILog
        {
            private string _category;
            public InnerLog(string category)
            {
                this._category = category;
            }

            #region ILog Members

            public bool IsDebugEnabled
            {
                get { return true; }
            }

            public bool IsErrorEnabled
            {
                get { return true; }
            }

            public bool IsFatalEnabled
            {
                get { return true; }
            }

            public bool IsInfoEnabled
            {
                get { return true; }
            }

            public bool IsWarnEnabled
            {
                get { return true; }
            }

            public void Info(object message)
            {
                Trace.WriteLine(message, this._category);
            }

            public void InfoFormat(string format, params object[] args)
            {
                Trace.WriteLine(string.Format(format, args), this._category);
            }

            public void Info(object message, Exception exception)
            {
                Trace.WriteLine(message, this._category);
            }

            public void Error(object message)
            {
                Trace.WriteLine(message, this._category);
            }

            public void ErrorFormat(string format, params object[] args)
            {
                Trace.WriteLine(string.Format(format, args), this._category);
            }

            public void Error(object message, Exception exception)
            {
                Trace.WriteLine(message, this._category);
            }

            public void Warn(object message)
            {
                Trace.WriteLine(message, this._category);
            }

            public void WarnFormat(string format, params object[] args)
            {
                Trace.WriteLine(string.Format(format, args), this._category);
            }

            public void Warn(object message, Exception exception)
            {
                Trace.WriteLine(message, this._category);
            }

            public void Debug(object message)
            {
                Trace.WriteLine(message, this._category);
            }

            public void DebugFormat(string format, params object[] args)
            {
                Trace.WriteLine(string.Format(format, args), this._category);
            }

            public void Debug(object message, Exception exception)
            {
                Trace.WriteLine(message, this._category);
            }

            public void Fatal(object message)
            {
                Trace.WriteLine(message, this._category);
            }

            public void FatalFormat(string format, params object[] args)
            {
                Trace.WriteLine(string.Format(format, args), this._category);
            }

            public void Fatal(object message, Exception exception)
            {
                Trace.WriteLine(message, this._category);
            }

            #endregion
        }
    }
}