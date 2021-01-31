using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    ID = 1,
                    BrandID = 1,
                    ColorID = 3,
                    DailyPrice = "4",
                    ModelYear = "2020",
                    Description ="2020 model araç"
                },
                new Car
                {
                    ID = 2,
                    BrandID = 1,
                    ColorID = 3,
                    DailyPrice = "1",
                    ModelYear = "2011",
                    Description ="2011 model araç"
                },
                new Car
                {
                    ID = 3,
                    BrandID = 1,
                    ColorID = 1,
                    DailyPrice = "11",
                    ModelYear = "2000",
                    Description ="2000 model araç"
                },
                new Car
                {
                    ID = 4,
                    BrandID = 3,
                    ColorID = 2,
                    DailyPrice = "14",
                    ModelYear = "2011",
                    Description ="2011 model araç"
                },
                new Car
                {
                    ID = 5,
                    BrandID = 2,
                    ColorID = 1,
                    DailyPrice = "4",
                    ModelYear = "2000",
                    Description ="2000 model araç"
                }
            };
        }

        public void Add(Car car) => _cars.Add(car);

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.ID == car.ID);
            _cars.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByID(int Id)
        {
            return _cars.Where(c => c.ID == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.ID == car.ID );

            carUpdate.ID = car.ID;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.Description = car.Description;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.ColorID = car.ColorID;
            carUpdate.BrandID = car.BrandID;

        }
    }
}
