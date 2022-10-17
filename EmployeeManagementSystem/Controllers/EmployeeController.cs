using System.Security.Cryptography.Xml;
using EmployeeManagementSystem.DataAccessLayer.Models;
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
            bll=new BusinessLogicLayer.BLL();
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
            var db = new EmployeeManagementContext();
            Employee employee= new Employee();
            employee=db.Employees.FirstOrDefault(x => x.EmployeeId==EmployeeId);
            if (employee == null)
                throw new Exception("Not Found");
            db.Employees.Remove(employee);
            db.SaveChanges();
        }
    }
}
