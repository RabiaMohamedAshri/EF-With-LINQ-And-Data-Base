using EntityFramework.Contexts;
using EntityFramework.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext context = new CompanyDbContext();

            //Employee Em01 = new Employee { Name = "Mahmoud", Salary = 1000, Age = 22, EmailAddress = "Mahmoud@gmail.com" };
            //Employee Em02 = new Employee { Name = "Ali", Salary = 15000, Age = 23, EmailAddress = "Ali@gmail.com" };
            //Employee Em03 = new Employee { Name = "Ahmed", Salary = 9000, Age = 21, EmailAddress = "Ahmed@gmail.com" };


            //context.Employees.Add(Em01);
            //context.Employees.Add(Em02);
            //context.Employees.Add(Em03);
            //context.SaveChanges();
            //    ////var Result=  context.Employees.Where(e => e.id > 3);
            //    ////context.RemoveRange(Result);
            //context.SaveChanges();
            //context.Employees.Add(Em01);
            //context.SaveChanges();
            //Console.WriteLine(context.Entry(Em01).State);

            //Console.WriteLine("==================");

            //Console.WriteLine($"Emp01 id ={Em01.id}");
            //Console.WriteLine($"Emp02 id ={Em02.id}");

            //var Empl = from E in context.Employees
            //           where E.id > 2
            //           select E;
            //context.Employees.RemoveRange(Empl);

            //context.Employees.Add(Em03);

            //context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            //var Empl = (from e in context.Employees
            //            where e.id == 1
            //            select e).ToList();

            //Console.WriteLine(Empl);


            //Empl.Salary = 8000;
            //Empl.Age = 19;
            //context.SaveChanges();


            #region Explicit Loging 
            //var Emp = context.Employees.Where(E => E.Id == 1).FirstOrDefault();
            //context.Entry(Emp).Reference(E => E.Department).Load();
            //Console.WriteLine($"ID:{Emp.Id},Name:{Emp.Name}");
            #endregion

            #region Eager Loding
            //var Dep = (from D in context.Department
            //          .Include(D => D.Employees)
            //       where D.Id == 1
            //       select D).FirstOrDefault();
            //foreach (var Emp in Dep.Employees)
            //    Console.WriteLine($"ID:{Emp.Id},Name:{Emp.Name}"); 
            #endregion

            #region Lazy Loding
            var Emp = context.Employees.Where(E => E.Id == 6).FirstOrDefault();
            Console.WriteLine($"ID:{Emp?.Id},Name:{Emp?.Name},Department{Emp?.Department}");
            #endregion

        }
    }
}
