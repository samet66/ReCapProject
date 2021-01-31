using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ConCrete
{
    public class CarManager : ICarService
    {
        ICarDal  _ICarDal;

        public CarManager(ICarDal carDal)
        {
            _ICarDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _ICarDal.GetAll();
        }
    }
}
