using AddressBook.Data.Entities;
using System.Collections.Generic;

namespace Cuspis_AddressBook.Models
{
    public class PeopleViewModel
    {
        public IEnumerable<Person> People { get; set; }
        public string SearchString { get; set; }
    }
}
