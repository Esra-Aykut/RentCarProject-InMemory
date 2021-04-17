using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        //DataAccess ile bağlantı kurmak için bir ICarDal nesnesi oluştur.
        //CarManager new'lendiğinde 1 tane ICarDal referansı olustur => ctor
        //Business'da InMemory, Ent.Frm vs yok. ICarDal var. Bu hepsine referans olabilir.
        //implementasyon ile gelen fonksiyonları doldur => _carDal.

        ICarDal _carDal;
     
        public CarManager(ICarDal carDal)   
        {
            _carDal = carDal;
        }

        public void Delete(int CarId)
        {
            _carDal.Delete(CarId);
        }
       
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }


        public void Deneme()
        {
            Console.WriteLine("CarManager'daki Deneme fonksiyonu");
        }

    }
}
