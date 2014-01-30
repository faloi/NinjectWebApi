using Ninject.Modules;
using NinjectWebApi.Homes;

namespace NinjectWebApi.App_Start.DI
{
	public class NinjectHttpModules
	{
		//Return Lists of Modules in the Application
		public static NinjectModule[] Modules
		{
			get
			{
				return new[] { new MainModule() };
			}
		}

		//Main Module For Application
		public class MainModule : NinjectModule
		{
			public override void Load()
			{
				Bind<ValuesHome>().To<InMemoryValuesHome>();
			}
		}
	}
}