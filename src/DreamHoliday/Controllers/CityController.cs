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

    }
}
