using AddressBook.Data.Entities;
using AddressBook.Service.IService;
using Cuspis_AddressBook.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cuspis_AddressBook.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPeopleService _peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string SearchString)
        {
            var peopleViewModel = new PeopleViewModel();
            if (String.IsNullOrEmpty(SearchString))
            {
                peopleViewModel.People = await _peopleService.GetAllPeople();
            }
            else
            {
                peopleViewModel.People = await _peopleService.GetFilteredPeople(SearchString);
            }
            return View(peopleViewModel);
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _peopleService.AddPerson(person);
                }
                catch (Exception)
                {

                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var person = await _peopleService.GetPersonById(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

        [HttpPost]
        public IActionResult Edit(int id, Person person)
        {
            if (id != person.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _peopleService.EditPerson(person);
                }
                catch (Exception)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var person = await _peopleService.GetPersonById(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var person = await _peopleService.GetPersonById(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                _peopleService.DeletePerson(id);

            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction(nameof(Index));
        }
    }
}