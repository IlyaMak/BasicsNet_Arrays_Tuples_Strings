using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseNET_Arrays_cortezhy_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) a)
            bool a = false;
            byte b = 5;
            sbyte c = 6;
            char d = 'c';
            decimal e = 9;
            double f = 3.14;
            float g = 6.1f;
            int h = 1;
            uint i = 7;
            long j = -900;
            ulong k = 900;
            short l = 4;
            ushort m = 17;

            object n = "code";
            string o = "word";
            Console.WriteLine($"1) a) bool - {a} byte - {b} sbyte - {c} char - {d} decimal - {e} double - {f} float - {g} int - {h} uint - {i} long - {j} ulong - {k} short - {l} " +
                $"ushort - {m} object - {n} string - {o}");

            // b)
            dynamic din = "dinam";
            int n1 = 77;
            float n3 = 2.12f;
            uint n5 = 56;
            short n7 = 3;

            string s2 = din;
            long n2 = n1;
            double n4 = n3;
            ulong n6 = n5;
            long n8 = n7;
            Console.WriteLine($"b) {s2} {n2} {n4} {n6} {n8}");

            byte n9 = (byte)n1;
            ushort n10 = (ushort)n7;
            uint n11 = (uint)n1;
            sbyte n12 = (sbyte)n9;
            int n13 = (int)n5;
            Console.WriteLine($"{n9} {n10} {n11} {n12} {n13}");

            char chrNumber = Convert.ToChar(n1);
            double dblNumber = Convert.ToDouble(n1);
            Console.WriteLine($"int = 77, char = {chrNumber}, double = {dblNumber}");

            // c)
            int num = 8;
            Object ob = num;
            num = (int)ob;
            Console.WriteLine($"c) object: {ob} num: {num}");

            // d)
            var num1 = 9;
            Console.WriteLine($"d) {num1.GetType()}");

            // e)
            int? x = null;
            //NULLABLE <int> x = null;

            // f) --- error

            // 2) a)
            string str1 = "string";
            string str2 = "string";
            if (str1 == str2)
                Console.WriteLine("2) a) Strings are equal");
            else
                Console.WriteLine("2) a) Strings aren't equal");

            // b)
            string str3 = "this ";
            string str4 = "is" ;
            string str5 = " string ";
            string str6 = String.Concat(str3, str4, str5);
            str3 = String.Copy(str4);
            string str7 = str3.Substring(0, 2);

            string[] words = str6.Split(' ');
            string str8 = str4.Insert(2, str5);
            string str9 = str6.Remove(1, 2);
            Console.WriteLine($"b) Concat: {str6} str3 Copy str4: {str4} Substring: {str7} Insert: {str8} Remove: {str9}");
            foreach (String s in words)
            {
                Console.WriteLine(s);
            }

            // c)
            string str10 = "";
            string str11 = null;
            bool strBool = string.IsNullOrEmpty(str10);
            Console.WriteLine($"c) string.IsNullOrEmpty = {strBool}");
            if (str11 != str10)
            {
                Console.WriteLine("null and empty strings aren't equals");
            }

            // d)
            StringBuilder sb = new StringBuilder("Sofa");
            sb.Remove(0, 1);
            sb.Insert(0, 'L');
            sb.Insert(4, 's');
            Console.WriteLine($"d) {sb}");

            // 3) a)
            Console.WriteLine("3) a)");
            int[,] mas = new int[3, 3] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };

            for (int c3 = 0; c3 < 3; c3++)
            {
                for (int j2 = 0; j2 < 3; j2++)
                    Console.Write($"{mas[c3, j2]} \t");
                Console.WriteLine();
            }

            // b)
            Console.WriteLine("b)");
            string[] numbers = new string[] { "one", "two", "three", "four", "five" };
            foreach (String nums in numbers)
            {
                Console.Write("{0} ", nums);
            }
            Console.WriteLine($"(Array length - {numbers.Length})");

            Console.WriteLine("Enter index and new value: ");
            int index = Convert.ToInt32(Console.ReadLine());
            string value = Console.ReadLine();
            numbers[index - 1] = value;

            foreach (string item in numbers)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            // c)
            Console.WriteLine("c)");
            int[][] jaggedArray = new int[3][] {new int[2], new int[3], new int[4] };
            Console.WriteLine("Full matrix: ");
            for (int ja1 = 0; ja1 < jaggedArray.Length; ++ja1)
            {
                for (int ja2 = 0; ja2 < jaggedArray[ja1].Length; ++ja2)
                {
                    while(true)
                    {
                        try
                        {
                            jaggedArray[ja1][ja2] = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("Wrong input!");
                        }
                    }
                }
            }
            Console.WriteLine();
            foreach (int[] ja3 in jaggedArray)
            {
                foreach (int ja4 in ja3)
                {
                    Console.Write($"{ja4} \t");
                }
                Console.WriteLine();
            }

            // d)
            var Arr = numbers;
            var str = str1;

            // 4)
            ValueTuple <int, string, char, string, ulong> tup = (20, "Ann", 'c', "satisfaction", 99);
            Console.WriteLine($"4) {tup}");
            Console.WriteLine($"({tup.Item1}, {tup.Item3}, {tup.Item4})");

            var (one, two, three, four, five) = (tup.Item1, tup.Item2, tup.Item3, tup.Item4, tup.Item5);

            // _

            (int, string, char, string, ulong) tup2 = (20, "Ann", 'c', "satisfaction", 99);

            if (tup.Equals(tup2))
            {
                Console.WriteLine("Tuples are equals");
            }

            // 5)
            Console.WriteLine("5)");
            int[] mas2 = new int[4] { 1, 2, 3, 4};
            (int, int, int, char) Func(int[] arrayInt, string string1)
            {
                (int, int, int, char) tup3 = (arrayInt.Min(), arrayInt.Max(), arrayInt.Sum(), string1.First());
                Console.WriteLine(tup3);

                return tup3;
            }

            Func(mas2, str1);

            // 6)
            Console.WriteLine("6)");

            int Func2()
            {
                int ten = 10;
                int val;
                checked
                {
                    val = 2147483647 + ten;
                    Console.WriteLine(val);
                }
                return val;
            }

            int Func3()
            {
                int ten = 10;
                int val;
                unchecked
                {
                    val = 2147483647 + ten;
                    Console.WriteLine(val);
                }
                return val;
            }

            Func2();
            Func3();

        }
    }
}
