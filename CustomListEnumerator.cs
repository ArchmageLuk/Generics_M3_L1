using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_M3_L1
{
    public class CustomListEnumerator : IEnumerator<string>
    {
        string[] newList;
        int position = -1;
        public CustomListEnumerator(string[] newList)
        {
            this.newList = newList;
        }

        public string Current
        {
            get
            {
                if (position == -1 || position >= newList.Length)
                {
                    throw new InvalidOperationException();
                }
                return newList[position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            if (position < newList.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose() { }
    }
}
