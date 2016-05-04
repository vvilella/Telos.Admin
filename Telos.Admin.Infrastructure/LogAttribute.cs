using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace Telos.Admin.Infrastructure
{
    [AttributeUsage(AttributeTargets.All)]
    public sealed class LogAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            return new LogHandler();
        }
    }
}
