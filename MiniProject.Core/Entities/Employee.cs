using MiniProject.Core.Interfaces;

namespace MiniProject.Core.Entities;

public class Employee : IEntity
{
	private static int _id;
	public int EmployeeId { get; }

	public double Salary { get; set; }
	public string Name { get; set; }
	public string Surname { get; set; }
	public int DepartmentId { get; set; }

    

	public Employee (string name, string surname, double salary, int departmentId)
	{
        EmployeeId = _id;
		DepartmentId = departmentId;
        _id++;
        Name = name;
		Surname = surname;
		Salary = salary;

	}

    public override string ToString()
    {
        return $"Name:{Name} Surname: {Surname}, id: {EmployeeId}";
    }


}









