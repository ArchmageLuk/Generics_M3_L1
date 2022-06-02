using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_M3_L1
{
    public class Utilities
    {
		public void ShowList(List<string> alist)
		{
			Console.WriteLine(" ");
			Console.WriteLine("This is your List now:");
			Console.WriteLine(" ");
			foreach (var word in alist)
			{
				Console.WriteLine(word);
			}
		}
	}
}
