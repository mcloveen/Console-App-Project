using MiniProject.Core.Interfaces;

namespace MiniProject.Core.Entities;

public class Department: IEntity
{
    private static int _id;

    public int DepartmentId { get; }

    public string Name { get; set; }

    public int EmployeeLimit { get; set; }

    public int CompanyId { get; set; }

    public Department (string name, int employeelimit)
    {
        Name = name;
        EmployeeLimit = employeelimit;
        DepartmentId = _id;
        _id++;
    }

    public override string ToString()
    {
        return $"{Name}, id: {DepartmentId}";
    }


}



 



