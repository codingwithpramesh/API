using Mypay.webApi.Data.Interfaces;

namespace Mypay.webApi.Data.Services
{
    public class EmployeeSalaryService
    {
        private readonly IEmployeeSalaryService _service;
        public EmployeeSalaryService(IEmployeeSalaryService service)
        {

            _service = service;

        }
    }
}
