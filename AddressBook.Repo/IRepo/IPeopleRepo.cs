using AddressBook.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBook.Repo.IRepo
{
    public interface IPeopleRepo
    {
        void AddPerson(Person person);
        void DeletePerson(int id);
        void EditPerson(Person person);
        Task<IEnumerable<Person>> GetAllPeople();
        Task<Person> GetPersonById(int id);
        Task<IEnumerable<Person>> GetFilteredPeople(string searchString);
    }
}
