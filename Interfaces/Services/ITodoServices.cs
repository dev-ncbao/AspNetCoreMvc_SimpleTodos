using TodoMVC.Contracts;
using TodoMVC.Models;

namespace TodoMVC.Interfaces
{
    public interface ITodoServices
    {
        Task<IEnumerable<TodoViewModel>> GetList();
        Task<TodoViewModel> GetById(Guid id);
        Task<int> Create(TodoCreateModel request);
    }
}