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

    public List<Employee> GetAll()
    {
        return DbContext.Employees;
    }

    public List<Employee> GetAllByName(string name)
    {
        return DbContext.Employees.FindAll(s => s.Name == name);
    }

    public Employee? GetByName(string name)
    {
        throw new NotImplementedException();
    }

}

