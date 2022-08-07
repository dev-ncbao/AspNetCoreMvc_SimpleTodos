using TodoMVC.Models;

namespace TodoMVC.Contracts
{
    public class TodoViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
    }
}