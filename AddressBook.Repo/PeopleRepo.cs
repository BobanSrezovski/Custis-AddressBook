using AddressBook.Data;
using AddressBook.Data.Entities;
using AddressBook.Repo.IRepo;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Repo
{
    public class PeopleRepo : IPeopleRepo
    {
        private readonly AddressBookContext _context;

        public PeopleRepo(AddressBookContext context)
        {
            _context = context;
        }

        public void AddPerson(Person person)
        {
            _context.Add(person);
            _context.SaveChanges();
        }

        public void DeletePerson(int id)
        {
            Person person = _context.Find<Person>(id);
            _context.Remove(person);
            _context.SaveChanges();
        }

        public void EditPerson(Person person)
        {
            _context.Update(person);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Person>> GetAllPeople()
        {
            return await _context.People.ToListAsync();
        }

        public async Task<IEnumerable<Person>> GetFilteredPeople(string searchString)
        {
            return await _context.People.Where(
                    x => x.FirstName.Contains(searchString) ||
                    x.LastName.Contains(searchString) ||
                    x.HomeAddress.Contains(searchString) ||
                    x.WorkAddress.Contains(searchString) ||
                    x.EmailAddress.Contains(searchString)
                ).ToListAsync();
        }

        public async Task<Person> GetPersonById(int id)
        {
            return await _context.People.FindAsync(id);
        }

    }
}
