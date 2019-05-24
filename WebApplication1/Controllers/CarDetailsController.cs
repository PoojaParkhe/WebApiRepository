using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarDetailsController : ApiController
    {
        public IEnumerable<Car> GetAllCarDetails()
        {
            Car c1 = new Car();
            Car c2 = new Car();
            List<Car> lstCar = new List<Car>();
            c1.CarName = "Maruti Vagonar";
            c1.CarModel = "VXI";
            c1.CarColor = "Blue";
            c1.CarPrice = "4 Lakh";

            c2.CarName = "Maruti Swift";
            c2.CarModel = "VXI";
            c2.CarColor = "Brown";
            c2.CarPrice = "5 Lakh";
            lstCar.Add(c1);
            lstCar.Add(c2);
            return lstCar;
          
        }

        public IEnumerable<Car> Get(int id)
        {
            Car c1 = new Car();
            Car c2 = new Car();
            List<Car> lstCar = new List<Car>();
            if (id == 1)
            {
                c1.CarName = "Maruti Vagonar";
                c1.CarModel = "VXI";
                c1.CarColor = "Blue";
                c1.CarPrice = "4 Lakh";
                lstCar.Add(c1);
            }
            else if (id == 2)
            {
                c2.CarName = "Maruti Vagonar";
                c2.CarModel = "VXI";
                c2.CarColor = "Blue";
                c2.CarPrice = "4 Lakh";
                lstCar.Add(c2);
            }
            return lstCar;
        }

        public void post([FromBody]string value)
        {
        }

        public void put(int id, [FromBody] string Value)
        {

        }

        public void delete(int id)
        {
            
        }
    }
}
