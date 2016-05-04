using System;
using Clutch.Diagnostics.EntityFramework;
using Telos.Admin.Infrastructure;

namespace CTelos.Admin.Data
{
    public class DatabaseControlContextTracer : IDbTracingListener
    {
        public void CommandExecuted(DbTracingContext context)
        {
        }
        
        public void CommandExecuting(DbTracingContext context)
        {
        }
        
        public void CommandFailed(DbTracingContext context)
        {
        }

        public void CommandFinished(DbTracingContext context)
        {
            Log.Write("-- time: {0}{1}{2}", context.Duration, Environment.NewLine, context.Command.ToTraceString());
        }

        public void ReaderFinished(DbTracingContext context)
        {
        }
    }
}
