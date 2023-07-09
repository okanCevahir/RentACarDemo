using BussiniesLayer.Concrete;
using DataAcsesLayer.EntityFramevork;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RentACarDemo.Controllers
{
    public class CarController : Controller
    {
        CarManager cm=new CarManager(new EFCarDal());
        public IActionResult Index(string ara)
        {
            var carvalus = cm.GetList().Where(x=>x.Statu==false).ToList();

            if (!string.IsNullOrEmpty(ara))
            {
                carvalus = carvalus.Where(x => x.Marka.Contains(ara) || x.Model.Contains(ara) || x.Vites.Contains(ara) || x.Yakit.Contains(ara)).ToList();
            }
            return View(carvalus);
        }

        public IActionResult GetDetay(int id)
        {
            var carrvalues=cm.GetById(id);
            return View(carrvalues);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {

            var carrValue = cm.GetById(id);
            return View(carrValue);
        }

        [HttpPost]
        public IActionResult Update(Car p)
        {
            cm.CarUpdate(p);
            return RedirectToAction("Index");

        }
        public IActionResult DeleteCar(int id)
        {
            var car = cm.GetById(id); 

            if (car != null)
            {
                
                car.Statu = !car.Statu;

                // Arabayı güncelleyin
                cm.CarUpdate(car);
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddCaar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCaar(Car p)
        {
            
             cm.CarAdd(p);
             return RedirectToAction("Index");

        }
    }
}
