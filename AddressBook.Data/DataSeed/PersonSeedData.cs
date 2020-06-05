using AddressBook.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AddressBook.Data.DataSeed
{
    public class PersonSeedData
    {
        public static void Initialize(IServiceProvider services)
        {
            using (var context = new AddressBookContext(services.GetRequiredService<DbContextOptions<AddressBookContext>>()))
            {
                if (context.People.Count() > 1)
                {
                    return;   // DB has been seeded
                }
                using (StreamReader r = new StreamReader("personData.json"))
                {

                    string json = r.ReadToEnd();
                    List<Person> people = JsonConvert.DeserializeObject<List<Person>>(json);
                    context.AddRange(people);
                    context.SaveChanges();
                }

            }
        }
    }
}
