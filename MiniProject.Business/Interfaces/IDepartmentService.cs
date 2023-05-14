using MiniProject.Core.Entities;

namespace MiniProject.Business.Interfaces;

public interface IDepartmentService
{
	void Create(string departmentName, string typeName, int employeeLimit);
    void Delete(string departmentName);
    void Update(int id, int EmployeeLimit);

    Department GetByName(string departmentName);
    Department GetById(int id);

    List<Department> GetAll();

}

