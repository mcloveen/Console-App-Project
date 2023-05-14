using MiniProject.Business.Helpers;
namespace MiniProject.Business.Helpers;

public static class Helper
{
    public static Dictionary<string, string> Errors = new Dictionary<string, string>()

    {
       {"AlreadyExceptions" , "This object already exists"},
        {"SizeException", "Length  doesn't match" },
        {"NotValidWordException","Entered word is not valid. Use only letters" },
        {"CapacityNotEnoughException" ,"Department is already full"}
    };
}

