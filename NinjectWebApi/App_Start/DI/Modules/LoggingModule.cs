using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using NinjectWebApi.Logging;

namespace NinjectWebApi.App_Start.DI.Modules
{
	public class LoggingModule : NinjectModule
	{
		public override void Load()
		{
			Bind<Logger>().To<ConsoleLogger>();
		}
	}
}