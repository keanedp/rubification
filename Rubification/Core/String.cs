using System;
using System.Linq;

namespace Rubification.Core
{
	public static class String
	{
		public static string Capitalize(this string myString)
		{
			if(!string.IsNullOrEmpty(myString) && myString.Length > 0)
				return char.ToUpper(myString[0]) + myString.Substring(1).ToLower();
			
			return string.Empty;
		}
		
		public static void Each(this string myString, Action<char> block)
		{
		   myString.ToCharArray().ToList().ForEach(c => block(c));
		}
		
		public static void EachChar(this string myString, Action<char> block)
		{
		   myString.Each(block);
		}
	}
}

