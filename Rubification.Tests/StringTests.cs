using System;
using System.Collections.Generic;
using NUnit.Framework;
using Rubification.Core;

namespace Rubification.Tests
{
	[TestFixture()]
	public class StringTests
	{
		[Test()]
		public void AsAStringICanCapitalize()
		{
			string allUpperString = "ALLUPPER";
			string allLowerString = "ALLLOWER";
			string mixedcaseString = "MiXEd";
			
			Assert.AreEqual("Allupper", allUpperString.Capitalize());
			Assert.AreEqual("Alllower", allLowerString.Capitalize());
			Assert.AreEqual("Mixed", mixedcaseString.Capitalize());
		}
		
		[Test()]
		public void AsAStringICanRuturnEmptyOnEmptyOrNullCapitalize()
		{
			string emptyString = string.Empty;
			string nullString = null;
			
			Assert.AreEqual(string.Empty, emptyString.Capitalize());
			Assert.AreEqual(string.Empty, nullString.Capitalize());
		}
		
		[Test()]
		public void AsAStringICanIterateEach()
		{
			string testStringEach = "test";
			List<char> charArrayEach = new List<char>();
			
			testStringEach.Each(c => charArrayEach.Add(c));
			Assert.AreEqual(charArrayEach.Count, testStringEach.Length);
		}
		
		[Test()]
		public void AsAStringICanIterateEachCharacter()
		{	
			string testStringEachChar = "test";
			List<char> charArrayEachChar = new List<char>();
			
			testStringEachChar.Each(c => charArrayEachChar.Add(c));
			Assert.AreEqual(charArrayEachChar.Count, testStringEachChar.Length);
		}
	}
}

