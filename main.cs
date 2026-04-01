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

    static void Main(string[] args) {
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

            Console.WriteLine();
         }
    }
}
