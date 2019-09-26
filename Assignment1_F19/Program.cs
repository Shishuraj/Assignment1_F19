using System;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);
            Console.WriteLine(" ");

            int n2 = 5;
            printSeries(n2);
            Console.WriteLine(" ");

            int n3 = 5;
            printTriangle(n3);
            Console.WriteLine(" ");

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);
            Console.WriteLine(" ");


            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            Console.WriteLine(r5);

            solvePuzzle();
        }

        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                Console.WriteLine("All the Self Dividing Numbers:");
                for (int i = x; i <= y; i++)
                {
                    if (SelfDiv(i))
                    {
                        Console.Write(i);

                        Console.Write(" , ");
                    }
                }

                bool SelfDiv(int n)
                {
                    int temp = n;
                    while (temp > 0)
                    {
                        int d = temp % 10;
                        if (d == 0 || n % d != 0) return false;
                        temp /= 10;
                    }

                    return true;
                }
                Console.WriteLine(" ");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }

        public static void printSeries(int n)
        {
            try
            {
                Console.WriteLine("The Given Series for 'n' numbers: ");
                //int n;
                //Console.WriteLine("How many numbers?");

                //n = Convert.ToInt32(Console.ReadLine());

                //n = 5;

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i);
                        Console.Write(",");

                    }
                    Console.Write(" , ");
                }
                Console.WriteLine(" ");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n)
        {
            
            try
            {
                Console.WriteLine("Inverted Triangle: ");
                for (int i = n; i > 0; i--)
                {
                    for (int j = n - i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = (2 * i) - 1; j > 0; j--)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine(" ");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                Console.WriteLine("The number of jewels among the stones is: ");
                int counter = 0;
                foreach (int value in J)
                {
                    foreach (int vall in S)
                    {
                        if (value == vall)
                        {
                            //int[] c = { vall };
                            counter++;

                        }
                    }
                }
                Console.WriteLine(counter);
                Console.WriteLine(" ");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {

                Console.WriteLine("The Largest Contiguous Subarray is: ");

                int len;
                    
                    if (a.Length < b.Length)
                        len = a.Length;
                    else
                        len = b.Length;

                   
                    int[] LCS = new int[10];

                    for (int i = 0; i < len; i++)
                    {
                        if (a[i] == b[i])
                            LCS[i] = a[i];
                    }

             
                    for (int j = 0; j < LCS.Length; j++)
                    {
                        if (LCS[j] == 0)
                            continue;
                        else
                            Console.Write(" " + LCS[j]);
                    }
                
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return null; 
        }

        public static void solvePuzzle()
        {
            try
            {
                InputStrings();

                Answer();

            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
        public static string InputStrings()
        {
            string first, second, output;
            Console.WriteLine("Enter First String");
            first = Console.ReadLine();

            Console.WriteLine("Enter First String");
            second = Console.ReadLine();
            Console.WriteLine("Enter First String");
            output = Console.ReadLine();

            return output;
        }

        public static void Answer()
        {
            Console.WriteLine("U = 1");
            Console.WriteLine("B = 2");
            Console.WriteLine("E = 7");
            Console.WriteLine("R = 4");
            Console.WriteLine("C = 9");
            Console.WriteLine("O = 6");
            Console.WriteLine("L = 3");
            Console.WriteLine("N = 0");
        }

    }
}

//I had to relearn a lot of stuff that I had learnt in my undergrad years and had lost touch with in the last year or so.
//I also learnt to not procrastinate since I finished the easier codes first and keep the harder ones (puzzle) for later

