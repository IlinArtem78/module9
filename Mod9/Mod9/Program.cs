// See https://aka.ms/new-console-template for more informatio






class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Выберите способ для вызова делегата 1 или 2"); 
            byte Num = byte.Parse(Console.ReadLine());
            F1 f1 = F2;
            switch (Num)
            {
                case 1:
                    int p1 = f1.Invoke(10, 7);
                    Console.WriteLine("Разность {0}", p1);
                    
                    break; 
                    case 2:
                    int p2 = f1(100, 30);  
                    
                    Console.WriteLine("Разность {0}", p2);
                   
                    break;
                default:
                    throw new Exception("Выход за диапазон");
                    break;

            
            
            }
            
         //   f1.Invoke(10, 7);
         //  Console.WriteLine("Разность {0}", f1.Invoke(10, 7));
            Console.ReadKey();
        }

        catch (Exception ex)
        {

            Console.WriteLine(ex.GetType());
        }
    }

    public delegate int F1(int x, int y);


    static int F2(int x, int y)
    {
        return x - y;
    }

}

