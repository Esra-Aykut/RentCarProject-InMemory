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

        List<Car> cars = new List<Car> {
            new Car {CarId=1, BrandId=2, ColorId=1, DailyPrice=130, ModelYear="2019", Description="Description 1..."},
            new Car {CarId=2, BrandId=1, ColorId=1, DailyPrice=200, ModelYear="2020", Description="Description 2..."},
        };


        //implementasyon ile gelen fonk.ları doldur:

        #region Delete(int CarId) => önce referansı bul
        public void Delete(int CarId)
        {
            Car carToDelete =  cars.SingleOrDefault(c => c.CarId == CarId);
            cars.Remove(carToDelete);

        }
        #endregion

        #region Update(Car car)   => önce referansı bul
        public void Update(Car car) 
        {
            Car carToUpdate = cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
        #endregion

        #region Add(Car car)
        public void Add(Car car)
        {
            cars.Add(car);
        }
        #endregion

        #region GetAll()
        public List<Car> GetAll()
        {
            return cars;
        }
        #endregion

        public Car GetById(int carId)
        {
            return cars.SingleOrDefault(c => c.CarId == carId);
        }




    }
}
