using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using WebApi.Entities;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CurrencyPairsController(IGenericRepository<CurrencyPair> repository, IMapper mapper)
        : GenericControllerBase<CurrencyPair, CurrencyPairDto, CreateCurrencyPairDto>(repository, mapper);
}