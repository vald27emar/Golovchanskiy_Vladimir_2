using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    public class CarPark
    {
        List<Car> list = new List<Car>();

        public void GetCarInfoOlderThan4()
        {
            Console.WriteLine("Cписок автопарка: ");
            Console.WriteLine("Марка машины / Цена в долларах / Расход топлива на 100 км / Cкорость");
            foreach (Car car in list)
            {
                Console.WriteLine(car.ToString());
            }
        }
        public void FleetCost() // цена автопарка, сложить стоимость каждого авто
        {
            Console.WriteLine("--------------------------------------------------------------------");
            int k = 0;
            foreach (Car car in list)
            {
                k += car.Price;
            }
            Console.WriteLine($"Cтоимость всего автопара: {k} долларов");
            Console.WriteLine("--------------------------------------------------------------------");
        }
        public void SortFuel() // сортировка по расходу топлива
        {
            Console.WriteLine("--------------------------------------------------------------------");
            int[] a = new int[4];
            int l = 0;
            foreach (Car car in list)
            {
                a[l] = car.Fuel;
                l++;
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
            l = 0;
            foreach (Car car in list)
            {
                car.Fuel = a[l];
                l++;
                Console.WriteLine(car.Fuel);
            }
            Console.WriteLine("--------------------------------------------------------------------");
        }
        public void SpeedSearch() // поиск по диапозону скорости
        {

            Console.WriteLine("Задайте максимальную скорость: ");
            int maxSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте минимальную скорость: ");
            int minSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (Car car in list)
            {
                if (car.Speed <= maxSpeed && car.Speed >= minSpeed)
                {
                    Console.WriteLine(car.Brand);
                    break;
                }
            }
            Console.WriteLine("--------------------------------------------------------------------");
        }
        internal void Add(Car car)
        {
            list.Add(car);
        }
    }
}
