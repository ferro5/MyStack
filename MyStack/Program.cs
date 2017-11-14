using System;

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
             
            Console.WriteLine("All elements of stack {0}",stack.Conut);



            var head = stack.Pop();
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            Console.WriteLine("Nov {0} elements",stack.Conut);

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

         public bool IsEmpty()
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
             if (IsEmpty())
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
             int[] tempItems = new int [max];
             for (int i = 0; i < _count; i++)
             {
                 tempItems[i] = _items[i];
             }
             _items = tempItems;
         }

         public override string ToString()
         {
             return string.Format($"");
         }
     }
}
