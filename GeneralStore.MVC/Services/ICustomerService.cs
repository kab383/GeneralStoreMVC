using GeneralStore.MVC.Models.Customer;

namespace GeneralStore.MVC.Services
{
    public class ICustomerService
    {
        public Task<bool> CreateCustomerAsync(CustomerCreateModel model);
        public Task<List<CustomerIndexModel>> GetAllCustomersAsync();
        public Task<CustomerDetailModel> GetCustomerByIdAsync(int id);
        public Task<bool> UpdateCustomerAsync(CustomerEditModel model);
        public Task<bool> DeleteCustomerAsync(int id);
    }
}
