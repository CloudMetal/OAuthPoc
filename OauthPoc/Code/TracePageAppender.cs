﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace OauthPoc.Code
{
    public class TracePageAppender : log4net.Appender.AppenderSkeleton
    {
        protected override void Append(log4net.Core.LoggingEvent loggingEvent)
        {
            StringWriter sw = new StringWriter(Global.LogMessages);
            Layout.Format(sw, loggingEvent);
        }
    }
}