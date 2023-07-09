using BussiniesLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussiniesLayer.Concrete
{
    public class CarManager : ICarServices
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public void CarAdd(Car car)
        {
            _cardal.Insert(car);
        }

        public void CarDelete(Car car)
        {
            _cardal?.Update(car);
        }

        public void CarUpdate(Car car)
        {
           _cardal.Update(car);
        }

        public Car GetById(int id)
        {
            return _cardal.Get(x => x.id == id);
        }

        public List<Car> GetList()
        {
           return _cardal.Liste();
        }
    }
}
