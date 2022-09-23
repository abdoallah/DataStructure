using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataStructure
{
	public class ArrayQueue
	{
		const int Max_Length = 100; 
		private int Rear { get; set; }
		private int front { get; set; }
		private int Length { get; set; }
		int [] arr = new int [Max_Length];
        
        public ArrayQueue(int Front= 0 , int Length = 0 )
		{
			front= Front ;
			Rear= Max_Length-1 ;
			Length = Length ;
		}

		bool IsEmpty()
        {
			return Length == 0; 
        }
		bool IsFull()
        {
            return Length == Max_Length;
        }

	   public void Enqueue(int Element)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full .... ");
                
            }
            else
            {
				Rear = (Rear + 1) % Max_Length;
				arr[Rear] = Element;
				Length++;

            }
        }
		public void DeleteQueue()
        {
            if (IsEmpty())
               Console.WriteLine("empty Queue ... ");
			else
				front = (front + 1) % Max_Length;
				--Length;
        }
		public int GetFront()
        {
            if (IsEmpty())
                return 0;
            else 
                return arr[front];
			
        }
        #region getFront Call by reference
        //Get Front call by reference 
        // in calling we need to intialize a variable and call the the
        //method to put the value insid it 

        //void GetFront(ref int FrontValue)
        //{
        //    FrontValue = arr[front];
        //}
        /// <summary>
        /// this is the call  
        /// int frontvalue ;
        /// GetFront(frontvalue)
        /// </summary>   
        #endregion

       public int  GetRear()
        {
            if (IsEmpty())
                return 0;
            else
                return arr[Rear];
        }
       public void Print()
        {
            for (int i = front; i !=Rear+1; i= (i+1)%Max_Length)
            {
              Console.WriteLine(arr[i]);
            }
        
        }
	}
}
