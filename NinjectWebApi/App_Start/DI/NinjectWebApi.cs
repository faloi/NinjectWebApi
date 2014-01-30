using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Dependencies;
using Ninject;

//  A small Library to configure Ninject (A Dependency Injection Library) with a WebAPI Application. 
//  To configure, take the following steps.
// 
//  1. Install Packages Ninject and Ninject.Web.Common 
//  2. Remove NinjectWebCommon.cs in your App_Start Directory
//  3. Add this file to your project  (preferrably in the App_Start Directory)  
//  4. Add Your Bindings to the Load method of MainModule. 
//     You can add as many additional modules to keep things organized
//     simply add them to the Modules property of the NinjectModules class
//  5. Add the following Line to your Global.asax
//          NinjectHttpContainer.RegisterModules(NinjectHttpModules.Modules);  
//  You are done. 

namespace NinjectWebApi.App_Start.DI
{
	/// <summary>
	/// Resolves Dependencies Using Ninject
	/// </summary>
	public class NinjectHttpResolver : IDependencyResolver
	{
		public IKernel Kernel { get; private set; }
		public NinjectHttpResolver()
		{
			Kernel = new StandardKernel();
			Kernel.Load(Assembly.GetExecutingAssembly());
		}

		public object GetService(Type serviceType)
		{
			return Kernel.TryGet(serviceType);
		}

		public IEnumerable<object> GetServices(Type serviceType)
		{
			return Kernel.GetAll(serviceType);
		}

		public void Dispose()
		{
			//Do Nothing
		}

		public IDependencyScope BeginScope()
		{
			return this;
		}
	}


	// List and Describe Necessary HttpModules
	// This class is optional if you already Have NinjectMvc


	/// <summary>
	/// Its job is to Register Ninject Modules and Resolve Dependencies
	/// </summary>
	public class NinjectHttpContainer
	{
		private static NinjectHttpResolver _resolver;

		//Register Ninject Modules
		public static void RegisterModules()
		{
			_resolver = new NinjectHttpResolver();
			GlobalConfiguration.Configuration.DependencyResolver = _resolver;
		}

		//Manually Resolve Dependencies
		public static T Resolve<T>()
		{
			return _resolver.Kernel.Get<T>();
		}
	}
}
