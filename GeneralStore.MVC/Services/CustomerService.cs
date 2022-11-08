using GeneralStore.MVC.Data;
using GeneralStore.MVC.Models.Customer;

namespace GeneralStore.MVC.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly GeneralStoreDBContext _context;
        public CustomerService(GeneralStoreDBContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateCustomerAsync(CustomerCreateModel model)
        {
            Customer customer = new Customer()
            {
                Name = model.Name,
                Email = model.Email,
            };

            _context.Customers.Add(customer);
            return await _context.SaveChangesAsync() == 1;
        }
    }
}
