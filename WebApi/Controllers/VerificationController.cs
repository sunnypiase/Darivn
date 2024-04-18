using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VerificationController(IGenericRepository<Verification> repository, IMapper mapper)
        : GenericControllerBase<Verification, VerificationDto, CreateVerificationDto>(repository, mapper);
}