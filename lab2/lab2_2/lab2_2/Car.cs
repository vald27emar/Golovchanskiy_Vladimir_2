using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    public class Car
    {
        public Car(string brand, int price, int fuel, int speed)
        {
            Brand = brand;
            Price = price;
            Fuel = fuel;
            Speed = speed;
        }
        public string Brand { get; set; } //Марка машины
        public int Price { get; set; } //Цена
        public int Fuel { get; set; } //Расход
        public int Speed { get; set; } //Скорость   
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3};", Brand, Price, Fuel, Speed);
        }
    }
}
