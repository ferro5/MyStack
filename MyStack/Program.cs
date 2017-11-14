using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();
            stack.Push(2);
            stack.Push(6);
            stack.Push(5);
            stack.Push(4);
            stack.Push(1);
            stack.Push(3);

            for (int i = 0; i < stack.Conut; i++)
            {
                Console.WriteLine(stack.ToString());
                
            }
            
            

            var head = stack.Pop();
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            for (int i = 0; i < stack.Conut; i++)
            {
                Console.WriteLine(stack.ToString());
            }
            Console.WriteLine(head);
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            head = stack.Peek();
            Console.WriteLine(head);
            Console.ReadKey();
        }
    }

     public class MyStack
     {
         private int[] _items;
         private int _count;
         private int n = 10;

         public MyStack()
         {
             _items = new int[n];
         }

         public MyStack(int lenght)
         {
             _items = new int[lenght];
         }

         public bool isEmpty()
         {
             return _count == 0;
         }

         public int Conut
         {
             get { return _count; }
         }

         public void Push(int item)
         {
             if (_count==_items.Length)
             {
                 Console.WriteLine("Stack is overflow");
             }
             _items[_count++] = item;
         }

         public int Pop()
         {
             if (isEmpty())
             {
                 Console.WriteLine($"Stack is empty");
             }
             int item = _items[--_count];
            _items[_count] = default(int);
             return item;
         }

         public int Peek()
         {
             return _items[_count-1];
         }

         public void Resize(int max)
         {
             
         }

         public override string ToString()
         {
             return string.Format($"");
         }
     }
}
