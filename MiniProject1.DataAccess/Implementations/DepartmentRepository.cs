using MiniProject.Core.Entities;
using MiniProject1.DataAccess.Contexts;

namespace MiniProject1.DataAccess.Implementations;

public class DepartmentRepository : IRepository<Department>
{
    public void Add(Department entity)
    {
        DbContext.Departments.Add(entity);
    }

    public void Delete(Department entity)
    {
        DbContext.Departments.Remove(entity);
    }

    public void Update(Department entity)
    {
        Department? dpt = DbContext.Departments.Find(st => st.DepartmentId == entity.DepartmentId);
        dpt.EmployeeLimit = entity.EmployeeLimit;
        dpt.Name = entity.Name;
    }

    public Department? Get(int id)
    {
        return DbContext.Departments.Find(g => g.DepartmentId == id);
    }

    public List<Department> GetAll()
    {
        return DbContext.Departments;
    }

    public List<Department> GetAllByName(string name)
    {
        return DbContext.Departments.FindAll(g => g.Name == name);
    }

    public Department? GetByName(string name)
    {
        return DbContext.Departments.Find(g => g.Name == name);
    }

}

