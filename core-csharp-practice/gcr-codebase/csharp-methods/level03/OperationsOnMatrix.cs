using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level03
{
    internal class OperationsOnMatrix
    {
        // a. Create a random matrix
        public static double[,] RandomMatrix(int rows, int cols)
        {
            //2D array
            double[,] matrix = new double[rows, cols];
            Random random = new Random();

            //Fill random values 0-->9
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = random.Next(1, 10);

            return matrix;
        }

        // i. Display a matrix
        public static void Display(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            //print matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write($"{matrix[i, j],6:F2}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // b. Add two matrices
        public static double[,] Add(double[,] A, double[,] B)
        {
            int rows = A.GetLength(0);
            int cols = A.GetLength(1);

            //result matrix
            double[,] result = new double[rows, cols];

            //add elements
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = A[i, j] + B[i, j];

            return result;
        }

        // c. Subtract two matrices
        public static double[,] Subtract(double[,] A, double[,] B)
        {
            int rows = A.GetLength(0);
            int cols = A.GetLength(1);

            double[,] result = new double[rows, cols];

            //subtract elements
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = A[i, j] - B[i, j];

            return result;
        }

        // d. Multiply two matrices 
        public static double[,] Multiply(double[,] A, double[,] B)
        {
            int rowsA = A.GetLength(0);
            int colsA = A.GetLength(1);
            int colsB = B.GetLength(1);

            //row of A * columns os B
            double[,] result = new double[rowsA, colsB];

            //multiplication logic
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    for (int k = 0; k < colsA; k++)
                        result[i, j] += A[i, k] * B[k, j];
                }
            }

            return result;
        }

        // 5. Transpose of a matrix
        public static double[,] Transpose(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            //rows*cols
            double[,] transpose = new double[cols, rows];

            //swap
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    transpose[j, i] = matrix[i, j];

            return transpose;
        }

        // e. Determinant of 2x2 matrix
        public static double Determinant2x2(double[,] m)
        {
            //ad-bc
            return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
        }

        // f. Determinant of 3x3 matrix
        public static double Determinant3x3(double[,] m)
        {
            //expansion formula
            return m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1])
                 - m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0])
                 + m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
        }

        // g. Inverse of 2x2 matrix
        public static double[,] Inverse2x2(double[,] m)
        {
            double det = Determinant2x2(m);
            //if det is 0, no inverse 
            if (det == 0) return null;

            double[,] inverse = new double[2, 2];

            inverse[0, 0] = m[1, 1] / det;
            inverse[0, 1] = -m[0, 1] / det;
            inverse[1, 0] = -m[1, 0] / det;
            inverse[1, 1] = m[0, 0] / det;

            return inverse;
        }

        // h. Inverse of 3x3 matrix
        public static double[,] Inverse3x3(double[,] m)
        {
            double det = Determinant3x3(m);

            //if det is 0, no inverse 
            if (det == 0) return null;

            double[,] inv = new double[3, 3];

            //cofactor and adjoint method
            inv[0, 0] = (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) / det;
            inv[0, 1] = (m[0, 2] * m[2, 1] - m[0, 1] * m[2, 2]) / det;
            inv[0, 2] = (m[0, 1] * m[1, 2] - m[0, 2] * m[1, 1]) / det;

            inv[1, 0] = (m[1, 2] * m[2, 0] - m[1, 0] * m[2, 2]) / det;
            inv[1, 1] = (m[0, 0] * m[2, 2] - m[0, 2] * m[2, 0]) / det;
            inv[1, 2] = (m[0, 2] * m[1, 0] - m[0, 0] * m[1, 2]) / det;

            inv[2, 0] = (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]) / det;
            inv[2, 1] = (m[0, 1] * m[2, 0] - m[0, 0] * m[2, 1]) / det;
            inv[2, 2] = (m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]) / det;

            return inv;
        }

        static void Main()
        {
            // Create random matrices
            double[,] A = RandomMatrix(3, 3);
            double[,] B = RandomMatrix(3, 3);

            //display matrix
            Console.WriteLine("Matrix A:");
            Display(A);

            Console.WriteLine("Matrix B:");
            Display(B);

            //perform matrix operation
            Console.WriteLine("A + B:");
            Display(Add(A, B));

            Console.WriteLine("A - B:");
            Display(Add(A, B));

            Console.WriteLine("A x B:");
            Display(Add(A, B));

            Console.WriteLine("Transpose of A:");
            Display(Transpose(A));

            //determinant and inverse
            Console.WriteLine("Determinant of A (3x3): " + Determinant3x3(A));

            Console.WriteLine("\nInverse of A:");
            double[,] invA = Inverse3x3(A);
            if (invA != null)
                Display(invA);
            else
                Console.WriteLine("Inverse does not exist.");
        }

    }
}

        