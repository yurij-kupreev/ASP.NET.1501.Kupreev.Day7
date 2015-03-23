using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class BubbleSort
    {
        public static void Sort(int[][] matrix, SortMatrixWithModes.ArrayCompareDelegate compareMethod)
        {
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = i + 1; j < matrix.Length; ++j)
                {
                    if (compareMethod(matrix[i], matrix[j]) > 0)
                    {
                        Swap(ref matrix[i], ref matrix[j]);
                    }
                }
            }
        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] matrixBuffer;
            matrixBuffer = a;
            a = b;
            b = matrixBuffer;
        }
    }
}
