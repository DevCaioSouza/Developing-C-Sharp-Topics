namespace MyTodoApp.Models
{
	public class Todo
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public bool Done { get; set; }
		public DateTime Date { get; set; } = DateTime.Now;

		public Todo(int id, string title, bool done)
		{
			Id = id;
			Title = title;
			Done = done;
		}
	}
}
