namespace FCSDemo.Models
{
    public class Movie : IAggregateRoot
    {
        public Movie(string? name, DateTime releaseDate, string? director)
        {
            Name = name;
            ReleaseDate = releaseDate;
            Director = director;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? Director { get; set; }
    }
}
