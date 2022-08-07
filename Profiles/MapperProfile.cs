using AutoMapper;
using TodoMVC.Contracts;
using TodoMVC.Models;

namespace TodoMVC.Profiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Todo, Todo>();

            CreateMap<Todo, TodoViewModel>().ReverseMap();
            CreateMap<IEnumerable<Todo>, List<TodoViewModel>>();

            CreateMap<TodoCreateModel, Todo>();
        }
    }
}