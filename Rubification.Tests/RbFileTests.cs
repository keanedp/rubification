using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using Rubification.IO;

namespace Rubification.Tests
{
	[TestFixture()]
	public class RbFileTests
	{
		[Test()]
		public void AsAFileICanForEachLine()
		{
			string filePath = "test.txt";
			string lineOne = "This is line 1";
			string lineTwo = "This is line 2";
			
			using(StreamWriter streamWriter = File.CreateText(filePath))
			{
				streamWriter.WriteLine(lineOne);
				streamWriter.WriteLine(lineTwo);
				streamWriter.Flush();
			}
			
			List<string> lines = new List<string>();
			RbFile.ForEachLine("test.txt", line => lines.Add(line));
			
			Assert.AreEqual(2, lines.Count);
			Assert.AreEqual(lineOne, lines[0]);
			Assert.AreEqual(lineTwo, lines[1]);
			
			File.Delete(filePath);
		}
		
		[Test()]
		[ExpectedException(typeof(FileNotFoundException))]
		public void AsAFileICanThrowFileNotFoundOnForEachLine()
		{
			RbFile.ForEachLine("FileNotFoundException.txt", null);
		}
	}
}
