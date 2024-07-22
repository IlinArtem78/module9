// See https://aka.ms/new-console-template for more informatio

class MyClass : Exception { 

    public MyClass()
    {
        MyClass myClass = new MyClass();
        myClass.Data.Add("Дата создания исключения",DateTime.Now);
        //////////////////////////////////////
        
        MyClass myClass2 = new MyClass();
        string errorMessage = "Произошла непредвиденная ошибка в приложении. Администрация сайта уже бежит на помощь.";
        
        
        errorMessage =  myClass2.Message;
        myClass2.HelpLink = "Помощь в пути";

        try
        {

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());   
        }     
    
    }


}

