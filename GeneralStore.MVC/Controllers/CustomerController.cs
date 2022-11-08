using System.Linq;
using GeneralStore.MVC.Data;
using GeneralStore.MVC.Models.Customer;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using GeneralStore.MVC.Services;

namespace GeneralStore.MVC.Controllers
{
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            List<CustomerIndexModel> customers = await _service.GetAllCustomersAsync();

            return View(customers);
        }

        [Route("Create")]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [Route("Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async IActionResult Create(CustomerCreateModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            return await _service.CreateCustomerAsync(model);
        }
    }
}
