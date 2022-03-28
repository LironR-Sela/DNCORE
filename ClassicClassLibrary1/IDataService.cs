using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicClassLibrary1
{
    internal interface IDataService
    {
        Task<IList<Car>> GetAll();
    }
}
