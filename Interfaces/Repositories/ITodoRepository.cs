using TodoMVC.Models;

namespace TodoMVC.Interfaces
{
    public interface ITodoRepository
    {
        Task<IEnumerable<Todo>> GetList();
        Task<Todo> GetById(Guid id);
        Task<int> Create(Todo todo);
        Task<int> UpdateById(Guid id, Todo todo);
        Task<int> DeleteById(Guid id);
    }
}