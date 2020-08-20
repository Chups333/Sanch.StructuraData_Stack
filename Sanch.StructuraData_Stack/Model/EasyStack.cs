using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.StructuraData_Stack.Model
{
    //динамический стек (бесконечный)
    public class EasyStack<T> : ICloneable
    {
        private List<T> items = new List<T>();

        public bool IsEmpty => items.Count == 0;
        /// <summary>
        /// Добавляем вниз в стек элементы(добавляем первые чипсины и проталкиваем вниз)
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            items.Add(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        /// <summary>
        /// Находим последний верхний элемент и удаляем его (вытаскиваем первую чипсину)
        /// </summary>
        /// <returns></returns>
        public T Pop() //int не может возвращать NULL
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }
        /// <summary>
        /// Вызываем последний вверхний элемент(первую чипсину)
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (!IsEmpty)
            {
                return items.LastOrDefault();

            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        public override string ToString()
        {
            return $"Стек с {items.Count} элементами";
        }

        public object Clone() //клонировали список
        {
            var newStack = new EasyStack<T>();
            newStack.items = new List<T>(items);
            return newStack;
        }
    }

}
