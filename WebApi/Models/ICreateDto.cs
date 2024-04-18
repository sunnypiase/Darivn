using WebApi.Entities;

namespace WebApi.Models;

public class ICreateDto<TModel> where TModel : class, IDbEntity
{
}