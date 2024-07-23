// See https://aka.ms/new-console-template for more informatio

class Program
{
    
    static void Main(string[] args)
    {
        LexusInfo lexus = BuildLexus;
        Car C = lexus("RX");             //-ковариантность
        Console.WriteLine(C.Model);




        ParentInform parent = ParentInfo; ///-контравариантности
        parent.Invoke(new Child());

        Console.Read();

    }

    public delegate Lexus LexusInfo(string name); //

    public delegate void ParentInform(Child children); ///
    private static Lexus BuildLexus(string model) //
    {
        return new Lexus { Model = model };
    }
    ///
    public static void ParentInfo(Parent parent)
    {
        Console.WriteLine(parent);
    }

}
class Car
{
    public string Model { get; set; }
}
class Lexus : Car {

  

}
class Parent { }
class Child : Parent { }



