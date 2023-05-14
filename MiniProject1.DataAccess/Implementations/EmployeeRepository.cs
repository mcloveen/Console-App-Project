using System.Xml.Linq;
using MiniProject.Core.Entities;
using MiniProject1.DataAccess.Contexts;

namespace MiniProject1.DataAccess.Implementations;

public class EmployeeRepository : IRepository<Employee>
{
    public void Add(Employee entity)
    {
        DbContext.Employees.Add(entity);
    }

    public void Delete(Employee entity)
    {
        DbContext.Employees.Remove(entity);
    }

    public void Update(Employee entity)
    {
        Employee? empp = DbContext.Employees.Find(emp => emp.EmployeeId == entity.EmployeeId);
        empp.Name = entity.Name;
        empp.Surname = entity.Surname;
        empp.Salary = entity.Salary;
    }

    public Employee? Get(int id)
    {
        return DbContext.Employees.Find(emp => emp.EmployeeId == id);
    }

    public List<Employee> GetAll(int skip,int take)
    {
        return DbContext.Employees.GetRange(skip,take);
    }

    public List<Employee> GetAllByName(string name)
    {
        return DbContext.Employees.FindAll(emp => emp.Name == name);
    }

    public Employee? GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public List<Employee> GetAllByDepartmentId(int id)
    {
        return DbContext.Employees.FindAll(emp => emp.DepartmentId == id);
    }

}

