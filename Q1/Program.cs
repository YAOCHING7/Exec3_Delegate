using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> items = new List<int> { 1, 5, 3, 22, 66, 77, 111 };
			Func<int, bool> isEven = n => n % 2 == 0;
			List<int> EvenItems = GetEvenItems(items, isEven);
		}

		static List<int> GetEvenItems(List<int> source, Func<int, bool> func)
		{
			var result = new List<int>();

			foreach (int item in source)
			{
				if (func(item) == true)
				{
					result.Add(item);
				}
			}

			return result;
		}
	}
}
