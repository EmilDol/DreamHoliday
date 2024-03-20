using DreamHoliday.Services.Contracts;
using DreamHoliday.ViewModels.Enums;

using Microsoft.AspNetCore.Mvc;

namespace DreamHoliday.Controllers
{
    public class OfficeController : Controller
    {
        private readonly IOfficeService officeService;

        public OfficeController(IOfficeService officeService)
        {
            this.officeService = officeService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(OrderDirection order = OrderDirection.Ascending, int agents = 0, int clients = 0, Guid? cityId = null)
        {
            var offices = await officeService.GetAll(order, agents, clients, cityId);
            return View(offices);
        }
    }
}
