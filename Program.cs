using System;
using BMICalculator.Models;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person person1 = new Person(101, "Allen", 24, 1.75, 70);
            Console.WriteLine($"The name of the person is {person1.Name}\n" +
                              $"The age is {person1.Age}\n" +
                              $"The BMI is {person1.CalculateBMI()}\n" +
                              $"The person is {person1.GetBodyType()}");

            
            Person person2 = new Person(102, "Bob", 30);
            Console.WriteLine($"The name of the person is {person2.Name}\n" +
                              $"The age is {person2.Age}\n" +
                              $"The BMI is {person2.CalculateBMI()}\n" +
                              $"The person is {person2.GetBodyType()}");
        }
    }
}
