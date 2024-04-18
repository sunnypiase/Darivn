using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionController(IGenericRepository<Subscription> repository, IMapper mapper)
        : GenericControllerBase<Subscription, SubscriptionDto, CreateSubscriptionDto>(repository, mapper);
}