using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class BubbleSort
    {
        public static void Sort(int[][] matrix, IArrayComparer sortmodes)
        {
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = i + 1; j < matrix.Length; ++j)
                {
                    if (sortmodes.Compare(matrix[i], matrix[j]) > 0)
                    {
                        int[] matrixBuffer;
                        matrixBuffer = matrix[i];
                        matrix[i] = matrix[j];
                        matrix[j] = matrixBuffer;
                    }
                }
            }
        }

        public static void Sort(int[][] matrix, SortMatrixWithModes.ArrayCompareDelegate compareMethod)
        {
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = i + 1; j < matrix.Length; ++j)
                {
                    if (compareMethod(matrix[i], matrix[j]) > 0)
                    {
                        int[] matrixBuffer;
                        matrixBuffer = matrix[i];
                        matrix[i] = matrix[j];
                        matrix[j] = matrixBuffer;
                    }
                }
            }
        }
    }
}
