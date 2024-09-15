using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_M3_L1
{
    public class CustomList : IEnumerable<string>
    {
        public string[] MyList { get; set; }
        public int MyCount = 0; // How many list cells are filled
        public int MyCapacity = 2; // How many cells have a list

        public CustomList()
        {
            string[] newList = { "Longing", "Rusted", "Seventeen", "Daybreak", "Furnace", "Nine", "Benign" };
            MyList = newList;
            MyCapacity = newList.Length;
            MyCount = newList.Length;
        }

        public void MyAdd(string word)
        {
            if (MyCount == MyCapacity)
            {
                string[] addArray = new string[MyCapacity * 2];
                for (int i = 0; i < MyCapacity; i++)
                {
                    addArray[i] = MyList[i];
                }
                addArray[MyCapacity] = word;
                MyList = addArray;
                MyCapacity = MyList.Length;
            }
            else
            {
                for (int i = 0; i < MyCapacity; i++)
                {
                    if (String.IsNullOrEmpty(MyList[i]))
                    {
                        MyList[i] = word;
                        break;
                    }
                }
            }
            MyCount++;
        }

        public void MyAddRange(string[] words)
        {
            foreach (string word in words)
            {
                MyAdd(word);
            }
        }

        public bool MyRemoveAt(int index)
        {
            bool success = false;
            if (index >= MyCapacity ^ index < 0)
            {
                Console.WriteLine("Error. Entry didn`t found in the list");
                success = false;
            }
            else if (index == MyCapacity - 1)
            {
                MyList[index] = string.Empty;
                success = true;
            }
            else
            {
                for (int i = index; i < MyCapacity; i++)
                {
                    if (i < MyCapacity - 1)
                    {
                        MyList[i] = MyList[i + 1];
                    }
                    else
                    {
                        MyList[i] = string.Empty;
                    }
                }
                success = true;
            }

            return success;
        }

        public bool MyRemove(string item)
        {
            int index = Array.IndexOf(MyList, item);
            bool success = MyRemoveAt(index);
            return success;
        }



        public void MySort()
        {
            Array.Sort(MyList);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new CustomListEnumerator(MyList);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
