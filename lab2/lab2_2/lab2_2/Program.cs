using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------");
            CarPark myCarPark = new CarPark();
            myCarPark.Add(new Car("Mercedes-Benz S-Class W223", 150000, 10, 250));
            myCarPark.Add(new Car("Toyota Camry V70", 37000, 5, 230));
            myCarPark.Add(new Car("Kia Optima", 19000, 6, 200));
            myCarPark.Add(new Car("Hyundai Solaris", 11700, 7, 180));
            myCarPark.GetCarInfoOlderThan4();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Ввыберите опцию: ");
            Console.WriteLine("1 - Вывести стоимость автопарка");
            Console.WriteLine("2 - Сортировать расход топлива");
            Console.WriteLine("3 - Поиск по скорости");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    myCarPark.FleetCost();
                    break;
                case 2:
                    myCarPark.SortFuel();
                    break;
                case 3:
                    myCarPark.SpeedSearch();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
