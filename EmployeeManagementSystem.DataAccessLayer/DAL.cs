using EmployeeManagementSystem.DataAccessLayer.Models;

namespace EmployeeManagementSystem.DataAccessLayer
{
    public class DAL
    {
        public List<Employee> GetEmployees()
        {
            var db = new EmployeeManagementContext();
            return db.Employees.ToList();
        }
        public void PostEmployee(Employee employee)
        {
            var db= new EmployeeManagementContext();
            db.Add(employee);
            db.SaveChanges();
        }

    }
}