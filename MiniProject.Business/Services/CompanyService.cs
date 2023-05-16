using MiniProject.Business.Helpers;
using MiniProject.Business.Interfaces;
using MiniProject.Business.Exceptions;
using MiniProject.Core.Entities;
using MiniProject1.DataAccess.Implementations;

namespace MiniProject.Business;

public class CompanyService : ICompanyservice
{
    public CompanyRepository companyRepository { get; }
    public CompanyService()
    {
        companyRepository = new CompanyRepository();
    }


    public void Create(string name, string surname)
    {
        var exist = companyRepository.GetByName(name);
        if (exist != null)
        {
            throw new AlreadyExceptions(Helper.Errors["AlreadyExceptions"]);
        }
        string name1 = name.Trim();
        if (name1.Length < 2)
        {
            throw new SizeException(Helper.Errors["SizeException"]);
        }

        Company company = new Company(name1);
        companyRepository.Add(company);

    }

    public void Delete(string name)
    {
        throw new NotImplementedException();
    }

    public List<Company> GetAll(int skip, int take)
    {
        return companyRepository.GetAll(skip, take);
    }

    public Company GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Create(string name)
    {
        throw new NotImplementedException();
    }
}

