using system;

namespace Matheus
{
  public class Principal 
  {
    public static void Main()
    {
      Manager boss = new Manager("Carl Cracker", 80000, 1987, 12, 15);
      boss.Bonus = 5000;

      Employee[] staff = new Employee[3];

      staff[0] = boss;
      staff[1] = new Employee("Harry Hacker", 50000, 1989, 12, 1);
      staff[2] = new Employee("Tommy Tester", 40000, 1990, 3, 15);

      foreach (Employee e in staff)
      {
        Console.WriteLine("name= " + e.Name
            + ", Salary= " + e.Salary
            + ", hire day= " + e.hireDay.ToString("dd/MM/yyyy"));
      }
    }
  }
}