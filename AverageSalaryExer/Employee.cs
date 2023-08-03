namespace ExerClassesAverageSalaries
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public double CalcAverageSalary(Employee emp1, Employee emp2){
            return (emp1.Salary + emp2.Salary) / 2;
        }
    }
}