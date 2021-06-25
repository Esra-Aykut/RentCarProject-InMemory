7.gün

DataAccess>>InMemory kullanıldı.

EntityFramework yok.

Sadece 'Car' nesnesi ve  onunla ilgili işlemler var.
  void Add(Car car);
  void Update(Car car);
  void Delete(int CarId);
  List<Car> GetAll();
  Car GetById(int carId);

