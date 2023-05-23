using Database.Models;

namespace Database;

public static class DatabaseController
{
    public static Repository<Driver> DriverRepository { get; }
    public static Repository<Route> RouteRepository { get; }
    public static Repository<Shipping> ShippingRepository { get; }
    public static Repository<Transport> TransportRepository { get; }
    public static Repository<Fine> FineRepository { get; }

    static DatabaseController()
    {
        var context = new VehicleTrafficContext();
        DriverRepository = new Repository<Driver>(context);
        RouteRepository = new Repository<Route>(context);
        ShippingRepository = new Repository<Shipping>(context);
        TransportRepository = new Repository<Transport>(context);
        FineRepository = new Repository<Fine>(context);
    }

    public static void FillDataBase()
    {
        if(TransportRepository.GetAll().Count > 0) return;
        
        var transport = new Transport
        {
            VIN = "Y6D110307822222",
            Марка = "Газель",
            Модель = "ЗМЗ-40524"
        };

        var transport2 = new Transport
        {
            VIN = "Y6D1103078222343",
            Марка = "Газель",
            Модель = "ГАЗ-5602"
        };

        var transport3 = new Transport
        {
            VIN = "Y6D110307822555",
            Марка = "Mercedes-Benz",
            Модель = "Sprinter"
        };

        var driver = new Driver
        {
            Імя = "Вадим",
            Прізвище = "Баєв",
            Адреса = "Адреса1",
            Номер_Телефону = "06434242342342"
        };

        var driver2 = new Driver
        {
            Імя = "Алік",
            Прізвище = "Онопрієнко",
            Адреса = "Адреса2",
            Номер_Телефону = "0643424233322"
        };

        var driver3 = new Driver
        {
            Імя = "Сергій",
            Прізвище = "Щербаков",
            Адреса = "Адреса3",
            Номер_Телефону = "0643424666"
        };

        var route = new Route
        {
            Початкова_Точка = "Полтава",
            Кінцева_Точка = "Харків",
            Назва = "Полтава - Харків",
            Протяжність_Маршруту = 150
        };

        var route2 = new Route
        {
            Початкова_Точка = "Київ",
            Кінцева_Точка = "Харків",
            Назва = "Київ - Харків",
            Протяжність_Маршруту = 500
        };

        var shipping = new Shipping
        {
            Водій = driver,
            Завершення = DateTime.Now,
            Початок = DateTime.Now.Subtract(TimeSpan.FromHours(2)),
            Маршрут = route,
            Транспорт = transport
        };

        var shipping2 = new Shipping
        {
            Водій = driver2,
            Завершення = DateTime.Now,
            Початок = DateTime.Now.Subtract(TimeSpan.FromHours(3)),
            Маршрут = route2,
            Транспорт = transport2
        };

        var shipping3 = new Shipping
        {
            Водій = driver3,
            Завершення = DateTime.Now,
            Початок = DateTime.Now.Subtract(TimeSpan.FromHours(3)),
            Маршрут = route2,
            Транспорт = transport3
        };

        var fine = new Fine
        {
            Водій = driver2,
            Транспорт = transport2,
            Сума = 220,
            Опис = "Привищення швидкості"
        };

        TransportRepository.Create(transport);
        TransportRepository.Create(transport2);
        TransportRepository.Create(transport3);
        DriverRepository.Create(driver);
        DriverRepository.Create(driver2);
        DriverRepository.Create(driver3);
        RouteRepository.Create(route);
        RouteRepository.Create(route2);
        ShippingRepository.Create(shipping);
        ShippingRepository.Create(shipping2);
        ShippingRepository.Create(shipping3);
        FineRepository.Create(fine);
    }
}