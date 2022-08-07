namespace TodoMVC.Models
{
    public class Todo
    {
        public Todo()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
    }
}