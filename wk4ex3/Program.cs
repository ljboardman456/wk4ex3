using System;

class Program
{
    static void Main()
    {
        //create a 2x3 multi-dimensional array and initialize it
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6}
        };

        // Step 2: Print the elements of the matrix in a tabular format
        Console.WriteLine("Matrix:");
        for (int i = 0; i < 2; i++) // Loop through rows
        {
            for (int j = 0; j < 3; j++) // Loop through columns
            {
                Console.Write(matrix[i, j] + "\t"); // Print element with tab spacing
            }
            Console.WriteLine(); // Move to next line after each row
        }

        // Step 3: Calculate and print the sum of all elements
        int sum = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                sum += matrix[i, j];
            }
        }
        Console.WriteLine($"\nSum of all elements: {sum}");

        // Step 4: Transpose the matrix (swap rows with columns) and print the transposed matrix
        Console.WriteLine("\nTransposed Matrix:");
        for (int i = 0; i < 3; i++) // Loop through columns of original matrix (rows in transposed)
        {
            for (int j = 0; j < 2; j++) // Loop through rows of original matrix (columns in transposed)
            {
                Console.Write(matrix[j, i] + "\t"); // Print transposed element
            }
            Console.WriteLine(); // Move to next line after each row
        }
    }
}
