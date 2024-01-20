using System.ComponentModel.Design;

namespace Filling_NonRecurring_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let`s fill your array non with recuring numbers *_*");


            SaftyParsing("Enter the array`s length: ", out int arrLangth);


            int[] nonRecuringArray = new int[arrLangth];

            int arrayMinValue;
            int arrayMaxValue;
            bool isEnough = false;
            do
            {
                SaftyParsing("Which num in ur array will be the smallest? ", out arrayMinValue);
                SaftyParsing("Which num in ur array will be the biggest? ", out arrayMaxValue);

                if (arrLangth <= (arrayMaxValue - arrayMinValue))
                    isEnough = true;
                else
                    isEnough = false;

            } while (!isEnough);
            


            Random random = new Random();


            for (int i = 0; i < nonRecuringArray.Length; i++)
            {
                int curNumb = random.Next(arrayMinValue, arrayMaxValue);

                if (NonRecuringNumber(nonRecuringArray, i, curNumb))
                {
                    nonRecuringArray[i] = curNumb;
                }
                else
                {
                    i--;
                }
            }


            for (int i = 0; i < nonRecuringArray.Length; i++)
            {
                Console.Write($"{nonRecuringArray[i]}\t");
            }
            

        }


        //check for unique
        static bool NonRecuringNumber(int[] arr, int index, int numb)
        {

            for (int i = 0; i < index; i++)
            {
                if (arr[i] == numb)
                {
                    return false;
                }
            }

            return true;
        }



        //parsing safly
        static void SaftyParsing(string message, out int arrLangth)
        {
            bool isSafe = false;
            do
            {
                Console.Write(message);
                isSafe = int.TryParse(Console.ReadLine(), out arrLangth);

            } while (!isSafe);
        }
    }
}