using System;
using System.Globalization;

namespace ExerListas
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

        override public string ToString()
        {
            return "ID: "
                    + Id
                    + ", Name: "
                    + Name
                    + ", Updated salary: "
                    + Salary.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}