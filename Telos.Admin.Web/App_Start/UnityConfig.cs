using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using UnityConfiguration;
using  Telos.Admin.Infrastructure;
using System.Diagnostics;
using System.Reflection;
using Microsoft.Practices.Unity.InterceptionExtension;
using System;

namespace  Telos.Admin.Web.Config
{
  public static class UnityConfig
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      RegisterTypes(container);

      return container;
    }

    private static bool hasAttribute(Type type, Type attributeType)
    {
        if (type.GetCustomAttribute(attributeType) != null)
            return true;
        var methods = type.GetMethods();
        foreach (var method in methods)
        {
            if (method.GetCustomAttribute(attributeType) != null)
                return true;
        }
        return false;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
        string[] assemblyNameParts = Assembly.GetExecutingAssembly().GetName().Name.Split('.');
        string assemblyPrefix = string.Join(".", assemblyNameParts, 0, 1);

        container.AddNewExtension<Interception>(); 

        Predicate<Type> intercept = (t) =>
        {
            var interceptionConfiguration = container.Configure<Interception>();
            if (t.IsConcrete() && !t.IsSealed && hasAttribute(t, typeof(LogAttribute)))
            {
                interceptionConfiguration.SetDefaultInterceptorFor(t, new VirtualMethodInterceptor());
            }
            return true;
        };

        Predicate<Assembly> includeAssembly = (a) =>
        {
            var assemblyName = a.GetName().Name;
            return assemblyName.StartsWith(assemblyPrefix) && (assemblyName.Contains("Business")  || assemblyName.Contains("Data"));
        };

        container.Configure(c =>
        {
            c.Scan(scan =>
            {
                scan.AssembliesInBaseDirectory(a => includeAssembly(a));
                scan.Include(t => intercept(t));
                scan.WithNamingConvention();
            });

            c.Configure<IDatabaseControlContext>().Using<HttpContextLifetimeManager<IDatabaseControlContext>>();
        });
    }
  }

}