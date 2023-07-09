using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussiniesLayer.Abstract
{
    public interface ICarServices
    {
        List<Car> GetList();
        void CarAdd(Car car);
        void CarDelete(Car car);
        void CarUpdate(Car car);
        Car GetById(int id);
    }
}
