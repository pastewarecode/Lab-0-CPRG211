using System.Drawing;
using System.IO;

namespace Lab_0_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int lowNum = -1;
            int highNum = -1;

            int arraySize = highNum - lowNum + 1;
            int[] arrayOfNum = new int[arraySize];
            

                while (lowNum < 0)
                {
                    Console.WriteLine("Enter a low number:");
                    lowNum = Int32.Parse(Console.ReadLine());
                }

                while (highNum < lowNum)
                {
                    Console.WriteLine("Enter a high number:");
                    highNum = Int32.Parse(Console.ReadLine());
                }

            Program obj = new Program();

            obj.differenceOfNum(lowNum, highNum);

            obj.toArray(lowNum, highNum, arrayOfNum, arraySize);

            obj.WriteData(arrayOfNum);


        }

        public void differenceOfNum(int lowNum, int highNum)
        {

            if (lowNum > highNum)
            {
                int difference = lowNum - highNum;
                Console.WriteLine($"The difference between the numbers are: {difference}");
            }
            else
            {
                int difference = highNum - lowNum;
                Console.WriteLine($"The difference between the numbers are: {difference}");
            }
        }

        private void toArray(int lowNum, int highNum, int[] arrayOfNum, int arraySize)
        {
            arraySize = highNum - lowNum + 1;

            for (int i = 0; i < arraySize; i++)
            {
                arrayOfNum[i] = lowNum + i;
                Console.WriteLine($"This is lownum:{lowNum} + {i}");
            }

            StreamWriter writeData = new StreamWriter("numbers.txt");
            {
                for (int i = 0; i < arraySize; i++)
                {
                    writeData.WriteLine(arrayOfNum[i]);
                }

                Console.WriteLine($"Numbers written to {arrayOfNum}");
            }
        }

        private void WriteData(int[] arrayOfNum)
        {
            //write data from array and output it to numbers.txt
            StreamWriter writer = new StreamWriter("C:\\Users\\codyt\\Desktop\\SAIT Fall 2024\\OOP2 Fall 2024\\Lab 0\\numbers.txt");

            for (int i = 90; i < 10; i++)
            {
                writer.WriteLine("" + arrayOfNum[i]);
            }
            writer.Flush();
            writer.Close();
        }


    }

}
