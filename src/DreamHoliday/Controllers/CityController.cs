using DreamHoliday.Services.Contracts;
using DreamHoliday.ViewModels.City;
using DreamHoliday.ViewModels.Enums;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DreamHoliday.Controllers
{
    [Authorize(Roles = "Admin, Agent")]
    public class CityController : Controller
    {
        private readonly ICityService cityService;
        private readonly ICountryService countryService;

        public CityController(ICityService cityService, ICountryService countryService)
        {
            this.cityService = cityService;
            this.countryService = countryService;
        }

        public async Task<IActionResult> Index(OrderDirection order = OrderDirection.Ascending, string name = "", Guid? countryId = null, bool destinationOnly = false)
        {
            var cities = await cityService.GetAll(order, name, countryId, destinationOnly);

            ViewBag.Order = order;
            ViewBag.Name = name;
            ViewBag.CountryId = countryId;
            ViewBag.DestinationOnly = destinationOnly;
            ViewBag.Countries = await countryService.GetAll(OrderDirection.Ascending, "");

            return View(cities);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (!await cityService.Delete(id))
            {
                TempData["Error"] = "Градът не може да бъде изтрит";
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Add()
        {
            var model = new CityValidatedViewModel
            {
                Countries = await countryService.GetAll(OrderDirection.Ascending, "")
            };
            return View(model);
        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Add(CityValidatedViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Countries = await countryService.GetAll(OrderDirection.Ascending, "");
                return View(model);
            }

            if (!await cityService.Add(model))
            {
                model.Countries = await countryService.GetAll(OrderDirection.Ascending, "");
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(Guid id)
        {
            var city = await cityService.GetById(id);
            city.Countries = await countryService.GetAll(OrderDirection.Ascending, "");
            return View(city);
        }

        public async Task<IActionResult> Update(CityValidatedViewModel model)
        {
            if (!ModelState.IsValid || model.Id == null || model.Id == Guid.Empty)
            {
                model.Countries = await countryService.GetAll(OrderDirection.Ascending, "");
                return View(model);
            }

            if (await cityService.Update(model))
            {
                return RedirectToAction(nameof(Index));
            }

            ModelState.AddModelError("", "Възникна грешка!");
            return View(model);
        }
    }
}
