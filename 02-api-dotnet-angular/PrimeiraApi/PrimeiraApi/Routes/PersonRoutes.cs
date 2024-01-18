namespace PrimeiraApi.Routes
{
	public static class PersonRoutes
	{
		public static void MapPersonRoutes(this WebApplication app)
		{
			app.MapGet("/hello-api", () =>
			{
				return new { greetings = "Hello, API!!" };
			});
		}
	}
}
