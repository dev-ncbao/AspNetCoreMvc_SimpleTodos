using Microsoft.EntityFrameworkCore;
using TodoMVC.Interfaces;
using TodoMVC.Models;

namespace TodoMVC.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext _context;
        private readonly DbSet<Todo> _todoRepo;

        public TodoRepository(TodoContext _context)
        {
            this._context = _context;
            this._todoRepo = _context.Todos;
        }

        public async Task<int> Create(Todo todo)
        {
            await _todoRepo.AddAsync(todo);
            var count = await _context.SaveChangesAsync();
            return count;
        }

        public async Task<int> DeleteById(Guid id)
        {
            var data = await _todoRepo.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();

            if (data == null)
                return -1;

            _todoRepo.Remove(data);
            var count = await _context.SaveChangesAsync();
            return count;
        }

        public async Task<Todo> GetById(Guid id)
        {
            var data = await _todoRepo.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();
            return data;
        }

        public async Task<IEnumerable<Todo>> GetList()
        {
            var data = await _todoRepo.ToListAsync();
            return data;
        }

        public async Task<int> UpdateById(Guid id, Todo todo)
        {
            var data = await _todoRepo.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();

            if (data == null)
                return -1;

            _todoRepo.Update(todo);
            var count = await _context.SaveChangesAsync();
            return count;
        }
    }
}