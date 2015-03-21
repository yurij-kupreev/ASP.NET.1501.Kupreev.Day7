using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace Task2Tests
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void ElementsMaxAbsIncreasingTestMethod1()
        {
            int[][] matrix = new int[4][]
                {
                new int[] { 1, 1, 1, -10 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 2, -2, -2 },
                new int[] { 4, 4, 5 }
                };
            matrix.SortMatrixMode(new ElementsMaxAbsIncreasing().Compare);

            int[][] expectedMatrix = new int[4][]
                {
                new int[] { 2, -2, -2 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 4, 4, 5 },
                new int[] { 1, 1, 1, -10 }
                };
            Assert.IsTrue(MatrixComparer(matrix, expectedMatrix));
        }

        [TestMethod]
        public void ElementsMaxAbsDecreasingTestMethod1()
        {
            int[][] matrix = new int[4][]
                {
                new int[] { 1, 1, 1, -10 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 2, -2, -2 },
                new int[] { 4, 4, 5 }
                };
            matrix.SortMatrixMode(new ElementsMaxAbsDecreasing().Compare);

            int[][] expectedMatrix = new int[4][]
                {
                new int[] { 1, 1, 1, -10 },
                new int[] { 4, 4, 5 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 2, -2, -2 }
                };
            Assert.IsTrue(MatrixComparer(matrix, expectedMatrix));
        }

        [TestMethod]
        public void ElementsCountIncreasingTestMethod1()
        {
            int[][] matrix = new int[4][]
                {
                new int[] { 1, 1, 1, 1, -10 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 2, -2, -2 },
                new int[] { 4, 5 }
                };
            matrix.SortMatrixMode(new ElementsCountIncreasing().Compare);

            int[][] expectedMatrix = new int[4][]
                {
                new int[] { 4, 5 },
                new int[] { 2, -2, -2 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 1, 1, 1, 1, -10 }
                };
            Assert.IsTrue(MatrixComparer(matrix, expectedMatrix));
        }

        [TestMethod]
        public void ElementsCountDecreasingTestMethod1()
        {
            int[][] matrix = new int[4][]
                {
                new int[] { 1, 1, 1, 1, -10 },
                new int[] { 2, -2, -2 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 4, 5 }
                };
            matrix.SortMatrixMode(new ElementsCountDecreasing().Compare);

            int[][] expectedMatrix = new int[4][]
                {
                new int[] { 1, 1, 1, 1, -10 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 2, -2, -2 },
                new int[] { 4, 5 }
                };
            Assert.IsTrue(MatrixComparer(matrix, expectedMatrix));
        }

        [TestMethod]
        public void ElementsSumIncreasingTestMethod1()
        {
            int[][] matrix = new int[4][]
                {
                new int[] { 1, 1, 2, 10 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 2, 2, 2 },
                new int[] { 4, 4, 5 }
                };

            matrix.SortMatrixMode(new ElementsSumIncreasing().Compare);



            int[][] expectedMatrix = new int[4][]
                {
                new int[] { 2, 2, 2 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 4, 4, 5 },
                new int[] { 1, 1, 2, 10 }
                };

            Assert.IsTrue(MatrixComparer(matrix, expectedMatrix));
        }

        [TestMethod]
        public void ElementsSumDecreasingTestMethod1()
        {
            int[][] matrix = new int[4][]
                {
                new int[] { 1, 1, 2, 10 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 2, 2, 2 },
                new int[] { 4, 4, 5 }
                };

            matrix.SortMatrixMode(new ElementsSumDecreasing().Compare);



            int[][] expectedMatrix = new int[4][]
                {
                new int[] { 1, 1, 2, 10 },
                new int[] { 4, 4, 5 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 2, 2, 2 }
                };

            Assert.IsTrue(MatrixComparer(matrix, expectedMatrix));
        }

        private bool MatrixComparer(int[][] LeftMatrix, int[][] RightMatrix)
        {
            bool goodTest = true;
            for (int i = 0; i < LeftMatrix.Length; ++i)
            {
                for (int j = 0; j < LeftMatrix[i].Length; ++j)
                {
                    if (LeftMatrix[i][j] != RightMatrix[i][j])
                    {
                        goodTest = false;
                        break;
                    }
                }
            }
            return goodTest;
        }
    }
}
