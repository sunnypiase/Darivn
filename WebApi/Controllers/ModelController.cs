using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModelController(IGenericRepository<Model> repository, IMapper mapper)
        : GenericControllerBase<Model, ModelDto, CreateModelDto>(repository, mapper);
}