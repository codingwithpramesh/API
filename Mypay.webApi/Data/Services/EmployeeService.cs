using Mypay.webApi.Data.Interfaces;

namespace Mypay.webApi.Data.Services
{
    public class EmployeeService
    {
        private readonly IEmployeeService _Service;
        public EmployeeService(IEmployeeService service) 
        {
            _Service = service;
        }
    }
}
