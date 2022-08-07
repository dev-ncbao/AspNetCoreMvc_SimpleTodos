using TodoMVC.Models;

namespace TodoMVC.Contracts
{
    public class TodoCreateModel
    {
        public string Name { get; set; }
        public Status Status { get; set; }
    }
}