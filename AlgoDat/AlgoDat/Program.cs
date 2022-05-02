using System;

namespace AlgoDat
{
    interface IDictionary
    {
        bool search(int item);
        //true = gefunden

        bool insert(int item);
        // true = hinzugefüht

        bool delete(int item);
        //true = gelöscht

        void print();
    }

    interface IMultiSetUnsorted : IDictionary
    { }

    interface IMultiSetSorted : IDictionary
    { }

    interface ISetUnsorted : IDictionary
    { }

    interface ISetSorted : IDictionary
    { }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }
}
