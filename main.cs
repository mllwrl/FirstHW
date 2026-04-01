using System;

namespace StudentHelloWorld
{
    class Program
    {
        static int[] GetEncryptedData() {
            // - The ASCII code of each character was increased by 5 
            return new int[] { 38, 105, 113, 119, 116, 92, 37, 116, 113, 113, 106, 77 };
        }

           // 2. Method to decrypt a single number back into a character
        static char DecryptChar(int encryptedValue, int shift) {
               // Subtract the shift and explicitly cast the number back to char
            return (char)(encryptedValue - shift);
        }

        // --- UPDATED: Iterative Fibonacci function ---
        // Calculates and prints the first n numbers of the sequence
        static void Fib(int n) {
            if (n <= 0) return;

            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++) {
                
                Console.WriteLine(a);
                
                int next = a + b;
                a = b;
                b = next;
            }
        }

        static void Main(string[] args) {

            // --- Part 1: Hello World ---
            int[] data = GetEncryptedData();
            int shiftKey = 5;

            char[] result = new char[data.Length];

            for (int i = 0; i < data.Length; i++) {
                int indexFromEnd = data.Length - 1 - i;

                result[i] = DecryptChar(data[indexFromEnd], shiftKey);
            }

            foreach (char letter in result) {
                 Console.Write(letter);
            }

            Console.WriteLine("\nNext Step: Fibonacci");

            // --- Part 2: Fibonacci ---
            Console.Write("Enter n to calculate Fibonacci: ");
            
            int n = Convert.ToInt32(Console.ReadLine());
            Fib(n);
         }
    }
}
