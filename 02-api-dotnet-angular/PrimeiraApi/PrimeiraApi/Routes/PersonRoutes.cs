using PrimeiraApi.Models;

namespace PrimeiraApi.Routes
{
	public static class PersonRoutes
	{
		public static List<Person> PersonList = new()
		{
			new Person(id: Guid.NewGuid(), name:"Neymar"),
			new Person(id: Guid.NewGuid(), name:"Suarez"),
			new Person(id: Guid.NewGuid(), name:"Messi"),
		};
		public static void MapPersonRoutes(this WebApplication app)
		{
			app.MapGet("/personlist", () => PersonList );

			app.MapGet("/personlist/{name}", 
				(string name) => PersonList.Find(x => x.Name == name));

			app.MapPost("/personlist", (HttpContext request ,Person person) =>
			{

				var nome = request.Request.Query["name"];

				PersonList.Add(person);
				return Results.Ok(person);
			});

			app.MapPut("/personlist/{id}", 
				(Guid id, Person person) =>
				{
					var findPerson = PersonList.Find(x => x.Id == id);

					if (findPerson == null)
						return Results.NotFound();

					findPerson.Name = person.Name;

					return Results.Ok(person);
				} );
		}
	}
}
