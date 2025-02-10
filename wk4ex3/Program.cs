using System;

class Program
{
    static void Main()
    {
        //create a 2x3 array and initialize it
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6}
        };

        //print the elements of the matrix in a tabular format
        Console.WriteLine("Matrix:");
        for (int i = 0; i < 2; i++) //loop through rows
        {
            for (int j = 0; j < 3; j++) //loop through columns
            {
                Console.Write(matrix[i, j] + "\t"); //print element with tab spacing
            }
            Console.WriteLine(); //move to next line after each row
        }

        //calculate and print the sum of all elements
        int sum = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                sum += matrix[i, j];
            }
        }
        Console.WriteLine($"\nSum of all elements: {sum}");

        //transpose the matrix (swap rows with columns) and print the transposed matrix
        Console.WriteLine("\nTransposed Matrix:");
        for (int i = 0; i < 3; i++) //loop through columns of original matrix (rows in transposed)
        {
            for (int j = 0; j < 2; j++) //loop through rows of original matrix (columns in transposed)
            {
                Console.Write(matrix[j, i] + "\t"); //print transposed element
            }
            Console.WriteLine(); //move to next line after each row
            Console.ReadLine(); //pause for user to read
        }
    }
}
