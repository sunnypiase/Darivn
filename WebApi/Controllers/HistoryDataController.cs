using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistoryDataController(IGenericRepository<HistoryData> repository, IMapper mapper)
        : GenericControllerBase<HistoryData, HistoryDataDto, CreateHistoryDataDto>(repository, mapper);
}