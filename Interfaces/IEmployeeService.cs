using JWT_Authentication_Authorization.Models;

namespace JWT_Authentication_Authorization.Interfaces
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployeeDetails();
        public Employee AddEmployee(Employee employee);
    }
}
