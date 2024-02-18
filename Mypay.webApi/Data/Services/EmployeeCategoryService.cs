using Mypay.webApi.Data.Interfaces;

namespace Mypay.webApi.Data.Services
{
    public class EmployeeCategoryService
    {
        private readonly IEmployeeCategoryService _service;
        public EmployeeCategoryService(IEmployeeCategoryService service)
        {

            _service = service;

        }
    }
}
