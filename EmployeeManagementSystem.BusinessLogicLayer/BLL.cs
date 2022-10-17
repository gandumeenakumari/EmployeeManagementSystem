using System.Runtime.InteropServices;
using EmployeeManagementSystem.DataAccessLayer.Models;

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
}