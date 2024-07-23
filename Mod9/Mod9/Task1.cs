using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Задание 1
1. Создайте свой тип исключения.
2. Сделайте массив из пяти различных видов исключений, включая собственный тип исключения. 
Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения (блок finally по желанию).
3.В блоке catch выведите в консольном сообщении текст исключения.

 
 */
namespace Mod9
{

    public class NoN : DivideByZeroException 
    {
    }
    public class ArgOutOfRange : ArgumentOutOfRangeException { }
    public class NonDirectory : DirectoryNotFoundException { }

    public class NonFile : FileNotFoundException { }

    public class InvdOperaException : InvalidOperationException { } 



    public class Task1
    {
        public Task1()
        {

            //объявление классов исключений
            NoN noN = new NoN();
            ArgOutOfRange argOutOfRange = new ArgOutOfRange();
            NonDirectory nonDirectory   = new NonDirectory();
            NonFile nonFile = new NonFile();
            InvdOperaException invdOperaException = new InvdOperaException();   

            //создание массива исключений
            ArrayList arrayList = new ArrayList();
     
            arrayList.Add(noN); 
            arrayList.Add(argOutOfRange); 
            arrayList.Add(nonDirectory); 
            arrayList.Add(nonFile); 
            arrayList.Add(invdOperaException);
            //////  
            byte n = 0;
            while (n < arrayList.Count)
            {
                ++n;
                switch (n)
                {
                    case 1:
                        try
                        {
                            throw new NoN();

                        }
                        catch (Exception ex) when (ex is NoN)
                        {
                            Console.WriteLine("На ноль делить нельзя!");

                        }

                        break;
                    case 2:
                        try
                        {
                            throw new ArgOutOfRange();
                        }
                        catch (Exception ex) when (ex is ArgOutOfRange)
                        {
                            Console.WriteLine($"Аргумент находится за пределами диапазона допустимых значений.");
                        }

                        break;
                    case 3:
                        try
                        {

                            throw new NonDirectory();
                        }
                        catch (Exception ex) when (ex is NonDirectory)
                        {
                            Console.WriteLine($"Недопустимая часть пути к каталогу.");
                        }

                        break;
                    case 4:
                        try
                        {
                            throw new NonFile();

                        }
                        catch (Exception ex) when (ex is NonFile)
                        {
                            Console.WriteLine($"Файл не существует.");
                        }

                        break;
                    case 5:
                        try
                        {
                            throw new InvdOperaException();

                        }
                        catch (Exception ex) when (ex is InvdOperaException)
                        {
                            Console.WriteLine($"Вызов метода недопустим в текущем состоянии объекта.");
                        }

                        break;



                        
                }
           



            }
               

                
        }

          



    }
} 

 


  


    

