
using EmployeeManagementSystem.DataAccessLayer.Models;
using EmployeeManagementSystem.Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Employee = EmployeeManagementSystem.Entities.Entities.Employee;

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
        public void DeleteEmployee(int EmployeeId)
        {
            var db = new EmployeeManagementContext();
            Employee employee = new Employee();
            employee = db.Employees.FirstOrDefault(x => x.EmployeeId == EmployeeId);
            if (employee == null)
                throw new Exception("Not Found");
            db.Remove(employee);
            db.SaveChanges();
        }

    }
}