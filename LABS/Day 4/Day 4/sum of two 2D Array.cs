﻿using System;
using System.Collections.Generic;
using System.Text;
//Program to Add two Matrices
// NOTE:- 2 Matrices with different sizes cannot be added or subtracted , ex: a matrix of size 2x2 and 3x2 cannot be added or subtacrted
namespace Day_4
{
    class Class1
    {
        public static void Main()
        {

            Console.WriteLine("Enter number of Rows of  Array 1: "); //getting size of 2D Array 1
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Columns of  Array 1: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[a, b];
            for (int row = 0; row < a; row++) // getting Array 1 elements from user
            {
                for (int col = 0; col < b; col++)
                {
                    Console.WriteLine("Enter elements of  Array 1" + "[" + row + "," + col + "]");
                    matrix[row, col] = Convert.ToInt32(Console.ReadLine());//Storing elements in Array
                }
            }
            Console.WriteLine("\nElements of  Array 1 are :- \n");
            for (int row = 0; row < a; row++)// Printing Array 1 elements
            {
                for (int col = 0; col < b; col++)
                {
                    Console.Write(matrix[row, col] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("\nEnter number of Rows of  Array 2: "); //getting size of 2D Array 2
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Columns of  Array 2: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int[,] matrix_1 = new int[c, d];
            for (int row_1 = 0; row_1 < c; row_1++) // getting Array 2 elements from user
            {
                for (int col_1 = 0; col_1 < d; col_1++)
                {
                    Console.WriteLine("Enter elements of  Array 2" + "[" + row_1 + "," + col_1 + "]");
                    matrix_1[row_1, col_1] = Convert.ToInt32(Console.ReadLine());//Storing elements in Array
                }
            }
            Console.WriteLine("\nElements of  Array 2 are :- \n");
            for (int row_1 = 0; row_1 < c; row_1++)// Printing Array elements
            {
                for (int col_1 = 0; col_1 < d; col_1++)
                {
                    Console.Write(matrix_1[row_1, col_1] + "\t");

                }
                Console.WriteLine();
            }
            int rowsum = a ;
            int colsum = b;
           //int rowsum = matrix.GetLength(0);
            //int colsum = matrix.GetLength(1);
            int[,] matrixsum = new int[rowsum, colsum];
            for (int i= 0; i<rowsum; i++)
            {
                for (int j = 0; j <colsum; j++)
                {
                    matrixsum[i,j] = matrix[i,j] + matrix_1[i,j];// Adding the elements 
                }
            }
            Console.WriteLine("Sum of Array 1 and Array 2 : ");
            for (int i = 0; i <rowsum; i++) // Printing Sum of Both the Arrays
            {
                for (int j = 0; j <colsum; j++)
                {
                    Console.Write(matrixsum[i,j]+ "\t");
                }
                Console.WriteLine();
            }







        }
    }
    }

