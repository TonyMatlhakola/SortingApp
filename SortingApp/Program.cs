using System;

namespace SortingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("****************** Hello, Welcome to the Sorting Appplicaton ********************");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Please insert a text as input: ");
            string Input = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Input provided : {0}", Input);

            //Remove any punctuation and set to lowercase
            var stringAnalyser = new StringAnalyser();
            Input = stringAnalyser.DiscardPunctuation(Input);

            //Quick sort input
            char[] charArr = Input.ToCharArray();
            var outPut = QuickSort.QuickSortString(charArr);

            //Print results            
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Sorted input Result: {0}", outPut);
            Console.ReadKey();

        }
    }
}

