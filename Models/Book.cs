namespace CodeLibrary.models
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool IsAvailable { get; set; }

        public Book(string author, string title, string description, string type)
        {
            Author = author;
            Title = title;
            Description = description;
            Type = type;
            IsAvailable = true;
        }
    }
}