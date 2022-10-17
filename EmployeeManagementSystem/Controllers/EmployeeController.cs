using System.Security.Cryptography.Xml;
using EmployeeManagementSystem.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private BusinessLogicLayer.BLL bll;
        public EmployeeController()
        {
            bll = new BusinessLogicLayer.BLL();
        }
        [HttpGet]
        [Route("GetEmployees")]
        public List<Employee> GetEmployees()
        {
            return bll.GetEmployees();
        }
        [Route("PostEmployee")]
        [HttpPost]
        public void PostEmployee([FromBody] Employee employee)
        {
            bll.PostEmployee(employee);
        }
        [Route("DeleteEmployee")]
        [HttpDelete]
        public void DeleteEmployee(int EmployeeId)
        {
            bll.DeleteEmployee(EmployeeId);
        }


    }
}
