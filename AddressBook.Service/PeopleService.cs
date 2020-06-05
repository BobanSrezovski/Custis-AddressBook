using AddressBook.Data.Entities;
using AddressBook.Repo.IRepo;
using AddressBook.Service.IService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBook.Service
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepo _peopleRepo;

        public PeopleService(IPeopleRepo peopleRepo)
        {
            _peopleRepo = peopleRepo;
        }

        public void AddPerson(Person person)
        {
            _peopleRepo.AddPerson(person);
        }

        public void DeletePerson(int id)
        {
            _peopleRepo.DeletePerson(id);
        }

        public void EditPerson(Person person)
        {
            _peopleRepo.EditPerson(person);
        }

        public Task<IEnumerable<Person>> GetAllPeople()
        {
            return _peopleRepo.GetAllPeople();
        }

        public Task<IEnumerable<Person>> GetFilteredPeople(string searchString)
        {
            return _peopleRepo.GetFilteredPeople(searchString);
        }

        public Task<Person> GetPersonById(int id)
        {
            return _peopleRepo.GetPersonById(id);
        }
    }
}

