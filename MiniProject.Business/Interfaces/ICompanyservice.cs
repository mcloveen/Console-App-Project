using MiniProject.Core.Entities;

namespace MiniProject.Business.Interfaces;

public interface ICompanyservice
{
    void Create(string name);
    void Delete(string name);

    Company GetById(int id);
    List<Company> GetAll();
}

