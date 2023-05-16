namespace MiniProject.Business.Helpers;

public static class Helper
{
    public static Dictionary<string, string> Errors = new Dictionary<string, string>()

    {
       {"AlreadyExceptions" , "This object already exists"},
        {"SizeException", "Length  doesn't match" },
        {"NotValidWordException","Entered word is not valid. Use only letters" },
        {"CapacityNotEnoughException" ,"There is not enought space to perform the operation."}
    };
}

