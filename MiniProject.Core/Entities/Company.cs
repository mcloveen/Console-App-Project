using MiniProject.Core.Interfaces;

namespace MiniProject.Core.Entities;

public class Company:IEntity
{
    private static int _id;

    public string Name { get; set; }

    public int CompanyId { get; }

    public Company ()
    {
        CompanyId = _id;
        _id++;

    }

    public Company (string name) : this()
    {
        Name = name;
    }


}


