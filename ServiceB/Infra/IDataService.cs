using MSDemo.Models;
using System.Threading.Tasks;

namespace ServiceB.Infra
{
    public interface IDataService
    {
        Task<Car> GetData();
    }
}
