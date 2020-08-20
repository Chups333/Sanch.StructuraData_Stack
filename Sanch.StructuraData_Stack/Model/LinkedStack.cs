﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.StructuraData_Stack.Model
{
    public class LinkedStack<T> // опять же неограниченный список
    {
        public Item<T> Head { get; set; }

        public int Count { get; set; }

        public LinkedStack()
        {
            Head = null;
            Count = 0;
        }
        public LinkedStack(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Count = 1;
        }

        public void Push(T data)
        {
            var item = new Item<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;
        }
        public T Pop()
        {
            if (Count > 0)
            {
                var item = Head;
                Head = Head.Previous;
                Count--;
                return item.Data;
            }
            else
            {
                throw new NullReferenceException("Пусто");
            }
        }

        public T Peek()
        {
            if (Count > 0)
            {
                return Head.Data;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }
    }
}
