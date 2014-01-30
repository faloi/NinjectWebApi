namespace NinjectWebApi.Logging
{
	public interface Logger
	{
		void Log(string message);
		string CurrentController { get; set; }
	}
}