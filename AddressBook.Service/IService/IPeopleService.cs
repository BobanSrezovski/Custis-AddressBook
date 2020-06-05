using AddressBook.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBook.Service.IService
{
    public interface IPeopleService
    {
        void AddPerson(Person person);
        void EditPerson(Person person);
        void DeletePerson(int id);
        Task<IEnumerable<Person>> GetAllPeople();
        Task<Person> GetPersonById(int id);
        Task<IEnumerable<Person>> GetFilteredPeople(string searchString);
    }
}
