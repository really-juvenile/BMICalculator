using System;

namespace BMICalculator.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; } = 5;
        public double Weight { get; set; } = 50;

        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        
        public Person(int id, string name, int age, double height, double weight) : this(id, name, age)

        {
            Height = height;
            Weight = weight;
        }

       
        public double CalculateBMI()
        {
            return Weight / (Height * Height);
        }

        
        public string GetBodyType()
        {
            double bmi = CalculateBMI();
            if (bmi < 19)
            {
                return "Underweight";
            }
            else if (bmi >= 19 && bmi < 24)
            {
                return "Normal";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }
    }
}
