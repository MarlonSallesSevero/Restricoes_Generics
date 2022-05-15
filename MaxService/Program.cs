using System;
using System.Collections.Generic;
using Entities;
using Services;
using System.Globalization;
namespace MaxService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Product> list = new List<Product>();
                Console.WriteLine("Enter N:");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {

                    string[] vect = Console.ReadLine().Split(',');
                    string name = vect[0];
                    double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }

                CalculationService calculationService = new CalculationService();
                Product max = calculationService.Max(list);
                Console.Write("Max:");
                Console.WriteLine(max);
                string a = Console.ReadLine();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                string a = Console.ReadLine();
            }
        }
    }
}
