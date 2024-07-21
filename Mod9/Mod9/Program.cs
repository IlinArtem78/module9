// See https://aka.ms/new-console-template for more informatio









using System.Security.Principal;

public class MyException : Exception
{
    public MyException()
    { }

    public MyException(string message)
        : base(message)
    { }
}

public class HumanException : ArgumentException
{
    public HumanException(string _exceptionMessage) : base(_exceptionMessage) { }
  //  public NTAccount AcouuntDTO { get; set; }


    public AccountDTO Authenticate(string _userName, string _password)
    {
        UserEntity findUser = base.FindByUsername(_userName);
        if (findUser is null) throw new HumanException("Пользователь не найден в системе.");
        if (findUser.password != _password) throw new HumanException("Пароль не корректный.");
        return new AccountDTO(findUser, _token.Generate(findUser.id), roleRepository.FindByUserId(findUser.id));
    }
}



public class ExceptionHandler : ActionFilterAttribute, IExceptionFilter
{
    readonly Error _error = new Error();
    public void OnException(ExceptionContext context)
    {
        _error.Write(context.Exception.ToString());
        string errorMessage = "Произошла непредвиденная ошибка в приложении. Администрация сайта уже бежит на помощь.";
        if (context.Exception is HumanException) errorMessage = context.Exception.Message;
        context.Result = new BadRequestObjectResult(errorMessage);
    }
}