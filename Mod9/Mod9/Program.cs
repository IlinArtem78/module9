// See https://aka.ms/new-console-template for more informatio

class Program
{
    
    static void Main(string[] args)
    {
        LexusInfo lexus = BuildLexus;
        Car C = lexus("RX");             //ковариантность
        Console.WriteLine(C.Model);


        Console.Read();

    }

    public delegate Lexus LexusInfo(string name);





    private static Lexus BuildLexus(string model)
    {
        return new Lexus { Model = model };
    }

}
class Car
{
    public string Model { get; set; }
}
class Lexus : Car {

  

}




