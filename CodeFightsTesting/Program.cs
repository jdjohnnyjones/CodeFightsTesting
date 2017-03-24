using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using System.Drawing;
using System.Text.RegularExpressions;


namespace CodeFightsTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //int digitSumVar = digitSumMethod(92);
            //lateRide(240);
            //int[][] matrix = new int[3][];
            //matrix[0] = new int[] { 1, 1, 1 };
            //matrix[1] = new int[] { 2, 2, 2 };
            //matrix[2] = new int[] { 3, 3, 3 };
            int[] a = new int[] { 1, 3, 30, 15, 6, 39, 25, 16, 15, 1 };
            int[] b = new int[] { 40, 40, 40, 40, 40, 40, 40, 40, 40, 40 };
            int[] c = new int[] { 1, 4, 8 };

            Console.WriteLine(avoidObstacles(c).ToString());
 
             //Console.WriteLine(alternatingSums(new int[] { 50, 60, 60, 45, 70 }).ToString());
            //co(de(fight)s)
            //a(bc)(def)g
            //a(bc)(dg)
            Console.Read();
        }

        public static int digitSumMethod(int n)
        {
            // this will return the sum of the digits in the passed integer
            // constraint that integer can only be two digits
            int intCnt = n.ToString().Length;

            if (intCnt != 2)
            {
                throw new System.ArgumentException("Parameter cannot be more than 2 digits.", "original");
            }
            else
            {
                int[] intArray = n.ToString().Select(x => Convert.ToInt32(x.ToString())).ToArray();
                int total = intArray.Sum();
                return total;
            }

        }

        public static int largestNumber(int n)
        {
            // Given an integer n, return the largest number that contains exactly n digits
            // For example if n=2, the output should be 99
            // n must be between 1 and 7


            if (n == 1) { return 9; }
            else if (n == 2) { return 99; }
            else if (n == 3) { return 999; }
            else if (n == 4) { return 9999; }
            else if (n == 5) { return 99999; }
            else if (n == 6) { return 999999; }
            else if (n == 7) { return 9999999; }
            else
            {
                throw new System.ArgumentException("Parameter must between 1 and 7", "original");
            }


            //if (n < 1 || n > 7)
            //{
            //    throw new System.ArgumentException("Parameter must between 1 and 7", "original");
            //}
            //else
            //{
            //    List<int> intList = new List<int>();
            //    intList.Add(1);
            //    int

            //    for(int i = 1; i.ToList().Count <= n; i++)
            //    {

            //    }
            //}


        }

        public static int candies(int NumOfChildren, int NumOfCandies)
        {
            // n children have got m pieces of candy.  They want to eat as much candy as they can, but each child must eat
            // exactly the same amount of candy as any other child.  Determine how many pieces of candy will be eaten by all
            // the children together.  Individual pieces of candy cannot be split.
            // NumOfChildren must be between 1 and 10; NumOfCandies must be between 2 and 100
            // return the number of candies each child gets provided they eat as much as they can and all children get the same amount

            if (NumOfChildren < 1 || NumOfChildren > 10)
            {
                throw new System.ArgumentException("Number of children must be between 1 and 10", "Original");
            }

            if (NumOfCandies < 2 || NumOfCandies > 100)
            {
                throw new System.ArgumentException("Number of candies must be between 2 and 100", "Original");
            }

            int Candies = NumOfCandies / NumOfChildren;


            if (Candies < 1)
            {
                return 0;
            }
            else
            {
                return Candies;
            }

        }

        public static int seatsInTheater(int nCols, int nRows, int col, int row)
        {
            // Given the total number of rows and columns in the theater (nRows and nCols, respectively)
            // , and the row and column you're sitting in, return the number of people who sit strictly 
            // behind you and in your column or to the left, assuming all seats are occupied.
            // nCols = total number of columns in theater 1 <= nCols <= 1000
            // nRows = total number of rows in theater 1 <= nRows <= 1000
            // col = column number of your seat 1 <= col <= nCols
            // row = row number of your seat 1 <= row <= nRows
            // output = number of people who sit strictly behind you and in your column or to your left

            if (nCols < 1 || nCols > 1000)
            {
                throw new System.ArgumentException("Number of total columns must be between 1 and 1000.", "Original");
            }
            if (nRows < 1 || nRows > 1000)
            {
                throw new System.ArgumentException("Number of total rows must be between 1 and 1000.", "Original");
            }
            if (col < 1 || col > nCols)
            {
                throw new System.ArgumentException("Your column must be between 1 and the total number of columns.", "Original");
            }
            if (row < 1 || row > nRows)
            {
                throw new System.ArgumentException("Your row must be between 1 and the total number of rows.", "Original");
            }

            int countRows = nRows - row;
            int countCols = nCols - col + 1;
            int totalAffected = countRows * countCols;

            return totalAffected;
        }

        public static int maxMultiple(int divisor, int bound)
        {
            // Given a divisor and a bound, find the largest integer n such that:
            // n is divisible by divisor
            // n is less than or equal to bound
            // n is greater than 0
            // it is guaranteed that such a number exists

            Decimal boundAsDecimal = Convert.ToDecimal(bound);


            for (Decimal i = Math.Floor(boundAsDecimal); i >= 1; i--)
            {
                if (i % Convert.ToDecimal(divisor) == 0)
                {
                    return Convert.ToInt32(i);
                }
            }

            return 0;

        }

        public static int circleOfNumbers(int n, int firstNumber)
        {
            // Consider integer numbers from 0 to n -1 written down along the circle 
            // in such a way that the distance between any two neighbouring numbers 
            // is equal (note that 0 and n -1 are neighbouring, too).
            // Given n and firstNumber, find the number which is written in the radially 
            // opposite position to firstNumber.
            // n = a positive even integer

            if (n % 2 != 0)
            {
                throw new System.ArgumentException("n must be an even number", "original");
            }
            else if (n < 4 || n > 20)
            {
                throw new System.ArgumentException("n must be between 4 and 20", "original");
            }

            if (firstNumber < 0 || firstNumber > n - 1)
            {
                throw new System.ArgumentException("firstNumber must be between 0 and n - 1", "original");
            }

            int oppositeOfZero = n / 2;
            int oppositeOfN = 0;

            if (firstNumber < oppositeOfZero)
            {
                oppositeOfN = oppositeOfZero + Math.Abs(firstNumber);
            }
            else if (firstNumber == oppositeOfZero)
            {
                oppositeOfN = 0;
            }
            else if (firstNumber > oppositeOfZero)
            {
                oppositeOfN = 0 + (firstNumber - 5);
            }

            return oppositeOfN;
        }

        public static int lateRide(int n)
        {
            // Given a base of 00:00 (hh:mm), and n = the length of the ride in minutes, return an integer
            // that is the sum of the time in military.  For example, if the resulting time = 13:28
            // the return value would be 14 (1 + 3 + 2 + 8)
            // n = length of ride in minutes
            // 0 <= n < 60 * 24 (1440)

            if (n < 0 || n >= 1440)
            {
                throw new System.ArgumentException("n must be between 0 and 1440", "original");
            }

            DateTime dt = new DateTime(2016, 11, 18, 0, 0, 0, DateTimeKind.Utc);

            DateTime newDt = dt.AddMinutes(n);

            string charDigits = newDt.TimeOfDay.ToString();
            string trimDigits = charDigits.Remove(charDigits.Length - 3);

            int removeIndex = charDigits.Length;

            int total = 0;

            foreach (char c in trimDigits.ToCharArray())
            {
                if (c != ':')
                    total = total + Convert.ToInt32(c.ToString());
            }

            return total;
        }

        public static int phoneCall(int min1, int min2_10, int min11, int s)
        {
            // Some phone usage rate may be described as follows:
            // first minute of a call costs min1 cents,
            // each minute from the 2nd up to 10th(inclusive) costs min2_10 cents
            // each minute after 10th costs min11 cents.
            // You have s cents on your account before the call. What is the duration of the
            // longest call(in minutes rounded down to the nearest integer) you can have ?
            // min1 = cost of the first minute of the call in cents :: 1 <= min1 <= 10
            // min2_10 = cost of minutes 2 - 10 of the call :: 1 <= min2_10 <= 10
            // min11 = cost of each minute past 10 minutes :: 1 <= min11 <= 10
            // s = total number of cents on your account :: 2 <= s <= 60

            int minCounter;
            int moneyLeft = s;

            if (moneyLeft - min1 < 0)
            {
                minCounter = 0; // not enough money to make a call at all
                goto Finish;
                //return minCounter;
            }
            else
            {
                moneyLeft = moneyLeft - min1; // money left after first minute
                minCounter = 1; // definitely have enough for one minute
            }

            // moneyLeft = 12

            if (moneyLeft / min2_10 <= 10) // only enough for 10 or less minutes
            {
                minCounter = moneyLeft / min2_10 + 1; // set minCounter to the number of mins available 2 - 10, plus the 1st min
                goto Finish;
                //return minCounter;
            }
            else
            {
                minCounter = 10; // definitely have enough for the first 10 mins
                moneyLeft = moneyLeft - (9 * min2_10);
            }

            minCounter = moneyLeft / min11 + 10;
            goto Finish;

            Finish:
            return minCounter;

        }

        // below is tasks after my shit got reset for not logging in for a while

        public static int centuryFromYear(int year)
        {
            //Given a year, return the century it is in. The first century spans from the year 1 up to and including the year 100, the second - from the year 101 up to and including the year 200, etc.

            //Example

            //For year = 1905, the output should be
            //centuryFromYear(year) = 20;
            //For year = 1700, the output should be
            //centuryFromYear(year) = 17.
            //Input/Output

            //[time limit] 3000ms(cs)
            //[input]
            //    integer year

            //A positive integer, designating the year.

            //Constraints:
            //1 ≤ year ≤ 2005.

            //[output]
            //    integer

            //The number of the century the year is in.

            if (year < 1 || year > 2005)
                throw new System.Exception("year must be between 1 and 2005");

            int century = 0;

            if (year <= 100)
                century = 1;
            else if (year.ToString().Length == 3 && year.ToString().EndsWith("0"))
                century = Convert.ToInt32(year.ToString().Substring(0, 1));
            else if (year.ToString().Length == 3)
                century = Convert.ToInt32(year.ToString().Substring(0, 1)) + 1;
            else if (year.ToString().Length == 4 && year.ToString().EndsWith("0"))
                century = Convert.ToInt32(year.ToString().Substring(0, 2));
            else if (year.ToString().Length == 4)
                century = Convert.ToInt32(year.ToString().Substring(0, 2)) + 1;

            return century;
        }

        public static bool checkPalindrome(string inputString)
        {
            IEnumerable<char> reverseChars = inputString.Reverse();
            string reverseString = "";

            foreach(char c in reverseChars)
                reverseString += c.ToString();

            if (inputString == reverseString)
                return true;
            else
                return false;
        }

        public static int adjacentElementsProduct(int[] inputArray)
        {
            //Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.

            //Example

            //For inputArray = [3, 6, -2, -5, 7, 3], the output should be
            //adjacentElementsProduct(inputArray) = 21.

            //7 and 3 produce the largest product.

            //Input / Output

            //[time limit] 3000ms(cs)
            //[input] array.integer inputArray

            //An array of integers containing at least two elements.

            //Constraints:
            //3 ≤ inputArray.length ≤ 10,
            //-50 ≤ inputArray[i] ≤ 1000.

            //[output] integer

            //The largest product of adjacent elements.

            int highestProduct = -50000;
            int index = 0;
            int thisProduct = -50000;

            if (inputArray.Length < 3 || inputArray.Length > 1000)
                throw new System.Exception("inputArray must be between 3 and 1000");

            if (inputArray.Any(v => v < -50) || inputArray.Any(v => v > 1000))
                throw new System.Exception("digits in inputArray must be between -50 and 1000");

            while (index < inputArray.Count() - 1)
            {
                thisProduct = inputArray.ElementAt(index) * inputArray.ElementAt(index + 1);

                if (thisProduct > highestProduct)
                    highestProduct = thisProduct;

                index++;
            }

            return highestProduct;
        }

        public static int shapeArea(int n)
        {

            //Below we will define what and n - interesting polygon is and your task is to find its area for a given n.

            //A 1 - interesting polygon is just a square with a side of length 1.An n - interesting polygon is 
            //obtained by taking the n - 1 - interesting polygon and appending 1 - interesting polygons to its rim side by side.
            //    You can see the 1 -, 2 - and 3 - interesting polygons in the picture below.

            //Example

            //For n = 2, the output should be
            //shapeArea(n) = 5;
            //        For n = 3, the output should be
            //shapeArea(n) = 13.
            //Input / Output

            //[time limit] 3000ms(cs)
            //[input] integer n

            //Constraints:
            //        1 ≤ n < 104.


            //        [output] integer

            //        The area of the n-interesting polygon.

            int shapeArea = 1;
            int looper = 1;
            int increment = 0;

            if (n < 1 || n > 9999)
                throw new System.Exception("n must be between 1 and 9999");

            while (looper <= n)
            {
                shapeArea += increment;
                looper += 1;
                increment += 4;
            }

            return shapeArea;
        }

        public static int makeArrayConsecutive2(int[] statues)
        {

            //Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, each statue having an non - negative integer size.Since he likes to make things perfect, he wants to arrange them from smallest to largest so that each statue will be bigger than the previous one exactly by 1.He may need some additional statues to be able to accomplish that.Help him figure out the minimum number of additional statues needed.

            //Example

            //For statues = [6, 2, 3, 8], the output should be
            //makeArrayConsecutive2(statues) = 3.

            //Ratiorg needs statues of sizes 4, 5 and 7.

            //Input / Output

            //[time limit] 3000ms(cs)
            //[input] array.integer statues

            //An array of distinct non - negative integers.

            //Constraints:
            //1 ≤ statues.length ≤ 10,
            //0 ≤ statues[i] ≤ 20.

            //[output] integer

            //The minimal number of statues that need to be added to existing statues such that it contains every integer size from an interval [L, R](for some L, R) and no other sizes.

            int statueSizesNeeded = 0;
            int index = 0;

            if (statues.Length < 1 || statues.Length > 10)
                throw new System.Exception("Number of statues must be between 1 and 10");

            if (statues.Any(v => v < 0) || statues.Any(v => v > 20))
                    throw new System.Exception("Statue sizes must be between 0 and 20");

            while (index < statues.Length - 1)
            {
                
                int currentSize = statues.OrderBy(k => k).ElementAt(index);
                int nextSize = statues.OrderBy(k => k).ElementAt(index + 1);

                if (nextSize != currentSize + 1)
                    statueSizesNeeded += nextSize - currentSize - 1;

                index++;
            }

            return statueSizesNeeded;

        }

        public static bool almostIncreasingSequence(int[] sequence)
        {
            //Given a sequence of integers, check whether it is possible to obtain a strictly increasing sequence by erasing no more than one element from it.

            //Example

            //For sequence = [1, 3, 2, 1], the output should be
            //almostIncreasingSequence(sequence) = false;
            //            For sequence = [1, 3, 2], the output should be
            //almostIncreasingSequence(sequence) = true.
            //Input / Output

            //[time limit] 3000ms(cs)
            //[input] array.integer sequence

            //Constraints:
            //            2 ≤ sequence.length ≤ 105,
            //-105 ≤ sequence[i] ≤ 105.

            //[output] boolean

            //true if it is possible, false otherwise.

            bool result;
            int removalsNeeded = 0;
            int index = 0;

            if (sequence.Length < 2 || sequence.Length > 100000)
                throw new System.Exception("Number of integers in sequence must be between 2 and 100,000");
            if (sequence.Any(v => v < -100000) || sequence.Any(v => v > 100000))
                    throw new System.Exception("All integers in sequence must be between -100000 and 100000");            

            while (index < sequence.Length - 1)
            {

                int currentInt = sequence.ElementAt(index);
                int nextInt = sequence.ElementAt(index + 1);

                if (nextInt <= currentInt)
                    removalsNeeded++;

                index++;
            }

            if (removalsNeeded > 1)
                result = false;
            else
                result = true;

            return result;

        }

        public static int matrixElementsSum(int[][] matrix)
        {
            //After becoming famous, CodeBots decided to move to a new building and live together.The building is represented by a rectangular matrix of rooms, each cell containing an integer -the price of the room. Some rooms are free (their cost is 0), but that's probably because they are haunted, so all the bots are afraid of them. That is why any room that is free or is located anywhere below a free room in the same column is not considered suitable for the bots.

            //Help the bots calculate the total price of all the rooms that are suitable for them.

            //Example

            //For

            //matrix = [[0, 1, 1, 2],
            //          [0, 5, 0, 0],
            //          [2, 0, 3, 3]]
            //the output should be
            //matrixElementsSum(matrix) = 9.

            //Here's the rooms matrix with unsuitable rooms marked with 'x':

            //[[x, 1, 1, 2],
            // [x, 5, x, x],
            // [x, x, x, x]]
            //Thus, the answer is 1 + 5 + 1 + 2 = 9.

            //Input / Output

            //[time limit] 3000ms(cs)
            //[input] array.array.integer matrix

            //2 - dimensional array of integers representing a rectangular matrix of the building.

            //Constraints:
            //1 ≤ matrix.length ≤ 5,
            //1 ≤ matrix[0].length ≤ 5,
            //0 ≤ matrix[i][j] ≤ 10.

            //[output] integer

            int sum = 0;
            List<int> excludedIndexes = new List<int>();
            int arrayIndex = 0;

            if (matrix.Length < 1 || matrix.Length > 5)
                throw new System.Exception("Total number of items in matrix must be between 1 and 5.");

            foreach (int[] intArray in matrix)
            {
                if (intArray.Length < 1 || intArray.Length > 5)
                    throw new System.Exception("Total number of items in each array must be between 1 and 5.");

                foreach (int i in intArray)
                {
                    if (i < 0 || i > 10)
                        throw new System.Exception("Each integer must be between 0 and 10.");

                    if (i == 0)
                        excludedIndexes.Add(arrayIndex);

                    if (!excludedIndexes.Contains(arrayIndex))
                        sum += i;

                    arrayIndex++;
                }

                arrayIndex = 0;
            }

            return sum;
        }

        public static string[] allLongestStrings(string[] inputArray)
        {
            //Given an array of strings, return another array containing all of its longest strings.

            //Example

            //For inputArray = ["aba", "aa", "ad", "vcd", "aba"], the output should be
            //allLongestStrings(inputArray) = ["aba", "vcd", "aba"].

            //Input / Output

            //[time limit] 3000ms(cs)
            //[input]
            //        array.string inputArray

            //A non-empty array.

            //Constraints:
            //1 ≤ inputArray.length ≤ 10,
            //1 ≤ inputArray[i].length ≤ 10.

            //[output] array.string

            //Array of the longest strings, stored in the same order as in the inputArray.

            List<string> longestStrings = new List<string>();

            if (inputArray.Length < 1 || inputArray.Length > 10)
                throw new System.Exception("Number of items in array must be between 1 and 10.");
            if (inputArray.Any(v => v.Length < 1) || inputArray.Any(v => v.Length > 10))
                throw new System.Exception("Each string must be between 1 and 10 characters.");

            int longestStringCharCount = inputArray.OrderByDescending(v => v.Length).First().Length;

            longestStrings.AddRange(inputArray.Where(v => v.Length == longestStringCharCount));

            return longestStrings.ToArray();

        }

        public static int commonCharacterCount(string s1, string s2)
        {
            int commonCharCount = 0;
            string lString;
            string sString;

            if (s1.Length > s2.Length)
            {
                lString = s1;
                sString = s2;
            }
            else
            {
                lString = s2;
                sString = s1;
            }

            List<char> lStringList = lString.ToList();
            List<char> sStringList = sString.ToList();

            foreach (char c in sStringList)
            {
                if (lStringList.Contains(c))
                    commonCharCount++;

                lStringList.Remove(c);
            }

            return commonCharCount;
        }

        public static bool isLucky(int n)
        {
            //Ticket numbers usually consist of an even number of digits. A ticket number is considered lucky if the sum of the first half of the digits is equal to the sum of the second half.

            //Given a ticket number n, determine if it's lucky or not.

            //Example

            //For n = 1230, the output should be
            //isLucky(n) = true;
            //            For n = 239017, the output should be
            //isLucky(n) = false.
            //Input / Output

            //[time limit] 3000ms(cs)
            //[input] integer n

            //A ticket number represented as a positive integer with an even number of digits.

            //Constraints:
            //            10 ≤ n < 106.


            //            [output] boolean

            //true if n is a lucky ticket number, false otherwise.

            bool result;

            if (n < 10 || n > 1000000)
                throw new System.Exception("n must be between 10 and 1,000,000.");

            if (n.ToString().Length % 2 != 0)
                throw new System.Exception("Ticket number must have even number of digits.");

            if (n.ToString().Substring(0, n.ToString().Length / 2).ToArray().Sum(v => (int)v) ==
                (n.ToString().Substring(n.ToString().Length / 2).ToArray().Sum(v => (int)v)))
                result = true;
            else
                result = false;

            return result;

        }

        public static int[] sortByHeight(int[] a)
        {
            //Some people are standing in a row in a park. There are trees between them which cannot be moved.Your task is to rearrange the people by their heights in a non-descending order without moving the trees.

            //Example

            //For a = [-1, 150, 190, 170, -1, -1, 160, 180], the output should be
            //sortByHeight(a) = [-1, 150, 160, 170, -1, -1, 180, 190].

            //Input / Output

            //[time limit] 3000ms(cs)
            //[input] array.integer a

            //If a[i] = -1, then the ith position is occupied by a tree.Otherwise a[i] is the height of a person standing in the ith position.

            //Constraints:
            //5 ≤ a.length ≤ 15,
            //-1 ≤ a[i] ≤ 200.

            //[output] array.integer

            //Sorted array a with all the trees untouched.

            List<int> originalList = a.ToList();
            List<int> sortedList = new List<int>();
            int index = 0;

            while(index <= a.Length - 1)
            {
                int currentValue = a.ElementAt(index);

                if (currentValue == -1)
                {
                    sortedList.Add(-1);
                    originalList.Remove(-1);
                }
                else
                {
                    int minValue = originalList.OrderBy(v => v).Where(v => v != -1).First();
                    sortedList.Add(minValue);
                    originalList.Remove(minValue);
                }

                index++;
            }

            return sortedList.ToArray();
        }

        public static string reverseParentheses(string s)
        {
            //You are given a string s that consists of English letters, punctuation marks, whitespace characters and brackets.It is guaranteed that the brackets in s form a regular bracket sequence.

            //Your task is to reverse the strings in each pair of matching parenthesis, starting from the innermost one.

            //Example

            //For string "s = a(bc)de" the output should be

            //reverseParentheses(s) = "acbde".

            //Input / Output

            //[time limit] 3000ms(cs)
            //[input] string s

            //A string consisting of English letters, punctuation marks, whitespace characters and brackets.It is guaranteed that parenthesis form a regular bracket sequence.

            //Constraints:

            //5 ≤ x.length ≤ 55.

            //[output] string

            return reverse(s);
        }

        public static string reverse(string s)
        {
            // this method goes with reverseParentheses()
            var l = s.LastIndexOf('(');
            if (l == -1)
                return s;
            var r = s.IndexOf(')', l);
            var arr = s.Substring(l + 1, r - l - 1).ToCharArray();
            Array.Reverse(arr);
            return reverse(s.Substring(0, l) + new string(arr) + s.Substring(r + 1));
        }

        public static int[] alternatingSums(int[] a)
        {
            //Several people are standing in a row and need to be divided into two teams.The first person goes into team 1, the second goes into team 2, the third goes into team 1 again, the fourth into team 2, and so on.

            //You are given an array of positive integers -the weights of the people.Return an array of two integers, where the first element is the total weight of team 1, and the second element is the total weight of team 2 after the division is complete.

            //Example

            //For a = [50, 60, 60, 45, 70], the output should be
            //alternatingSums(a) = [180, 105].

            //Input / Output

            //[time limit] 3000ms(cs)
            //[input]
            //        array.integer a

            //Constraints:
            //            1 ≤ a.length ≤ 10,
            //45 ≤ a[i] ≤ 100.

            //[output]
            //        array.integer

            int[] result = new int[] { 0, 0 };

            for (int i = 0; i < a.Count(); i++)
            {
                result[i % 2] += a[i];
            }

            return result;


            // BELOW WORKS, BUT MAKE SIMPLER
            //if (a.Length < 1 || a.Length > 10)
            //    throw new System.Exception("Integer count must be between 1 and 10.");
            //if (a.Any(i => i < 45) || a.Any(i => i > 100))
            //    throw new System.Exception("Each integer must be between 45 and 100.");

            //List<int> team1 = new List<int>();
            //List<int> team2 = new List<int>();

            //int loc = 0;

            //while (loc <= a.Count() - 1)
            //{
            //    team1.Add(a[loc]);

            //    loc = loc + 2;
            //}

            //loc = 1;

            //while (loc < a.Count())
            //{
            //    team2.Add(a[loc]);

            //    loc = loc + 2;
            //}

            //return new int[] { team1.Sum(), team2.Sum() };
        }

        public static string[] addBorder(string[] picture)
        {
            //Given a rectangular matrix of characters, add a border of asterisks(*) to it.

            //Example

            //For

            //picture = ["abc",
            //           "ded"]
            //the output should be

            //addBorder(picture) = ["*****",
            //                      "*abc*",
            //                      "*ded*",
            //                      "*****"]
            //Input / Output

            //[time limit] 3000ms(cs)
            //[input] array.string picture

            //A non - empty array of non - empty equal - length strings.

            //Constraints:
            //1 ≤ picture.length ≤ 5,
            //1 ≤ picture[i].length ≤ 5.

            //[output] array.string

            //The same matrix of characters, framed with a border of asterisks of width 1.

            List <string> picWithBorder = new List<string>();
            string border = "";

            for (int i = 1; i <= picture[0].Length + 2; i++)
                border += "*";

            picWithBorder.Add(border);

            foreach (string s in picture)
            {
                string entry = "*" + s + "*";
                picWithBorder.Add(entry);
            }

            picWithBorder.Add(border);

            return picWithBorder.ToArray();

        }

        public static bool areSimilar(int[] a, int[] b)
        {
            //Two arrays are called similar if one can be obtained from another by swapping at most one pair of elements.

            //Given two arrays, check whether they are similar.

            //Example

            //For A = [1, 2, 3] and B = [1, 2, 3], the output should be
            //areSimilar(A, B) = true;
            //            For A = [1, 2, 3] and B = [2, 1, 3], the output should be
            //areSimilar(A, B) = true;
            //            For A = [1, 2, 2] and B = [2, 1, 1], the output should be
            //areSimilar(A, B) = false.
            //Input / Output

            //[time limit] 3000ms(cs)
            //[input]
            //        array.integer A

            //Array of integers.

            //Constraints:
            //3 ≤ A.length ≤ 105,
            //1 ≤ A[i] ≤ 1000.

            //[input]
            //        array.integer B

            //Array of integers of the same length as A.

            //Constraints:
            //B.length = A.length,
            //1 ≤ B[i] ≤ 1000.

            //[output]
            //        boolean

            //true if A and B are similar, false otherwise.

            int changeCount = 0;
            bool result = true;
            int idx = 0;

            foreach (int i in a)
            {
                if (i != b[idx])
                {
                    if (!b.Any(v => v == i))
                    {
                        result = false;
                        break;
                    }

                    changeCount++;
                }

                if (changeCount > 2)
                {
                    result = false;
                    break;
                }

                idx++;
            }

            return result;
        }

        public static int arrayChange(int[] inputArray)
        {
            //You are given an array of integers.On each move you are allowed to increase exactly one of its element by one.Find the minimal number of moves required to obtain a strictly increasing sequence from the input.

            //Example

            //For inputArray = [1, 1, 1], the output should be
            //arrayChange(inputArray) = 3.

            //Input / Output

            //[time limit] 6000ms(cs)
            //[input] array.integer inputArray

            //Constraints:
            //            3 ≤ inputArray.length ≤ 105,
            //-105 ≤ inputArray[i] ≤ 105.

            //[output] integer

            //The minimal number of moves needed to obtain a strictly increasing sequence from inputArray.
            //It's guaranteed that for the given test cases the answer always fits signed 32-bit integer type.

            //List<int> inputList = inputArray.ToList();
            int incCount = 0;

            for (int idx = 1; idx < inputArray.Count(); idx++)
            {
                int i = inputArray.ElementAt(idx);
                int diff = 0;

                if (i <= inputArray.ElementAt(idx - 1))
                {
                    diff = (i < inputArray.ElementAt(idx - 1)) ? inputArray.ElementAt(idx - 1) - i + 1 : 1;
                    incCount = incCount + diff;
                    inputArray.SetValue(inputArray.ElementAt(idx) + diff, idx);
                }
            }

            return incCount;

            // WORKING SOLUTION, BUT SLOW FOR LARGE ARRAY (too many unneeded loops)
            //for (int idx = 1; idx < inputArray.Count(); idx++)
            //{
            //    int i = inputArray.ElementAt(idx);

            //    while (i <= inputArray.ElementAt(idx - 1))
            //    {
            //        incCount++;
            //        i++;
            //        inputArray.SetValue(i, idx);
            //    }

            //}

            //return incCount;

        }

        public static bool palindromeRearranging(string inputString)
        {
            //Given a string, find out if its characters can be rearranged to form a palindrome.

            //Example

            //For inputString = "aabb", the output should be
            //palindromeRearranging(inputString) = true.

            //We can rearrange "aabb" to make "abba", which is a palindrome.

            //Input / Output

            //[time limit] 6000ms(cs)
            //[input] string inputString

            //A string consisting of lowercase English letters.

            //Constraints:
            //            4 ≤ inputString.length ≤ 50.


            //            [output] boolean

            //true if the characters of the inputString can be rearranged to form a palindrome, false otherwise.

            //bool result = true;

            //var distinct = inputString.Distinct();

            return (inputString.GroupBy(v => v).Count(_ => _.Count() % 2 == 0) >= inputString.Distinct().Count() - 1)
                ? true : false;
        }

        public static bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            //Call two arms equally strong if the heaviest weights they each are able to lift are equal.

            //Call two people equally strong if their strongest arms are equally strong(the strongest arm can be both the right and the left), and so are their weakest arms.

            //Given your and your friend's arms' lifting capabilities find out if you two are equally strong.

            //Example

            //For yourLeft = 10, yourRight = 15, friendsLeft = 15 and friendsRight = 10, the output should be
            //areEquallyStrong(yourLeft, yourRight, friendsLeft, friendsRight) = true;
            //            For yourLeft = 15, yourRight = 10, friendsLeft = 15 and friendsRight = 10, the output should be
            //areEquallyStrong(yourLeft, yourRight, friendsLeft, friendsRight) = true;
            //            For yourLeft = 15, yourRight = 10, friendsLeft = 15 and friendsRight = 9, the output should be
            //areEquallyStrong(yourLeft, yourRight, friendsLeft, friendsRight) = false.
            //Input / Output

            //[time limit] 6000ms(cs)
            //[input] integer yourLeft

            //A non-negative integer representing the heaviest weight you can lift with your left arm.

            //Constraints:
            //            0 ≤ yourLeft ≤ 15.


            //            [input] integer yourRight

            //A non-negative integer representing the heaviest weight you can lift with your right arm.

            //Constraints:
            //            0 ≤ yourRight ≤ 15.


            //            [input] integer friendsLeft

            //A non-negative integer representing the heaviest weight your friend can lift with his or her left arm.

            //Constraints:
            //0 ≤ friendsLeft ≤ 15.

            //[input] integer friendsRight

            //A non-negative integer representing the heaviest weight your friend can lift with his or her right arm.

            //Constraints:
            //0 ≤ friendsRight ≤ 15.

            //[output] boolean

            //true if you and your friend are equally strong, false otherwise.

            var youOrdered = new int[] { yourLeft, yourRight }.OrderBy(v => v).ToArray();
            var friendOrdered = new int[] { friendsLeft, friendsRight }.OrderBy(v => v).ToArray();

            return youOrdered[0] == friendOrdered[0] && youOrdered[1] == friendOrdered[1];

        }

        public static int arrayMaximalAdjacentDifference(int[] inputArray)
        {
            //Given an array of integers, find the maximal absolute difference between any two of its adjacent elements.

            //Example

            //For inputArray = [2, 4, 1, 0], the output should be
            //arrayMaximalAdjacentDifference(inputArray) = 3.

            //Input / Output

            //[time limit] 6000ms(cs)
            //[input] array.integer inputArray

            //Constraints:
            //            3 ≤ inputArray.length ≤ 10,
            //-15 ≤ inputArray[i] ≤ 15.

            //[output] integer

            //The maximal absolute difference.

            var sums = inputArray.Where((v, i) => i != inputArray.Count() - 1)
                .Select((v, i) => Math.Abs(v - inputArray.ElementAt(i + 1)));

            return sums.Max();

        }

        public static bool isIPv4Address(string inputString)
        {
            //An IP address is a numerical label assigned to each device (e.g., computer, printer) participating in a computer network that uses the Internet Protocol for communication.There are two versions of the Internet protocol, and thus two versions of addresses.One of them is the IPv4 address.

            //IPv4 addresses are represented in dot - decimal notation, which consists of four decimal numbers, each ranging from 0 to 255, separated by dots, e.g., 172.16.254.1.

            //Given a string, find out if it satisfies the IPv4 address naming rules.

            //Example

            //For inputString = "172.16.254.1", the output should be
            //isIPv4Address(inputString) = true;

            //            For inputString = "172.316.254.1", the output should be
            //isIPv4Address(inputString) = false.

            //316 is not in range[0, 255].

            //For inputString = ".254.255.0", the output should be
            //isIPv4Address(inputString) = false.

            //There is no first number.

            //Input / Output

            //[time limit] 6000ms(cs)
            //[input] string inputString

            //A string consisting of digits, full stops and lowecase Latin letters.

            //Constraints:
            //5 ≤ inputString.length ≤ 15.

            //[output] boolean

            //true if inputString satisfies the IPv4 address naming rules, false otherwise.

            return inputString.Split('.').Where((v, r) => Int32.TryParse(v, out r) == true)
                .Where(v => Int32.Parse(v) <= 255 && Int32.Parse(v) >= 0)
                .Select(v => v).Count() == 4 && inputString.Where(v => v == '.').Select(v => v).Count() == 3;
        }

        public static int avoidObstacles(int[] inputArray)
        {
            //  You are given an array of integers representing coordinates of obstacles situated on a straight line.

            //Assume that you are jumping from the point with coordinate 0 to the right.You are allowed only to make jumps of the same length represented by some integer.

            //Find the minimal length of the jump enough to avoid all the obstacles.

            //Example

            //For inputArray = [5, 3, 6, 7, 9], the output should be
            //avoidObstacles(inputArray) = 4.

            //Check out the image below for better understanding:



            //Input/Output

            //[time limit] 6000ms(cs)
            //[input]
            //        array.integer inputArray

            //Non-empty array of positive integers.

            //Constraints:
            //2 ≤ inputArray.length ≤ 10,
            //1 ≤ inputArray[i] ≤ 40.

            //[output]
            //        integer

            //The desired length.

            // get rid of dividends

            // get lowest potential

            int lowestJump = 0;
            int[] orderedArray = inputArray.OrderBy(v => v).ToArray();

            for (int idx = 0; idx < orderedArray.Count(); idx++)
            {
                int value = orderedArray.ElementAt(idx);
                int nextValue = orderedArray.ElementAt(idx + 1);
                int valueDiff = nextValue - value;
                lowestJump = orderedArray.ElementAt(idx) + 1;
                
                if (orderedArray.Count() == idx + 1
                    || orderedArray.ElementAt(idx + 1) - orderedArray.ElementAt(idx) != 1
                    && !orderedArray.Any(v => v % lowestJump == 0))
                {
                    break;
                }
            }

            //foreach (int i in inputList.OrderBy(v => v))
            //{
            //    lowestJump = i + 1;


            //}




            //while (inputList.Count() > 2)
            //{
            //    lowestJump = inputList.OrderBy(v => v).Min() + 1;

            //    foreach (int i in inputList.OrderByDescending(v => v))
            //    {
            //        if (i % lowestJump == 0)
            //        {
            //            inputList.RemoveAll(v => v == lowestJump - 1);
            //            break;
            //        }
            //    }
            //}
            
            return lowestJump;
        }
    }
}



