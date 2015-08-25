using SampleIOC.Logging;
using System;
using System.Diagnostics;

namespace SampleIOC
{
    internal class MailLogger : ILogging
    {
        public bool WriteCore(TraceEventType eventType, int eventId, object state, Exception exception, Func<object, Exception, string> formatter)
        {
            throw new NotImplementedException();
        }
    }
}