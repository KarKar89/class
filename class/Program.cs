using System;

namespace StudentRefactoring
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 6 && value <= 100)
                    _age = value;
                else
                    Console.WriteLine($"Ошибка: возраст {value} некорректен (допустимо 6–100).");
            }
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Иван", "Петров", 20);
            Console.WriteLine($"{s1.FullName}, возраст: {s1.Age}");

            Student s2 = new Student("Мария", "Сидорова", 150);
            Console.WriteLine($"{s2.FullName}, возраст: {s2.Age}");
        }
    }
}