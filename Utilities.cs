using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_M3_L1
{
    public class Utilities
    {
		public void ShowList(CustomList alist)
		{
			Console.WriteLine(" ");
			Console.WriteLine("This is your List now:");
			Console.WriteLine(" ");

			IEnumerator<string> iterator = alist.GetEnumerator();
			while (iterator.MoveNext())
			{
				string word = (string)iterator.Current;
				if (false == string.IsNullOrEmpty(word))
                {
					Console.WriteLine(word);
				}
			}
			iterator.Reset();

			Console.WriteLine(" ");
			Console.WriteLine($"Count = {alist.MyCount}");
			Console.WriteLine($"Capacity = {alist.MyCapacity}");

		}
	}
}
