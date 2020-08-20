using Sanch.StructuraData_Stack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.StructuraData_Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Описание 
            //Стек-пачка принглс-доступ только к первой чипсине на верху (сверху банки)
            //Остальные чипсы нам не доступны
            //Стек можно углибить вниз и назначить новый верхний элемент, но можно и вытащить наверх( второй элемент станет первым) (команды Puch(углубить) и Pop(достать))
            //Стек можно реализовать массивом или листом 
            //Peek - первая чипсина наверху сверху банки
            #endregion

            var easyStack = new EasyStack<int>();
            easyStack.Push(1);
            easyStack.Push(2);
            easyStack.Push(3);

            var item = easyStack.Pop();
            var item2 = easyStack.Peek();

            Console.WriteLine(item);
            Console.WriteLine(item2);

            Console.WriteLine();

            //Stack<double> stack = new Stack<double>(); //готовый уже список со всеми командами
            //stack.Push(1.1);
            //stack.Push(2.1);
            //stack.Push(3.1);

            //var item3 = stack.Pop();
            //var item4 = stack.Peek();

            //Console.WriteLine(item3);
            //Console.WriteLine(item4);

            var linkedStack = new LinkedStack<int>();
            linkedStack.Push(10);
            linkedStack.Push(20);
            linkedStack.Push(30);
            linkedStack.Push(40);
            linkedStack.Push(50);

            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine();

            var arrayStack = new ArrayStack<int>(5);
            arrayStack.Push(100);
            arrayStack.Push(200);
            arrayStack.Push(300);
            arrayStack.Push(400);
            arrayStack.Push(500);
            //arrayStack.Push(600);


            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Peek());

            Console.ReadLine();
        }
    }
}
