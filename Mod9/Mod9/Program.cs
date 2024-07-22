// See https://aka.ms/new-console-template for more informatio






class Program
{
    static void Main(string[] args)
    {
        try
        {
          //  Console.WriteLine("Выберите способ для вызова делегата 1 или 2"); 
          //  byte Num = byte.Parse(Console.ReadLine());

            MyDelegate f1 = F2;
            f1 += F3;

           int p = f1.Invoke(10, 7);
           
           Console.ReadKey();
        }

        catch (Exception ex)
        {

            Console.WriteLine(ex.GetType());
        }
    }

    public delegate int MyDelegate(int x, int y);


    static int F2(int x, int y)
    {
        Console.WriteLine("Разноасть {0}", x-y);
        return x - y;
    }
    static int F3(int x, int y)
    {
        Console.WriteLine("Сумма {0}", x + y);
        return x + y;
    }

}

