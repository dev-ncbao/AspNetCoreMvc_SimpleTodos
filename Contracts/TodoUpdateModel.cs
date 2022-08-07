using TodoMVC.Models;

namespace TodoMVC.Contracts
{
    public class TodoUpdateModel
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public Status Status { get; set; }
    }
}