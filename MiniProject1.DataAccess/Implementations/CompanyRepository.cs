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

    public List<Company> GetAll()
    {
        return DbContext.Company;
    }

    public List<Company> GetAllByName(string name)
    {
        throw new NotImplementedException();
    }

    public Company? GetByName(string name)
    {
        return DbContext.Company.Find(t => t.Name == name);
    }

}

