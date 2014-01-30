using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace NinjectWebApi.Filters
{
	public class InternalServerErrorFilter : ExceptionFilterAttribute
	{
		public override void OnException(HttpActionExecutedContext actionExecutedContext)
		{
			actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
			{
				ReasonPhrase = "Oops, something went bad :("
			};
		}
	}
}