using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Car;

public class Program
{
    static void Main()
    {
        // 2 Задание 

        // Создаем объекты Car
        Car car1 = new Car("Toyota Camry", "V6", 220);
        Car car2 = new Car("Honda Accord", "V4", 200);
        Car car3 = new Car("Ford Mustang", "V8", 250);

        // Создаем объект CarsCatalog и добавляем машины
        CarsCatalog catalog = new CarsCatalog();
        catalog.AddCar(car1);
        catalog.AddCar(car2);
        catalog.AddCar(car3);

        // Выводим информацию о машинах
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(catalog[i]);
        }

        // Проверяем равенство объектов Car
        Console.WriteLine(car1.Equals(car2)); // False
        Console.WriteLine(car1.Equals(new Car("Toyota Camry", "V6", 220))); // True

        // 3 Задание 

        int a = 5; long b = 100;
        a = (int)b;
        b = a;

        CurrencyUSD.USDToEUR = 0.85;
        CurrencyUSD.USDToRUB = 70.0;

        CurrencyEUR.EURToUSD = 1.18;
        CurrencyEUR.EURToRUB = 82.0;

        CurrencyRUB.RUBToUSD = 0.014;
        CurrencyRUB.RUBToEUR = 0.012;

        // Создаем объекты валют
        CurrencyUSD usd = new CurrencyUSD(100);
        CurrencyEUR eur = new CurrencyEUR(100);
        CurrencyRUB rub = new CurrencyRUB(100);

        // Преобразование валют
        CurrencyEUR convertedToEUR = (CurrencyEUR)usd;
        CurrencyRUB convertedToRUB = (CurrencyRUB)eur;
        CurrencyUSD convertedToUSD = (CurrencyUSD)rub;

        // Вывод результатов
        Console.WriteLine($"100 USD to EUR: {convertedToEUR.Value} EUR");
        Console.WriteLine($"100 EUR to RUB: {convertedToRUB.Value} RUB");
        Console.WriteLine($"100 RUB to USD: {convertedToUSD.Value} USD");

        Console.ReadLine();
    }
    
}

