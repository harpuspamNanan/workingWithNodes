using System;
namespace Week01_C0732134
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Operations o = new Operations();
            o.ToInput(numbers);
            o.Calculations(numbers);
            o.MaxNumber(numbers);
            o.MinNumber(numbers);
            o.GettingMedian(numbers);
            o.CalculatingStandardDeviation(numbers, 1.0);
            Console.ReadLine();
        }
    }

    class Operations
    {
        public void ToInput(int[] numbers)
        {
            Console.WriteLine("\nPlease Enter 5 Numbers: ");
            for (int i = 0; i < 5; i++)
                numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        public double Calculations(int[] numbers)
        {

            int sum = 0;
            double avg = 0.0;
            for (int i = 0; i < 5; i++)
            {
                sum += numbers[i];
            }
            avg = sum / 5;
            Console.WriteLine("\nThe Sum Of the Array is : " + sum);
            Console.WriteLine("\nThe Average Of the Array is : " + avg);
            return avg;
        }

        public void MaxNumber(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < 5; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];                    
            }
            Console.WriteLine("\nThe Maximum Number In the Array is : " + max);
        }

        public void MinNumber(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
            }
            Console.WriteLine("\nThe Minimum Number In the Array is : "+min);
        }

        public void GettingMedian(int[] numbers)
        {
            int median = 0, pos1 = 0,pos2 = 0, n= numbers.Length;

            if(n%2 != 0)
            {
                pos1 = ((n + 1) / 2);
                median = numbers[(pos1 - 1)];
            }
            else                                                   // Algorithm Not Checked For Even Case.
            {
                pos1 = (n / 2);
                pos2 = ((n / 2) + 1);
                median = (numbers[pos1] + numbers[pos2] / 2);
            }
            Console.WriteLine("\nThe Median Of the Array is: " + median);
        }

        public void CalculatingStandardDeviation(int[] numbers,double FetchAvg)
        {
            double GettingDifference=0.0, AddingDifference=0.0,
                   CalculateDeviation = 0.0 ,                     //  E|x - mu| ^ 2          E = Sigma
                   DivideByLength = 0.0,                         // ( E|x - mu| ^ 2 ) / n
                   StandardDeviation = 0.0;                     // (( E|x - mu| ^ 2 ) / n ) ^ 1/2)

            for (int i = 0; i < 5; i++)
            {
                GettingDifference = (numbers[i] - FetchAvg);
                CalculateDeviation = Math.Pow(GettingDifference, 2);
                AddingDifference += CalculateDeviation; 
            }
            Console.WriteLine("\n Till Sigma : " + AddingDifference);
            DivideByLength = CalculateDeviation / numbers.Length;
            StandardDeviation = Math.Pow(DivideByLength, 1/2);
            Console.WriteLine("\nLength: "+numbers.Length);
            Console.WriteLine("\nThe Standard Deviation Of the Array is : "+ StandardDeviation);
        }

        public void ShowOutput()
        {
            Console.WriteLine();
        }

    }

}


