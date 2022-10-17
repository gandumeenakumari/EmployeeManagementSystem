using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using EmployeeManagementSystem.DataAccessLayer.Models;
using Employee = EmployeeManagementSystem.Entities.Entities.Employee;

namespace EmployeeManagementSystem.BusinessLogicLayer;

public class BLL
{
    private DataAccessLayer.DAL dal;
    public BLL()
    {
        dal = new DataAccessLayer.DAL();
    }
    public List<Employee> GetEmployees()
    {
        List<Employee> employees = dal.GetEmployees();

        return dal.GetEmployees();
    }
    public void PostEmployee(Employee employee)
    {
        dal.PostEmployee(employee);
    }
    public void DeleteEmployee(int EmployeeId)
    {
        
        dal.DeleteEmployee(EmployeeId);
    }
}