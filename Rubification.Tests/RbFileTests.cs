using System;
using System.Collections.Generic;
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
			RbFile.ForEachLine("test.txt", line => Console.WriteLine(line));
		}
	}
}
