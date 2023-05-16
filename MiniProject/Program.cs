using MiniProject.Business;
using MiniProject.Business.DTOs.EmployeeDto;
using MiniProject.Business.Services;

EmployeeService employeeService = new EmployeeService();
DepartmentService departmentService = new DepartmentService();
CompanyService companyService = new CompanyService();

Console.WriteLine("Space X:");

Console.WriteLine("Welcome");
MainMenu:
Console.WriteLine("Choose an operation: "
    + "\n"
    + "\n"
    + "1. Emloyee operations"
    + "\n"
    + "2. Department operations"
    + "\n"
    + "3. Company operations"
    + "\n"
    + "4. Exit menu");

int input;
int empMenuInput;
int depMenuInput;
int compMenuInput;
EmployeeDto dto = new("Matthew", "Pleatman", 1000, "Director");

bool check = int.TryParse(Console.ReadLine(), out input);
if (!check)
{
    throw new FormatException("Given value is not valid!");
}

while (true)
{
    switch (input)
    {
        case 4:
            System.Environment.Exit(0);
            break;
        case 1:
            #region employeeOperations
            Console.WriteLine("\n"
                + "1.Add employee: "
                + "\n"
                + "2.Delete employee: "
                + "\n"
                + "3.Update employee: "
                + "\n"
                + "4.Show all employees: "
                + "\n"
                + "5.Show employee by ID: "
                + "\n"
                + "6.Show employee by department ID: "
                + "\n"
                + "7.Show employee by name: "
                + "\n"
                + "8.Go back to main menu: ");
            bool empMenuCheck = int.TryParse(Console.ReadLine(), out empMenuInput);
            switch (empMenuInput)
            {
                case 1:
                    employeeService.Create(dto);
                    break;
                case 2:
                    employeeService.Delete(020);
                    break;
                case 3:
                    employeeService.Update(020, dto);
                    break;
                case 4:
                    employeeService.GetAll(1, 10);
                    break;
                case 5:
                    employeeService.GetEmployeeById(020);
                    break;
                case 6:
                    employeeService.GetEmployeeByDepartmentId(014);
                    break;
                case 7:
                    employeeService.GetEmployeeByName("Matthew");
                    break;
                case 8:
                    goto MainMenu;
                default:
                    break;
            }
            #endregion
            break;
        case 2:
            Console.WriteLine("\n"
                + "1.Add department: "
                + "\n"
                + "2.Delete department: "
                + "\n"
                + "3.Update department: "
                + "\n"
                + "4.Show all departments: "
                + "\n"
                + "5.Show department by ID: "
                + "\n"
                + "6.Show department by name: "
                + "\n"
                + "7.Go back to main menu: ");
            bool depMenuCheck = int.TryParse(Console.ReadLine(), out depMenuInput);
            switch (depMenuInput)
            {
                case 1:
                    departmentService.Create("Venus", "Space X", 1344);
                    break;
                case 2:
                    departmentService.Delete("Director");
                    break;
                case 3:
                    departmentService.Update(1344, 25);
                    break;
                case 4:
                    departmentService.GetAll();
                    break;
                case 5:
                    departmentService.GetById(01344);
                    break;
                case 6:
                    departmentService.GetByName("Director");
                    break;
                case 7:
                    goto MainMenu;
                default:
                    break;
            }
            break;
        case 3:
            Console.WriteLine("\n"
                + "1.Add company: "
                + "\n"
                + "2.Delete company: "
                + "\n"
                + "3.Show all companies: "
                + "\n"
                + "4.Show company by ID: "
                + "\n"
                + "5.Go back to main menu: ");
            bool compMenuCheck = int.TryParse(Console.ReadLine(), out compMenuInput);
            switch (compMenuInput)
            {
                case 1:
                    companyService.Create("Tesla","Venus");
                    break;
                case 2:
                    companyService.Delete("Tesla");
                    break;
                case 3:
                    foreach(var item in companyService.GetAll(0, 1))
                    {
                        Console.WriteLine(item.Name);
                    }
                    break;
                case 4:
                    companyService.GetById(333);
                    break;
                case 5:
                    goto MainMenu;
                default:
                    break;
            }
            break;
        default:
            throw new Exception("Enter valid number!");
    }
}
