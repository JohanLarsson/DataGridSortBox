using System.Collections;
using System.Collections.Generic;

namespace DataGridSortBox
{
    public class StringLengthComparer : IComparer<string>, IComparer
    {
        public static readonly StringLengthComparer Default = new StringLengthComparer();

        public int Compare(string x, string y)
        {
            if (x == y)
            {
                return 0;
            }

            if (x == null)
            {
                return -1;
            }

            if (y == null)
            {
                return 1;
            }

            return x.Length.CompareTo(y.Length);
        }

        int IComparer.Compare(object x, object y)
        {
            return Compare((string)x, (string)y);
        }
    }
}