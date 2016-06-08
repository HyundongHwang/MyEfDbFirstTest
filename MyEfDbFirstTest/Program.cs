using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEfDbFirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Entities())
            {
                context.Database.Log += (log) =>
                {
                    Console.WriteLine($"log : {log}");
                };

                context.Student.Add(new Student
                {
                    LastName = "황",
                    FirstName = "현동",
                    EnrollmentDate = DateTime.Now
                });

                context.SaveChanges();

                var list = context.Student.ToList();
            }
        }
    }
}
