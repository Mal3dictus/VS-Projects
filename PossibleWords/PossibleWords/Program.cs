using System;
using System.Collections.Generic;

namespace PossibleWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();
            
            HashSet<string> permutations = new HashSet<string>();

            
            Generate(input.ToCharArray(), 0, permutations);

         
            int validCount = 0;
            foreach (var perm in permutations){if (ValidCheck(perm))validCount++;}
            if(validCount >0)Console.WriteLine($"Possible words: {validCount}");
            else Console.WriteLine("No possible words with the certain input given!");
        }

        
        static void Generate(char[] array, int index, HashSet<string> result)
        {
            if (index == array.Length)
            {
                result.Add(new string(array));
                return;
            }

            for (int i = index; i < array.Length; i++)
            {
                Swap(array, i, index);
                Generate(array, index + 1, result);
                Swap(array, i, index); 
            }
        }

        
        static void Swap(char[] array, int i, int j)
        {
            char temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

  
        static bool ValidCheck(string word)
        {
            for (int i = 1; i < word.Length; i++){if (word[i] == word[i - 1]) return false;}
            return true;
        }
    }
}

