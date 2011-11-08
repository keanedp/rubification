using System;
using NUnit.Framework;
using Rubification.Core;

namespace Rubification.Tests
{
	[TestFixture()]
	public class RbIntegerTests
	{
		[Test()]
		public void AsAnIntegerICanIterateTenTimes()
		{
			int testInteger = 10;
			int testCounter = 0;
			testInteger.Times(i => testCounter++);
			
			Assert.AreEqual(testInteger, testCounter);
		}
		
		[Test()]
		public void AsAnIntegerICanCountDownTo()
		{
			int testUpperInteger = 10;
			int testLowerInterger = 5;
			int testCounter = 0;
			testUpperInteger.DownTo(testLowerInterger, i => testCounter = i);
			
			Assert.AreEqual(testLowerInterger, testCounter);
		}
		
		[Test()]
		public void AsAnIntegerICanCountUpTo()
		{
			int testUpperInteger = 10;
			int testLowerInterger = 5;
			int testCounter = 0;
			testLowerInterger.UpTo(testUpperInteger, i => testCounter = i);
			
			Assert.AreEqual(testUpperInteger, testCounter);
		}
		
		[Test()]
		public void AsAnIntegerICanTestForEven()  
		{
			int evenInteger = 2;
			Assert.IsTrue(evenInteger.IsEven());
		}
		
		[Test()]
		public void AsAnIntegerICanTestForOdd()  
		{
			int evenInteger = 3;
			Assert.IsTrue(evenInteger.IsOdd());
		}
		
		[Test()]
		public void AsAnIntegerICanIncrementByOne()
		{
			Assert.AreEqual(6, 5.Next());
			Assert.AreEqual(6, 5.Succ());
		}
		
		[Test()]
		public void AsAnIntegerICanDeincrementByOne()
		{
			Assert.AreEqual(4, 5.Pred());
		}
	}
}

