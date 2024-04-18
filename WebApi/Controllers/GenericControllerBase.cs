using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    public class GenericControllerBase<TModel, TDto, TCreateDto> : ControllerBase
        where TModel : class, IDbEntity, new()
        where TDto : IDto<TModel>
        where TCreateDto : ICreateDto<TModel>
    {
        private readonly IGenericRepository<TModel> _repository;
        private readonly IMapper _mapper;

        public GenericControllerBase(IGenericRepository<TModel> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TDto>>> GetAll()
        {
            var items = await _repository.GetAllAsync();
            var dtos = _mapper.Map<IEnumerable<TDto>>(items);
            return Ok(dtos);
        }

        // GET: api/[controller]/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TDto>> GetById(int id)
        {
            var item = await _repository.GetByIdAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            var dto = _mapper.Map<TDto>(item);
            return Ok(dto);
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TDto>> Create([FromBody] TCreateDto createDto)
        {
            var item = _mapper.Map<TModel>(createDto);
            await _repository.AddAsync(item);
            var dto = _mapper.Map<TDto>(item);
            return CreatedAtAction(nameof(GetById), new { id = item.GetId() }, dto);
        }

        // PUT: api/[controller]/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] TDto dto)
        {
            if (id != dto.GetId())
            {
                return BadRequest("ID mismatch");
            }

            var item = _mapper.Map<TModel>(dto);
            await _repository.UpdateAsync(item);
            return Ok();
        }

        // DELETE: api/[controller]/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return Ok();
        }
    }
}