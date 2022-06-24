using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_M3_L1
{
	public class Body
	{
		public void ListInitializer()
		{
			Console.WriteLine("Hello! This your Generic List Modification Application or GLMA");
			Console.WriteLine(" ");

			var randomwords = new CustomList();

			new Utilities().ShowList(randomwords);

			Console.WriteLine(" ");
			Console.WriteLine("Now we will add a new word to the list. Type the word here:");
			string? addword = Console.ReadLine();

			if (addword == null)
			{
				Console.WriteLine("Error");
			}

			randomwords.MyAdd(addword);
			new Utilities().ShowList(randomwords);

			Console.WriteLine(" ");
			Console.WriteLine("Now we will add an array");
			Console.WriteLine("Write words for the array:");
			string? arrayline = Console.ReadLine();
			string[] arraylist = arrayline.Split(" ");
			
			randomwords.MyAddRange(arraylist);
			new Utilities().ShowList(randomwords);

			Console.WriteLine(" ");
			Console.WriteLine("Now we will remove an element from the list.");
			Console.WriteLine("Enter the word you wish to remove");
			var removeword = Console.ReadLine();
			var removed = randomwords.MyRemove(removeword);

			if (removed == true)
            {
				Console.WriteLine(" ");
				Console.WriteLine($"You successfully removed word {removeword}");
				new Utilities().ShowList(randomwords);
			}
            else
            {
				Console.WriteLine(" ");
				Console.WriteLine("Error. No such word in the list");
            }

			Console.WriteLine(" ");
			Console.WriteLine("Now we will remove a word at index");
			Console.WriteLine("Look at full list with indexes:");
			foreach (var word in randomwords)
            {
				var ind = Array.IndexOf(randomwords.MyList, word);
				if (false == string.IsNullOrEmpty(word))
                {
					Console.WriteLine($"{word} is {ind}");
				}
            }

			Console.WriteLine(" ");
			Console.WriteLine("Now enter the index for the word to be removed");
			int index = Convert.ToInt32(Console.ReadLine());

			if (index <= randomwords.MyCount)
			{
				var wordremoved = randomwords.MyList[index];
				randomwords.MyRemoveAt(index);
				Console.WriteLine($"You successfully removed word {wordremoved} with index {index}");
				new Utilities().ShowList(randomwords);
			}
			else
			{
				Console.WriteLine("Error");
			}

			Console.WriteLine(" ");
			Console.WriteLine("And finally, we will sort our list");
			Console.WriteLine("Type Sort to sort");
			string? sort = Console.ReadLine();

			if (sort == "Sort" ^ sort == "sort")
            {
				randomwords.MySort();
			}

			new Utilities().ShowList(randomwords);

			Console.ReadKey();
		}
	}
}
