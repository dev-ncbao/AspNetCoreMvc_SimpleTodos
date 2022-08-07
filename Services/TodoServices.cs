using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TodoMVC.Contracts;
using TodoMVC.Interfaces;
using TodoMVC.Models;

namespace TodoMVC.Services
{
    public class TodoServices : ITodoServices
    {
        private readonly IMapper _mapper;
        private readonly ITodoRepository _repo;

        public TodoServices(ITodoRepository _repo, IMapper _mapper)
        {
            this._mapper = _mapper;
            this._repo = _repo;
        }

        public async Task<int> Create(TodoCreateModel request)
        {
            var dataMapping = _mapper.Map<Todo>(request);
            var result = await _repo.Create(dataMapping);
            return result;
        }

        public async Task<TodoViewModel> GetById(Guid id)
        {
            var data = await _repo.GetById(id);

            var dataMapping = _mapper.Map<TodoViewModel>(data);
            return dataMapping;
        }

        public async Task<IEnumerable<TodoViewModel>> GetList()
        {
            var data = await _repo.GetList();

            var dataMapping = _mapper.Map<IEnumerable<TodoViewModel>>(data);
            return dataMapping;
        }
    }
}