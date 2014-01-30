using System.Web.Http.Filters;
using Ninject.Modules;
using Ninject.Web.WebApi.FilterBindingSyntax;
using NinjectWebApi.Filters;

namespace NinjectWebApi.App_Start.DI.Modules
{
	public class FiltersModule : NinjectModule
	{
		public override void Load()
		{
			this.BindHttpFilter<InternalServerErrorFilter>(FilterScope.Controller);
		}
	}
}