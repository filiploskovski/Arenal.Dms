using System.Threading.Tasks;

namespace Arenal.Dms.Core.Generic.GenericModels
{
    public interface IGenericService<T> where T : class
    {
        Task<T> Init(T model);
        Task Create(T model);
        Task Update(T model);
        Task Delete(int id);


    }
}