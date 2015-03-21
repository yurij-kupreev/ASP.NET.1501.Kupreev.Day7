using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class SortMatrixWithModes
    {
        public delegate int ArrayCompareDelegate(int[] a, int[] b);
        public static void SortMatrixMode(this int[][] matrix, IArrayComparer sortmodes)
        {
            if (matrix == null) throw new ArgumentException();
            BubbleSort.Sort(matrix, sortmodes);
        }
        public static void SortMatrixMode(this int[][] matrix, ArrayCompareDelegate compareMethod)
        {
            if (matrix == null || compareMethod == null) throw new ArgumentException();
            BubbleSort.Sort(matrix, compareMethod);
        }
        
    }
}
