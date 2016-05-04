using Microsoft.Practices.Unity.InterceptionExtension;

namespace Telos.Admin.Infrastructure
{
    public sealed class LogHandler : ICallHandler
    {
        #region ICallHandler Members

        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            Log.Write("{0}.{1}", input.MethodBase.ReflectedType.Name, input.MethodBase.Name);

            return getNext()(input, getNext);
        }

        public int Order { get; set; }

        #endregion
    }
}
