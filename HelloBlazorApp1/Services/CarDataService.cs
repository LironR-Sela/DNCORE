using HelloBlazorApp1.Infra;
using HelloBlazorApp1.Models;

namespace HelloBlazorApp1.Services
{
    public class CarDataService : List<Car>, IDataService
    {
        private readonly Random _rnd;

        public CarDataService()
        {
            _rnd = new Random();
        }

        public async Task<bool> AddCar(Car newCar)
        {
            try
            {
                newCar.Id = _rnd.Next();
                this.Add(newCar);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public async Task<IList<Car>> GetAll()
        {
            return this;
        }

        public async Task<bool> RemoveCar(int carId)
        {
            try
            {
                var selectedCar = this.SingleOrDefault(c => c.Id == carId);
                if (selectedCar != null)
                    this.Remove(selectedCar);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
