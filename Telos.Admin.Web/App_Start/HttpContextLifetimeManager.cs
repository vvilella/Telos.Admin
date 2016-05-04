using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;

namespace  Telos.Admin.Web.Config
{
    // Unity doesn't support per-call lifetime out of the box
    public class HttpContextLifetimeManager<T> : LifetimeManager, IDisposable
    {
        public override object GetValue()
        {
            return HttpContext.Current.Items[typeof(T).AssemblyQualifiedName];
        }
        public override void RemoveValue()
        {
            HttpContext.Current.Items.Remove(typeof(T).AssemblyQualifiedName);
        }
        public override void SetValue(object newValue)
        {
            HttpContext.Current.Items[typeof(T).AssemblyQualifiedName]
                = newValue;
        }
        public void Dispose()
        {
            RemoveValue();
        }
    }
}