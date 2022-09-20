using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructure
{
    public class Stack<T>
    {
        const int   Max_Size =100;
        public int Top { get; set; }

        T [] Item = new T[Max_Size];

        public Stack(int top = -1 )
        {
            Top = top;
        }

       public void Push (T element)
        {
            if (Top >= Max_Size - 1)
                Console.WriteLine("Stack is full");
            else 
            Top++;
            Item[Top] = element;
           
        }
        bool IsEmpty()
        {
           return  Top<0;
        }
       public void pop()
        {
            if (IsEmpty())
              Console.WriteLine("stack is empty");
            else
            Top--;
            
        }
       public void pop(ref T Elemnt )
        {
            if (IsEmpty())
                Console.WriteLine("stack is empty");
            else
                Elemnt= Item[Top]  ;
                Top--;
        }
        public void  GetTop(ref T StackTop)
        {
            if (IsEmpty())
                Console.WriteLine("stack is empty");
            else
                StackTop = Item[Top];
            Console.WriteLine(StackTop);
        }
         public void Print()
        {
            if (!IsEmpty())
            {
                Console.Write("[");
                for (int i = Top; i >= 0; i--)
                {
                    Console.Write(Item[i] + " ");
                }
                Console.Write("]");
            }
            else
            {
                Console.WriteLine("stack is empty");
            }
            
        }
    }
}
