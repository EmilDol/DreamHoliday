using DreamHoliday.Services.Contracts;
using DreamHoliday.ViewModels.Enums;
using DreamHoliday.ViewModels.Office;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DreamHoliday.Controllers
{
    [Authorize]
    public class OfficeController : Controller
    {
        private readonly IOfficeService officeService;
        private readonly ICityService cityService;

        public OfficeController(IOfficeService officeService, ICityService cityService)
        {
            this.officeService = officeService;
            this.cityService = cityService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(OrderDirection order = OrderDirection.Ascending, int agents = 0, int clients = 0, Guid? cityId = null)
        {
            var cities = await cityService.GetAll();
            ViewBag.OrderDirection = order;
            ViewBag.Agents = agents;
            ViewBag.Clients = clients;
            ViewBag.CityId = cityId;
            ViewBag.Cities = cities;
            var offices = await officeService.GetAll(order, agents, clients, cityId);
            return View(offices);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Add()
        {
            var model = new OfficeAddViewModel
            {
                Cities = await cityService.GetAll()
            };
            return View(model);
        }
        
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Add(OfficeAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Cities = await cityService.GetAll();
                return View(model);
            }

            if (!await officeService.Add(model))
            {
                model.Cities = await cityService.GetAll();
                ModelState.AddModelError("Number", "Вече има офис с този номер");
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(Guid id)
        {
            var model = await officeService.GetById(id);
            return View(model);
        }
        
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(OfficeUpdateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (!await officeService.Update(model))
            {
                ModelState.AddModelError("", "Има непредвидена грешка");
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await officeService.Delete(id);
            
            return RedirectToAction(nameof(Index));
        }
    }
}
