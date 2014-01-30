using Ninject.Modules;
using NinjectWebApi.Homes;

namespace NinjectWebApi.App_Start.DI.Modules
{
	//Main Module For Application
	public class MainModule : NinjectModule
	{
		public override void Load()
		{
			Bind<ValuesHome>().To<InMemoryValuesHome>();
		}
	}
}