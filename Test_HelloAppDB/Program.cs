using EF2.DB_Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_HelloAppDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using (HelloAppDb db = new HelloAppDb())
            {
                var users = db.Users.ToList();

                Console.WriteLine("Список объектов: ");

                foreach ( var us in users)
                {
                    Console.WriteLine($"{us.Id}\t{us.LastName} {us.FirstName}   {us.Age} лет");
                }
            }
        }
    }
}
