using BussiniesLayer.Abstract;
using BussiniesLayer.Concreta.Repository;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsesLayer.EntityFramevork
{
    public class EFCarDal : GenericRepository<Car>, ICarDal
    {
    }
}
