using system;

namespace Matheus
{
  public class Employee
  {
    public string Name { get; set;}
    public virtual double Salary { get; set;}
    public DateTime HireDay { get; set;}

    public Employee(string name, double salary, int year, int month, int day)
    {
      name = name;
      salary = salary;
      HireDay = new DateTime(year, month, day);
    }

    public void raiseSalary(double percent)
    {
      double raise = Salary * percent /100;
      Salary += raise;
    }
  }
}