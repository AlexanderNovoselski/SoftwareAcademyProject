namespace MoviesWebApp.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public string Actor { get; set; }
		public string Genre { get; set; }

		public string ReleaseDate { get; set; }
		public DateTime WatchedOnDate { get; set; } = DateTime.Now;
	}
}
