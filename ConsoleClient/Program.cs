using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datalayer.Context;
using Datalayer.Models;
using System.Threading.Tasks;
using Datalayer.Repositories;
using Datalayer.Services;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {

            MyContext db = new MyContext();

            //Person p = new Person() {

            //    Name = "Ali",
            //    Family = "Nouri",
            //   WebSite = "Local.Com"
            //};
            //db.Persons.Add(p);
            //db.SaveChanges();


            IPersonRepository personRepository = new PersonRepository(db);


            personRepository.InsertPerson(new Person() {

                Name = "Reza",
                Family = "Asadolahi",
                WebSite = "MCI.org"
            });
            personRepository.Save();
            db.Dispose();
        }
    }
}
