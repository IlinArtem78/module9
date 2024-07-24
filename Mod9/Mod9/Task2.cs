using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


/*
Задание 2
Создайте консольное приложение, в котором будет происходить сортировка списка фамилий из пяти человек. 
Сортировка должна происходить при помощи события. 
Сортировка происходит при введении пользователем либо числа 1 (сортировка А-Я), либо числа 2 (сортировка Я-А).

Дополнительно реализуйте проверку введённых данных от пользователя через конструкцию 
TryCatchFinally с использованием собственного типа исключения.

 

 */


namespace Mod9
{
    public class Task2
    {
        public List<string> list = new List<string>(); 
     
        public void Sorted(int num)
        {

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Введите имя: ");
                list.Add(Console.ReadLine());
                i++;
            }
            foreach (string name in list)
            {
                Console.WriteLine("Введенные имена");
                Console.WriteLine(name);

            }
            this.list = list;

            try
            {
                    
               
                switch (num)
                {
                    case 1:

                        list.Sort(); //метод list, который используется для "Прямой сортировки"
                        Console.WriteLine("Сортировка от А-Я");
                        foreach (string st in list)
                        {
                            Console.WriteLine(st);
                        }
                        break;

                    case 2:
                        list.Reverse(); //метод list который используется для "обратной" сортировки
                        Console.WriteLine("Сортировка от Я-А");
                        foreach (string st in list)
                        {

                            Console.WriteLine(st);
                        }
                        break;
                    default:
                          throw new Exception();
                        
                        break;

                }
               

            }
            catch(Exception ex) 
            {
                Console.WriteLine("Введено неверное значение");
                Console.WriteLine(ex.Message);           
            }
          
        }


        

        public Task2()
        {
            
            NumReader numReader = new NumReader();
            numReader.NumEnterEvent += Sorted; 
             
                
            try
            {

                numReader.Read();
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено некорректное значение");
            }


        }


    }




}
