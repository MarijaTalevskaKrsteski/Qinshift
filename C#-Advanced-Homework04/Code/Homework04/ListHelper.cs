using Homework04.Domain.Models;

namespace Homework04
{
    public static class ListHelper
    {
        public static void PrintSimple<T>(this List<T> list)
        {
            Console.WriteLine($"\nPrinting {list.Count} items:");
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintCarEntities(this List<Car> list) 
        {
            Console.WriteLine($"\nPrinting {list.Count} items:");
            foreach (Car car in list)
            {
                Console.WriteLine($"Model: {car.Model}, Cylinders: {car.Cylinders}");
            }
        }

    }
}