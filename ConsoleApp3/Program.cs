
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Lab_1_2;

namespace Lab_1_2
{
    class Employee
    {
        private string name;
        private int age;
        private string position;
        private double salary;

        public Employee()
        {
            this.name = "";
            this.age = 0;
            this.position = "";
            this.salary = 0.0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        
        public string Position
        {
            get { return position; }
            set { position = value; }
        } 

        public void Info()
        {
            Console.WriteLine("Це співробітник: " + name);
        }
          
        public void AgeVerification()
        {
            if (age < 16)
            {
                Console.WriteLine("Вік" + name + " " + age + " підліток");
            }
            else if (age > 60)
            {
                Console.WriteLine("Вік " + name + " " + age + " пенсіонер");
            }
            else
            {
                Console.WriteLine("Вік " + name + " " + age);
            }

        }


    }     

}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Employee employee = new Employee();

        employee.Name = "Цубера Михайло";
        employee.Age = 45;
        employee.Position = "Бугалтер";
        employee.Salary = 15000;

        employee.Info();
        employee.AgeVerification();
    }
}