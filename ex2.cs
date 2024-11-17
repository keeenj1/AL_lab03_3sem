using System;
using System.Collections.Generic;
using static Car;

public class Car : IEquatable<Car>
{
    public string Name { get; set; }
    public string Engine { get; set; }
    public int MaxSpeed { get; set; }

    public Car(string name, string engine, int maxSpeed)
    {
        Name = name;
        Engine = engine;
        MaxSpeed = maxSpeed;
    }
    public override string ToString()
    {
        return Name;
    }
    public bool Equals(Car other)
    {
        if(other == null) return false;
        return Name == other.Name && Engine == other.Engine && MaxSpeed == other.MaxSpeed;
    }
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        return Equals(obj as Car);
    }
    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + (Name != null ? Name.GetHashCode() : 0);
            hash = hash * 23 + (Engine != null ? Engine.GetHashCode() : 0);
            hash = hash * 23 + MaxSpeed.GetHashCode();
            return hash;
        }
    }
    public class CarsCatalog
    {
        private List<Car> cars;
        public CarsCatalog()
        {
            cars = new List<Car>();
        }
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= cars.Count)
                    throw new IndexOutOfRangeException("Индекс находится вне диапазона коллекции.");

                Car car = cars[index];
                return $"{car.Name} ({car.Engine})";
            }
        }
    }
}
