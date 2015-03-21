using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ElementsSumIncreasing : IArrayComparer
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null || b == null) throw new ArgumentException();
            return a.Sum().CompareTo(b.Sum());
        }
    }
    public class ElementsSumDecreasing : IArrayComparer
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null || b == null) throw new ArgumentException();
            return b.Sum().CompareTo(a.Sum());
        }
    }
    public class ElementsMaxIncreasing : IArrayComparer
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null || b == null) throw new ArgumentException();
            return a.Max().CompareTo(b.Max());
        }
    }
    public class ElementsMaxDecreasing : IArrayComparer
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null || b == null) throw new ArgumentException();
            return b.Max().CompareTo(a.Max());
        }
    }
    public class ElementsMinIncreasing : IArrayComparer
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null || b == null) throw new ArgumentException();
            return a.Min().CompareTo(b.Min());
        }
    }
    public class ElementsMinDecreasing : IArrayComparer
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null || b == null) throw new ArgumentException();
            return b.Min().CompareTo(a.Min());
        }
    }

    public class ElementsMaxAbsIncreasing : IArrayComparer
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null || b == null) throw new ArgumentException();
            return Math.Max(Math.Abs(a.Max()), Math.Abs(a.Min())).CompareTo(Math.Max(Math.Abs(b.Max()), Math.Abs(b.Min())));
        }
    }
    public class ElementsMaxAbsDecreasing : IArrayComparer
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null || b == null) throw new ArgumentException();
            return Math.Max(Math.Abs(b.Max()), Math.Abs(b.Min())).CompareTo(Math.Max(Math.Abs(a.Max()), Math.Abs(a.Min())));
        }
    }
    public class ElementsCountIncreasing : IArrayComparer
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null || b == null) throw new ArgumentException();
            return a.Length.CompareTo(b.Length);
        }
    }
    public class ElementsCountDecreasing : IArrayComparer
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null || b == null) throw new ArgumentException();
            return b.Length.CompareTo(a.Length);
        }
    }
}
