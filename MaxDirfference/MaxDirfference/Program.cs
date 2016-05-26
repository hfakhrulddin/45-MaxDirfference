using System;

namespace MaxDirfference
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Exit = false;
            while (Exit == false)
            {
                var foos1 = Console.ReadLine();
                string[] arr1 = foos1.Split(',');

                Decimal MaxDif = getSequence(arr1);
                Console.WriteLine(MaxDif);
            }
        }

        public static Decimal getSequence(string[] arr1)
        {
            int l = arr1.Length;

            Decimal BiggestRight = 0;
            Decimal SmallestLeft = 0;

            Decimal maxRigntCurrent = 0;
            Decimal minLeftCurrent = 0;

            int RightSideStart = 0;

            decimal[] right = new decimal[l];
            decimal[] left = new decimal[l];

            for (int x = 0; x < l; x++)
            {
                for (int y = x; y < l; y++)
                {
                    right[y] = Convert.ToDecimal(arr1[y]);
                    maxRigntCurrent = maxRigntCurrent + right[y];

                    if (maxRigntCurrent > BiggestRight)

                    {
                        BiggestRight = maxRigntCurrent;
                        RightSideStart = y;
                    }
                }
                maxRigntCurrent = 0;
            }

            for (int x = 0; x < RightSideStart; x++)
            {
                for (int y = x; y < RightSideStart; y++)
                {
                    left[y] = Convert.ToInt32(arr1[y]);
                    minLeftCurrent = minLeftCurrent + left[y];

                    if (minLeftCurrent < SmallestLeft)
                    {
                        SmallestLeft = minLeftCurrent;
                    }
                }
                minLeftCurrent = 0;
            }
            return (BiggestRight - SmallestLeft);
        }
    }
}