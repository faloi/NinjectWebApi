using System;
using System.Web.Http;
using NinjectWebApi.Filters;

namespace NinjectWebApi.Controllers
{
	public class ErrorController : ApiController
	{
		public string Get()
		{
			throw new ApplicationException();
		}
	}
}