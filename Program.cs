using System;

namespace DataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Stack Call 
            //int TopVal = 0;
            //Stack<char> s = new Stack<char>();
            //s.Push('w');
            //s.Push('w');
            //s.Push('w');
            //s.Push('w');
            //s.Push('w');
            //s.Push('w');
            //s.pop();
            //s.Print();
            //s.GetTop(ref TopVal);
            #endregion

            #region Queue Call 

            ArrayQueue arrayQueue = new ArrayQueue();
            Q.Enqueue(10);
            Q.Enqueue(20);
            Q.Enqueue(30);
            Q.Enqueue(50);
            #endregion
        }
    }
}