using MiniProject.Core.Entities;
using MiniProject1.DataAccess.Contexts;

namespace MiniProject1.DataAccess.Implementations;

public class CompanyRepository : IRepository<Company>
{
    public void Add(Company entity)
    {
        DbContext.Company.Add(entity);
    }

    public void Delete(Company entity)
    {
        DbContext.Company.Remove(entity);
    }

    public void Update(Company entity)
    {
        Company? cmp = DbContext.Company.Find(t => t.CompanyId == entity.CompanyId);
        cmp.Name = entity.Name;
    }

    public Company? Get(int id)
    {
        return DbContext.Company.Find(t => t.CompanyId == id);
    }

    public List<Company> GetAll(int skip, int take)
    {
        return DbContext.Company.GetRange(skip,take);
    }

    public List<Company> GetAllByName(string name)
    {
        return DbContext.Company.FindAll(comp => comp.Name == name);
    }

    public Company? GetByName(string name)
    {
        return DbContext.Company.Find(comp => comp.Name == name);
    }

}

