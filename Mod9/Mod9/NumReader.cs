using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9
{
    public class NumReader
    {
        public delegate void NumberEnter(int value);

        public event NumberEnter NumEnterEvent;

        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Введите значение либо 1, либо 2:");

            int num = int.Parse(Console.ReadLine());
            if (num != 1 && num != 2) { throw new FormatException(); }
            NumberEntered(num);
        }
        protected virtual void NumberEntered(int number)
        {
            NumEnterEvent?.Invoke(number);
        }

    }
}
