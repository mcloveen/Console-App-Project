using MiniProject.Business.DTOs.EmployeeDto;
using MiniProject.Business.Exceptions;
using MiniProject.Business.Helpers;
using MiniProject.Business.Interfaces;
using MiniProject.Core.Entities;
using MiniProject1.DataAccess.Contexts;
using MiniProject1.DataAccess.Implementations;

namespace MiniProject.Business.Services;

public class EmployeeService : IEmployeeService
{
    public EmployeeRepository employeeRepository { get; }
    public DepartmentRepository departmentRepository { get;}

    public EmployeeService()
    {
        employeeRepository = new EmployeeRepository();
        departmentRepository = new DepartmentRepository();
    }

    public void Create(EmployeeDto employeeDto)
    {
        var name = employeeDto.name.Trim();

        if (string.IsNullOrEmpty(name))
        {
            throw new NullReferenceException();
        }
        if (!name.IsOnlyLetter())
        {
            throw new NotValidWordException(Helper.Errors["NotValidWordException"]);
        }
        var surname = employeeDto.surname.Trim();
        if (!string.IsNullOrWhiteSpace(employeeDto.surname))
        {
            if (!employeeDto.surname.IsOnlyLetter())
            {
                throw new NotValidWordException(Helper.Errors["NotValidWordException"]);
            }
        }

        var department = departmentRepository.GetByName(employeeDto.departmentName.Trim());
        if (department == null)
        {
            throw new NotFoundException($"{employeeDto.departmentName} - doesn't exist");

        }
        var count = employeeRepository.GetAllByDepartmentId(department.DepartmentId).Count;

        if (count >= department.EmployeeLimit)
        {
            throw new CapacityNotEnoughException(Helper.Errors["CapacityNotEnoughException"]);
        }
        Employee employee = new Employee(name, surname, employeeDto.salary, department.DepartmentId);
        employeeRepository.Add(employee);

    } 

    public void Delete(int id)
    {
        var employee = employeeRepository.Get(id);
        if (employee == null)
        {
            throw new NotValidWordException(Helper.Errors["NotValidWordException"]);
        }
        employeeRepository.Delete(employee);
    }

    public List<Employee> GetAll(int skip, int take)
    {
        if(skip<0 || take < 0)
        {
            throw new InvalidValueException("Value cannot be negative");
        }
        return employeeRepository.GetAll(skip,take);
    }

    public List<Employee> GetEmployeeByDepartmentId(int id)
    {
        var dep = departmentRepository.Get(id);
        if(dep == null)
        {
            throw new NotFoundException("not found");
        }
        return employeeRepository.GetAllByDepartmentId(id);
    }

    public Employee GetEmployeeById(int id)
    {
        var emp = employeeRepository.Get(id);
        if (emp == null)
        {
            throw new NotFoundException("not found");
        }
        return emp;
    }

    public List<Employee> GetEmployeeByName(string name)
    {
        var empName = name.Trim();
        if (string.IsNullOrWhiteSpace(empName))
        {
            throw new NullReferenceException("Name cannot be empty.");
        }
        if (!empName.IsOnlyLetter())
        {
            throw new NotValidWordException(Helper.Errors["NotValidWordException"]);
        }
        return employeeRepository.GetAllByName(name);
    }

    public void Update(int id, EmployeeDto employeedto)
    {
        var employee = DbContext.Employees.Find(emp => emp.EmployeeId == id);
        if (employee == null)
        {
            throw new NotFoundException("you cannot exceed the capacity");
        }
        employee.Name = employeedto.name;
        employee.Surname = employeedto.surname;
        employee.Salary = employeedto.salary;
    }
}

