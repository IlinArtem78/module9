// See https://aka.ms/new-console-template for more informatio

/*
Задание 1
1. Создайте свой тип исключения.
2. Сделайте массив из пяти различных видов исключений, включая собственный тип исключения. 
Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения (блок finally по желанию).
3.В блоке catch выведите в консольном сообщении текст исключения.
 
 
Задание 2 




 
 */

















using Mod9;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Введите выбор программы для запуска 1 или 2"); 
        byte num = byte.Parse(Console.ReadLine());  
        switch(num)
        {
            case 1:
                Task1 task1 = new Task1();
                break;
                case 2:
                Task2 task2 = new Task2();  
                break;
                default:
                Console.WriteLine("Вы ввели неверное значение"); 
                break;
        }


    }
}


