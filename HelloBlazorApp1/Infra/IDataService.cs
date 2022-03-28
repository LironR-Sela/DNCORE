using HelloBlazorApp1.Models;

namespace HelloBlazorApp1.Infra
{
    public interface IDataService
    {
        Task<bool> AddCar(Car newCar);
        Task<bool> RemoveCar(int carId);
        Task<IList<Car>> GetAll();
    }
}
