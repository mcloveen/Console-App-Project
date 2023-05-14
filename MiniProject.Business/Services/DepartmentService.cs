using MiniProject.Business.Exceptions;
using MiniProject.Business.Helpers;
using MiniProject.Business.Interfaces;
using MiniProject.Core.Entities;
using MiniProject1.DataAccess.Implementations;

namespace MiniProject.Business.Services;

public class DepartmentService : IDepartmentService
{
    public DepartmentRepository departmentRepository { get; }
    public CompanyRepository companyRepository { get; }
    public DepartmentService()
    {
        companyRepository = new CompanyRepository();
        departmentRepository = new DepartmentRepository();
    }

    public void Create(string departmentName, string typeName, int employeeLimit)
    {
        var name = departmentName.Trim();
        if (string.IsNullOrEmpty(name))
        {
            throw new NullReferenceException();
        }
        if (departmentRepository.GetByName(name) != null)
        {
            throw new AlreadyExceptions(Helper.Errors["AlreadyExceptions"]);
        }

        var companyname1 = companyRepository.GetByName(name);
        if (companyname1 == null)
        {
            throw new NotFoundException($"{typeName} - doesn't exist");
        }

        if (employeeLimit < 2)
        {
            throw new SizeException(Helper.Errors["SizeException"]);
        }

        Department department = new Department(departmentName, employeeLimit);
        departmentRepository.Add(department);
    }

    public void Delete(string departmentName)
    {
        throw new NotImplementedException();
    }

    public List<Department> GetAll()
    {
        throw new NotImplementedException();
    }

    public Department GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Department GetByName(string departmentName)
    {
        throw new NotImplementedException();
    }

    public void Update(int id, int EmployeeLimit)
    {
        throw new NotImplementedException();
    }
}

