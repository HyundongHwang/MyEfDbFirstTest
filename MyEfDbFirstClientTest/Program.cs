using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEfDbFirstClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                context.Database.Log += (log) => 
                {
                    Console.WriteLine($"log : {log}");
                };

                context.Students.Add(new Student
                {
                    LastName = "황",
                    FirstName = "현동",
                    EnrollmentDate = DateTime.Now
                });

                context.SaveChanges();

                var list = context.Students.ToList();
            }
        }
    }
}
