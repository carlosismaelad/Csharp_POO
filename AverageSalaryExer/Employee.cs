namespace ExerClassesAverageSalaries
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public double CalcAverageSalary(List<Employee> employees){
            double totalSalary = 0;
            
            foreach (var emp in employees){
                totalSalary += emp.Salary;
            }
            
            return totalSalary / employees.Count;
        }
    }
}