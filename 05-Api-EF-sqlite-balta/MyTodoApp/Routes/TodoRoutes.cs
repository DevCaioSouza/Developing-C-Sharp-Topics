using MyTodoApp.Models;

namespace MyTodoApp.Routes
{
	public static class TodoRoutes
	{
		public static List<Todo> TodoList = new()
		{
			new Todo(id: 1, title:"Primeira task", done: true),
			new Todo(id: 2, title:"Segunda task", done: true),
			new Todo(id: 3, title:"Terceira task", done: false),
		};

		public static void MapTodoRoutes(this WebApplication app)
		{
			app.MapGet("todos", () => TodoList);
		}
	}
}
