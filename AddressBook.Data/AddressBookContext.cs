using AddressBook.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.Data
{
    public class AddressBookContext : DbContext
    {
        public AddressBookContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Person>().HasData(
                new Person
                {
                    ID = 1,
                    FirstName = "Boban",
                    LastName = "Srezovski",
                    HomeAddress = "Gjorgji Abadziev no.8",
                    MobileNumber = "075-314-353",
                    EmailAddress = @"bobansrezovski@gmail.com"
                }
            );
        }
    }
}
