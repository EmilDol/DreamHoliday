using System.Formats.Tar;

using DreamHoliday.Services.Contracts;
using DreamHoliday.ViewModels.Country;
using DreamHoliday.ViewModels.Enums;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DreamHoliday.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CountryController : Controller
    {
        private readonly ICountryService countryService;

        public CountryController(ICountryService countryService)
        {
            this.countryService = countryService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(OrderDirection order = OrderDirection.Ascending, string name = "")
        {
            var countries = await countryService.GetAll(order, name);

            ViewBag.Order = order;
            ViewBag.Name = name;

            return View(countries);
        }

        [HttpPost]
        public async Task<IActionResult> Add(string name, string phoneCode)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(phoneCode) || string.IsNullOrEmpty(phoneCode))
            {
                TempData["Error"] = "Полетата \"Име\" и \"Телефонен код\" са задължителни при добавяне на нова държава";
                return RedirectToAction(nameof(Index));
            }

            if (!await countryService.Add(name, phoneCode))
            {
                TempData["Error"] = "Вече има такава държава в базата данни!";
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            if (!await countryService.Delete(id))
            {
                TempData["Error"] = "В тази държава има регистрирани градове!";
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var country = await countryService.GetById(id);
            return View(country);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CountryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (!await countryService.Update(model))
            {
                ModelState.AddModelError("", "Възникна грешка!");
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
