using System;

namespace Emby.Mobile.Core.Interfaces
{
    public interface ILog
    {
        void Info(string message, params object[] parameters);
        void InfoException(string message, Exception exception);
        void Warning(string message, params object[] parameters);
        void WarningException(string message, Exception exception);
        void Error(string message, params object[] parameters);
        void ErrorException(string message, Exception exception);
        void Fatal(string message, params object[] parameters);
        void FatalException(string message, Exception exception);
        void Debug(string message, params object[] parameters);
        void DebugException(string message, Exception exception);
        void Trace(string message, params object[] parameters);
        void TraceException(string message, Exception exception);
    }
}