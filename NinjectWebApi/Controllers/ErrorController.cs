using System;
using System.Web.Http;
using NinjectWebApi.Filters;

namespace NinjectWebApi.Controllers
{
	[InternalServerErrorFilter]
	public class ErrorController : ApiController
	{
		public string Get()
		{
			throw new ApplicationException();
		}
	}
}