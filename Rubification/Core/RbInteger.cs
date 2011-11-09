using System;

namespace Rubification.Core
{
	public static class RbInteger
	{
		#region iterators
		
		public static void Times(this int myNumber, Action<int> block)
		{
		   for(int i = 0; i < myNumber; i++)
		   {
		       block(i);
		   }
		}
		
	 	public static void DownTo(this int myNumber, int downToNumber, Action<int> block)
		{
			while(myNumber >= downToNumber)
			{
			   block(myNumber--);
			}
		}
		
		public static void UpTo(this int myNumber, int upToNumber, Action<int> block)
		{
		    while(myNumber <= upToNumber)
		    {
		      block(myNumber++);
		    }
		}
		
		#endregion
		
		public static bool IsEven(this int myNumber)
		{
		    return (myNumber % 2) == 0;
		}
		
		public static bool IsOdd(this int myNumber)
		{
		    return (myNumber % 2) != 0;
		}
		
		public static int Next(this int myNumber)
		{
			return ++myNumber;	
		}
		
		public static int Succ(this int myNumber)
		{
			return ++myNumber;	
		}
		
		public static int Pred(this int myNumber)
		{
			return --myNumber;	
		}
	}
}