using MiniProject.Business.DTOs.EmployeeDto;
using MiniProject.Core.Entities;

namespace MiniProject.Business.Interfaces;

public interface IEmployeeService
{
    void Create(EmployeeDto employeeDto);

    void Delete(int id);

    void Update(int id, EmployeeDto employeedto);

    List<Employee> GetAll(int skip, int take);

    List<Employee> GetEmployeeByDepartmentId(int id);

    List<Employee> GetEmployeeByName(string name);

    Employee GetEmployeeById(int id);

}
    

