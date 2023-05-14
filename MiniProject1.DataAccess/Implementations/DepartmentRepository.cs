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
        return DbContext.Departments.Find(depar => depar.DepartmentId == id);
    }

    public List<Department> GetAll(int skip, int take)
    {
        return DbContext.Departments.GetRange(skip,take);
    }

    public List<Department> GetAllByName(string name)
    {
        return DbContext.Departments.FindAll(depar => depar.Name == name);
    }

    public Department? GetByName(string name)
    {
        return DbContext.Departments.Find(depar => depar.Name == name);
    }

}

