namespace TaskManagement.Model
{
    public class StoryTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public DateTime Date { get; set; }
    }
}
