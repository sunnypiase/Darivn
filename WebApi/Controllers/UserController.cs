using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(IGenericRepository<User> repository, IMapper mapper)
        : GenericControllerBase<User, UserDto, CreateUserDto>(repository, mapper);
}