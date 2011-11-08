using System;
using System.IO;

namespace Rubification.IO
{
	public class RbFile
	{
		public static void ForEachLine(string fileName, Action<string> block)
		{	
			using(StreamReader myFile = new StreamReader(fileName))
			{
				string currentLine = null;
				while((currentLine = myFile.ReadLine()) != null)
				{
					block(currentLine);
				}
			}
		}
	}
}

