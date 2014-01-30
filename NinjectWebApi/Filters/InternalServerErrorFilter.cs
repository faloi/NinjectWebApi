using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;
using NinjectWebApi.Logging;

namespace NinjectWebApi.Filters
{
	public class InternalServerErrorFilter : ExceptionFilterAttribute
	{
		private readonly Logger logger;

		public InternalServerErrorFilter(Logger logger)
		{
			this.logger = logger;
		}

		public override void OnException(HttpActionExecutedContext actionExecutedContext)
		{
			this.logger.Log(DateTime.Now + " - " + actionExecutedContext.Request.RequestUri.AbsoluteUri);

			actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
			{
				ReasonPhrase = "Oops, something went bad :("
			};
		}
	}
}