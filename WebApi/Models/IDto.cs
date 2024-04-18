using WebApi.Entities;

namespace WebApi.Models;

public interface IDto<TModel> where TModel : class, IDbEntity
{
    public int GetId();
}