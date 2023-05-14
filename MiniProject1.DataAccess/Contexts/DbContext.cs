using MiniProject.Core.Entities;

namespace MiniProject1.DataAccess.Contexts;

public static class DbContext
{
	public static List<Employee> Employees { get; set; } = new();

    public static List<Department> Departments { get; set; } = new();

    public static List<Company> Company { get; set; } = new();

}

