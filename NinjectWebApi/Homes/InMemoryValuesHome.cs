using System.Collections.Generic;

namespace NinjectWebApi.Homes
{
	public class InMemoryValuesHome : ValuesHome
	{
		public IEnumerable<string> All()
		{
			return new[] { "one", "two", "three" };
		}
	}
}