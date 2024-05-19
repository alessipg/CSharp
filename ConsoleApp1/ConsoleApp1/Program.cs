using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        // =========== FUNCTIONS =============
        static void PrintArray(int[] intArray, string mess)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, k);
            }
        }

        static double DoDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }

        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }
        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}",
                name, zipCode);

        }
        public static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;

        }

        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        static double GetSum2(double x = 1, double y = 1)
        {
            return x + y;
        }

        static double GetSum2(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            Console.WriteLine(dblX);
            double dblY = Convert.ToDouble(y);
            Console.WriteLine(dblY);
            return dblX + dblY;
        }
        
        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with the code {1}",
                cc, (int)cc);
        }
        // =========END OF FUNCTIONS ============

        enum CarColor : byte
        {
            Orange = 1,//por padrão a contagem começa em 0
            Blue,
            Green,
            Red,
            Yellow
        }
        static void Main(string[] args)
        {
            /*
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine($"Hello {name},your name is really {name}?");
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);
            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");
            string value = dblFromStr.ToString();
            Console.WriteLine($"Data type : {value.GetType()}");
            

            string randString = "This is a string";
            Console.WriteLine("String Length : {0}",
                randString.Length);
            Console.WriteLine("String Contains is : {0}",
                randString.Contains("is"));
            Console.WriteLine("Index of is : {0}",
                randString.IndexOf("is"));
            Console.WriteLine("Remove String : {0}",
                randString.Remove(10, 6));
            Console.WriteLine("Insert String  : {0}",
                randString.Insert(10, "short "));
            Console.WriteLine("Replace String : {0}",
                randString.Replace("string", "sentence"));
            Console.WriteLine("Compare A to B : {0}",
                String.Compare("A", "B",
                StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("-----------------------------");
            Console.WriteLine("A = a : {0}",
                String.Equals("A","a",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Pad Left : {0}",
                randString.PadLeft(20, '.'));
            Console.WriteLine("Pad Right : {0}",
               randString.PadRight(20, '.'));
            Console.WriteLine("Pad Right : {0}",
               randString.PadRight(20, 'k'));
            Console.WriteLine("Trim : {0}",
               randString.Trim());
            Console.WriteLine("Uppercase : {0}",
                randString.ToUpper());
            Console.WriteLine("Lowecase : {0}",
                randString.ToLower());
            string newString = String.Format("{0} saw a {1} {2} int the {3}",
                "Paul", "rabbit", "eating", "field");
            Console.Write(newString + " \n");
            // \' \" \\ \t \a
            Console.WriteLine(@"Exactly what I typed\n");
            Console.WriteLine("Exactly\' what\" I\t ty\aped\n");

            int[] favNums = new int[3];
            favNums[0] = 23;
            Console.WriteLine("favNum 0 : {0}", favNums[0]);
            string[] customers = { "Bob", "Sally", "Sue" };
            var employees = new[] { "Mike", "Paul", "Rick" };
            object[] randomArray = { "Paul", 45, 1.234 };
            Console.WriteLine("randomArray 0 : {0}",
                randomArray[0].GetType());
            Console.WriteLine("Array Size 0 : {0}", randomArray.Length);
            for(int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Array : {0} : Value {1}",
                    i, randomArray[i]);
            }
            Console.WriteLine("------------------------------------");
            string[,] custNames = new string[2, 2] { {"Bob","Smith" },
            {"Sally", "Smaith" } };
            Console.WriteLine("MD Value : {0}",
                custNames.GetValue(1, 0));
            for(int j = 0; j < custNames.GetLength(0); j++)
            {
                for (int k = 0; k < custNames.GetLength(1); k++)
                {
                    Console.WriteLine("{0} ", custNames[j, k]);
                }
                Console.WriteLine();
            }

            int[] randNums = { 1, 4, 9, 2 };
            PrintArray(randNums, "ForEach");
            Console.WriteLine("------------------------------------");

            Array.Sort(randNums);
            Array.Reverse(randNums);
            Console.WriteLine("1 at index : {0}", Array.IndexOf(randNums, 1));
            randNums.SetValue(0, 1);
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;
            Array.Copy(srcArray, startInd, destArray, 0, length);
            PrintArray(destArray, "Copy");
            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);
            foreach(int i in anotherArray)
            {
                Console.WriteLine("CopyTo : {0}", i);
            }
            
            int age = 17;
            Console.WriteLine("{0}", age >=16 ? true : false);
            switch(age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to Day Care");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Go to Preschool");
                    break;
                case 5: Console.WriteLine("Go to Kindergarten");
                    break;
                default: 
                    Console.WriteLine("Go to another school");
                    goto OtherSchool;
            }
        OtherSchool:
            Console.WriteLine("Elementary, Middle, High School");

            string name2 = "Gabriel";
            string name3 = "gabriel";
            if(name2.Equals(name3, StringComparison.Ordinal)) 
            {
                Console.WriteLine("Names are equal");
            }
            else
            {
                Console.WriteLine("Names aren't equal");
            }
        

            int i = 0;
            while(i <= 10)
            {
                if(i % 2 == 0)
                {
                    i++;
                    continue;
                }
                if (i == 9) break;
                Console.WriteLine(i);
                i++;
            }

            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;
            Console.WriteLine("Random Num : {0}", secretNumber);
            do
            {
                Console.WriteLine("Enter a number between 1 & 10 : ");
                numberGuessed = Convert.ToInt32(Console.ReadLine());
            }while(secretNumber !=  numberGuessed);

            Console.WriteLine("You guessed it it was {0}", secretNumber);
        
            double num1 = 5;
            double num2 = 0;

            try
            {
                Console.WriteLine("5 / 0 = {0}",
                    DoDivision(num1, num2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cleaning Up");
            }
            StringBuilder sb = new StringBuilder("Random Text");
            StringBuilder sb2 = new StringBuilder("More Stuff that is very important", 256);
            Console.WriteLine("Capacity : {0}", sb2.Capacity);
            Console.WriteLine("Length : {0}", sb2.Length);
            sb2.AppendLine("\nMore Important text");
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            string bestCult = "Bob Smith";
            sb2.AppendFormat(enUS, "Best Customer : {0}", bestCult);
            Console.WriteLine(sb2.ToString());
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());
            sb2.Clear();
            sb2.Append("Random Text");
            Console.WriteLine(sb.Equals(sb2));
            sb2.Insert(11, " that's great");
            Console.WriteLine(sb2.ToString());
            sb2.Remove(11, 7);
            Console.WriteLine(sb2.ToString());
            SayHello();
            
            double x = 5;
            double y = 4;
            Console.WriteLine("5 + 4 = {0}", GetSum(x, y));
            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2 = {0}", solution);

            int num3 = 10;
            int num4 = 20;
            Console.WriteLine("Before Swap num1 : {0} num2 : {1}",
                num3, num4);
            Swap(ref num3, ref num4);
            Console.WriteLine("After Swap num1 : {0} num2 : {1}",
                num3, num4);
            
            Console.WriteLine("1+2+3 = {0}", 
                GetSumMore(1, 2, 3));
            Console.WriteLine("1+2+3+4+5 = {0}",
                GetSumMore(1, 2, 3, 4, 5));
            PrintInfo(zipCode: 15147, name: "Gabriel");
            Console.WriteLine("5.0 + 4.0 = {0}",
                GetSum2(5.0, 4.5));
            Console.WriteLine("5.0 + 4.0 = {0}",
                GetSum2("5,0", "4,5"));
            DateTime awesomeDate = new DateTime(2001, 10, 24);
            Console.WriteLine("Day of week : {0}",
                awesomeDate.DayOfWeek);
            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);
            Console.WriteLine("New date : {0}",
                awesomeDate.Date);
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            Console.WriteLine("New Time : {0}",
                lunchTime.ToString());
            */
            CarColor car1 = CarColor.Blue;
            PaintCar(car1);
        } 

    }
}