using System;

namespace DataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int TopVal = 0;
            Stack<char> s = new Stack<char>();
            s.Push('w');
            s.Push('w');
            s.Push('w');
            s.Push('w');
            s.Push('w');
            s.Push('w');
            s.pop();
            s.Print();
            //s.GetTop(ref TopVal);

        }
    }
}