using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_13_Interfaces
{
    //class Example : IDisposable
    //{
        //~Example()
        //{
        //    Console.WriteLine("dfgdfgdf");
        //}

    //    private bool disposedValue;

    //    protected virtual void Dispose(bool disposing)
    //    {
    //        if (!disposedValue)
    //        {
    //            if (disposing)
    //            {
    //                // TODO: dispose managed state (managed objects)
    //            }

    //            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
    //            // TODO: set large fields to null
    //            disposedValue = true;
    //        }
    //    }

    //    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    //    // ~Example()
    //    // {
    //    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //    //     Dispose(disposing: false);
    //    // }

    //    public void Dispose()
    //    {
    //        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //        Dispose(disposing: true);
    //        GC.SuppressFinalize(this);
    //    }
    //}


    class Program
    {
        static void Main(string[] args)
        {
            //Example example = new Example();
            //try
            //{
            //}
            //finally
            //{
            //    example.Dispose();
            //}
            //using (Example example = new Example())
            //{
            //}

            //=============== Collections =================

            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(569);
            //Console.WriteLine($"Count: {arrayList.Count}");
            //Console.WriteLine($"Capacity: {arrayList.Capacity}");

            //arrayList.Add("OK");
            //arrayList.Add(4.123);
            //arrayList.Add(true);
            //Console.WriteLine($"Count: {arrayList.Count}");
            //Console.WriteLine($"Capacity: {arrayList.Capacity}");

            //arrayList.Add(new Exception("Error!"));
            //Console.WriteLine($"\nCount: {arrayList.Count}");
            //Console.WriteLine($"Capacity: {arrayList.Capacity}");

            //arrayList.AddRange(new int[] { 67, 23, 892, 257, 175 });
            //Console.WriteLine($"\nCount: {arrayList.Count}"); //10
            //Console.WriteLine($"Capacity: {arrayList.Capacity}"); //16

            //arrayList.TrimToSize();
            //Console.WriteLine($"\nCount: {arrayList.Count}"); //10
            //Console.WriteLine($"Capacity: {arrayList.Capacity}\n"); //10

            //foreach (object item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            ////arrayList.Sort();


            //arrayList.Remove(4.123);
            //int index = arrayList.LastIndexOf(892);
            //if (index >= 0)
            //{
            //    arrayList.RemoveAt(index);
            //}
            //Console.WriteLine();

            //foreach (object item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            // ======================= Stack ==========================

            //Stack stack = new Stack();

            //Console.WriteLine($"\nCount: {stack.Count}");


            //stack.Push("Hello");
            //stack.Push(123);
            //stack.Push(4.123);

            //Console.WriteLine($"\nCount: {stack.Count}"); 

            //Console.WriteLine(stack.Pop());

            //Console.WriteLine($"\nCount: {stack.Count}");

            //Console.WriteLine(stack.Pop());

            //Console.WriteLine($"\nCount: {stack.Count}");

            //Console.WriteLine(stack.Peek());

            //Console.WriteLine($"\nCount: {stack.Count}");

            //foreach (object item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            // ======================= Queue ==========================

            //Queue queue = new Queue();

            //queue.Enqueue(true);
            //queue.Enqueue(456);
            //queue.Enqueue(4.123);

            //foreach (object item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //queue.Dequeue();
            //Console.WriteLine($"{queue.Peek()}\n");

            //foreach (object item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            // ======================= Hashtable ==========================

            //Hashtable hashtable = new Hashtable();

            //hashtable.Add(27, "No");
            //hashtable.Add(2.132, "No");
            //hashtable.Add("27", "No");

            //foreach (object key in hashtable.Keys)
            //{
            //    Console.WriteLine($"Keys: {key} Value: {hashtable[key]}");
            //}

            //Console.WriteLine();

            //Person person = new Person { name = "Frank" };
            //hashtable.Add(person, 321654.3);

            //foreach (object key in hashtable.Keys)
            //{
            //    Console.WriteLine($"Keys: {key} Value: {hashtable[key]}");
            //}

            // ======================= SortedList ==========================

            SortedList sortedList = new SortedList(new PersonComparer());

            sortedList.Add(new Person { name = "Bob"}, "ok"); // Exception
            sortedList.Add(new Person { name = "Clarck" }, "ok");
            sortedList.Add(new Person { name = "Alma" }, "ok");


            //sortedList.Add(45, 456);
           // sortedList.Add(14, 2.31);

            foreach (Person item in sortedList.Keys)
            {
                Console.WriteLine($"Keys: {item} Value: {sortedList[item]}");
            }
            Console.ReadKey();
        }
    }

    internal class PersonComparer : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            if (x is Person p1 && y is Person p2)
            {
                return p1.name.CompareTo(p2.name);
            }
            throw new ArgumentException();
        }
    }

    class Person
    {
        public string name { get; set; }

        //public override int GetHashCode()
        //{
        //    return 378;
        //}

        public override string ToString()
        {
            return $"name: {name}";
        }
    }
}
