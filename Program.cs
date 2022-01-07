#region Copyright EazyLearn
//
// All rights are reserved. Reproduction or transmission in whole or in part, 
// in any form or by any means, electronic, mechanical or otherwise, is
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : C#Basics.cs
// Purpose         : C# Basics in practice
// Creation Date   : 19-09-2021
// Author          : Sulfikkar E S
//
// Change History  :
// Changed by      :              
// Date            : 
// Purpose         :
//
#endregion Copyright EazyLearn

#region included namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion included namespaces

namespace Eazylearn.CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n\t *** Menu ***\n");
                Console.WriteLine(" 1 : Area And Circumference Of A Circle" +
                    "\n 2 : Calculator " +
                    "\n 3 : Temperature Chart" +
                    "\n 4: Square And Cube Of n Numbers " +
                    "\n 5 : Given Integer Is Odd Or Even Or Zero " +
                    "\n 6 : Interest Calculator" +
                    "\n 7 : ASCII to Character Converter" +
                    "\n 8 : Sum Of All Digits Into A Single Digit" +
                    "\n 9 : Print The Given Number In Reverse Order" +
                    "\n 10 :String Is Alphabetic Or NOT " +
                    "\n 11 : Hexadecimal Converter" +
                    "\n 12 : Binary Converter" +
                    "\n 13 : Words And Character Counter " +
                    "\n 14 : Vowels Finder" +
                    "\n 15 : N Random Numbers Between Two Specified Intervals" +
                    "\n 16 : Accept A String And Replace All The Characters Except The Last Character With *" +
                    "\n 17 : Number Sequence" +
                    "\n 18 : Number To Words Converter" +
                    "\n 19 : Fibonacci Sequence" +
                    "\n 20 : Sum Of n Numbers\n");
                Console.WriteLine("\nPlease Select Any Option : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1 : Area And Circumference Of A Circle \n\t*******\n");
                        FindAreaAndCircumference();
                        break;
                    case 2:
                        Console.WriteLine("2 : Calculator\n\n\t*****\n");
                        DoArithmeticOperations();
                        break;
                    case 3:
                        Console.WriteLine("3 : Temperature Chart\n\t*****\n");
                        PrintTemperatureConvertionChart();
                        break;
                    case 4:
                        Console.WriteLine("4: Square And Cube Of n Numbers \n\t******\n");
                        PrintSquareAndCubeOfNaturalNumbers();
                        break;
                    case 5:
                        Console.WriteLine("5 : Given Integer Is Odd Or Even Or Zero \n\t******\n");
                        FindOddOrEvenOrZero();
                        break;
                    case 6:
                        Console.WriteLine("6 : Interest Calculator\n\t*****\n");
                        CalculateInterest();
                        break;
                    case 7:
                        Console.WriteLine("7 : ASCII to Character Converter\n\t*****\n");
                        ConvertAsciiToItsEquivalentCharacter();
                        break;
                    case 8:
                        Console.WriteLine("8 : Sum Of All Digits Into A Single Digit\n\t*****\n");
                        FindSumOfAllDigitsInToSingleDigit();//
                        break;
                    case 9:
                        Console.WriteLine("9 : Print The Given Number In Reverse Order\n\t******\n");
                        PrintInReverceOrder();
                        break;
                    case 10:
                        Console.WriteLine("10 :String Is Alphabetic Or NOT\n\t*****\n");
                        CheckAlphabeticOrNot();
                        break;
                    case 11:
                        Console.WriteLine("11 : Hexadecimal Converter\n\t*****\n");
                        ConvertsNumberIntoItsHexaDecimalFormat();
                        break;
                    case 12:
                        Console.WriteLine("12 : Binary Converter\n\t*****\n");
                        ConvertsNumberIntoItsBinaryFormat();
                        break;
                    case 13:
                        Console.WriteLine("13 : Words And Character Counter\n\t*****\n");
                        CountNumberOfWordsAndCharacter();
                        break;
                    case 14:
                        Console.WriteLine("14 : Vowels Finder\n\t*****\n");
                        PrintVowels();
                        break;
                    case 15:
                        Console.WriteLine("15 : N Random Numbers Between Two Specified Intervals\n\t********\n");
                        GenerateRandomNumbers();
                        break;
                    case 16:
                        Console.WriteLine("16 : Accept A String And Replace All The Characters Except The Last Character With *\n\t*****\n");
                        ReplaceAllCharacters();
                        break;
                    case 17:
                        Console.WriteLine(" 17 : Number Sequence\n\t*****\n");
                        PrintThePattern();
                        break;
                    case 18:
                        Console.WriteLine("18 : Number To Words Converter\n\t*****\n");
                        ConverNumberinTowords();//
                        break;
                    case 19:
                        Console.WriteLine(" 19 : Fibonaci Sequence\n\t*****\n");
                        PrintFibonacciSequence();
                        break;
                    case 20:
                        Console.WriteLine("20 : Sum Of n Numbers\n\t*****\n");
                        FindSumOfNnUmbers();//
                        break;
                    default:
                        Console.WriteLine(" Invalid Option Is Selected "); break;
                }
            } while (choice != 0);
        } //main end here

        static void FindAreaAndCircumference()
        {
            float radius;
            double circumference, area;

            Console.WriteLine("Enther The Radius Of Circle : ");
            radius = Convert.ToSingle(Console.ReadLine());
            circumference = 2 * Math.PI * radius;
            area = Math.PI * radius * radius;

            Console.WriteLine($" Circumference Of Circle Is : {Math.Round(circumference, 2)}");
            Console.WriteLine($"\nArea Of Circle Is : {Math.Round(area, 2)}");
            Console.WriteLine("\n\n \t\t********");
            Console.ReadLine();
        }//End of FindAreaAndCircumference
        //*************************************************************************************
        //*************************************************************************************

        static void DoArithmeticOperations()
        {
            int select;
            double firstNumber, secondNumber, sum, difference, product, quotient;

            Console.WriteLine("\n  **Calculator**");
            Console.WriteLine(" \nEnter First Numbers");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n Enter Second Numbers");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            sum = firstNumber + secondNumber;
            difference = firstNumber - secondNumber;
            product = firstNumber * secondNumber;
            quotient = firstNumber / secondNumber;

            do
            {
                Console.WriteLine("\n  *** Menu's for Calculator ***");
                Console.WriteLine("\n 1: Addision\n 2: Substraction\n 3: Division\n 4: Multiplication\n");
                Console.WriteLine("Select Any Option");
                select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Console.WriteLine($"Addision Result Is : {sum}");
                        break;
                    case 2:
                        Console.WriteLine($"Substraction Result Is : {difference}");
                        break;
                    case 3:
                        Console.WriteLine($"Division Result is : {quotient} ");
                        break;
                    case 4:
                        Console.WriteLine($"Multiplication Result Is :{product}");
                        break;
                    default:
                        Console.WriteLine(" Invalid Option Is Selected ");
                        break;
                }
            } while (select > 4);
            Console.ReadLine();
        }//End of DoArithmeticOperations()
        //*************************************************************************************
        //*************************************************************************************

        static void PrintTemperatureConvertionChart()
        {
            double centigrade, fahrenheit;

            int minimum = 0, maximum = 100;
            centigrade = minimum;

            Console.WriteLine($" Centigrade - Fahrenheit is");

            while (centigrade <= maximum)
            {
                fahrenheit = (centigrade * (9.0 / 5)) + 32;
                Console.WriteLine($"   {Math.Round(centigrade, 2)} \t      {Math.Round(fahrenheit, 2)}");
                centigrade = centigrade + 1;
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }//End of PrintTemperatureConvertionChart()
        //*************************************************************************************
        //*************************************************************************************

        static void PrintSquareAndCubeOfNaturalNumbers()
        {
            int maximum;

            int minimum = 0;

            Console.WriteLine("Enter A Limit:"); // To Show Square and Cube upto this Limit
            maximum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number:\t Square:\tcube:\n");

            while (minimum <= maximum)
            {
                Console.WriteLine($"{ minimum }\t { minimum * minimum }\t \t{ minimum * minimum * minimum }\n");
                minimum = minimum + 1;
            }
            Console.ReadLine();
        }//End of PrintSquareAndCubeOfNaturalNumbers()
         //*************************************************************************************
         //*************************************************************************************
        
        static void FindOddOrEvenOrZero()
        {
            int number;

            Console.WriteLine("Enter A Number To check Whether Odd Or Even");
            number = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (number == 0)
                {
                    break;
                }
                else if (number % 2 != 0)
                {
                    Console.WriteLine($"{number} Is An Odd Number");
                }
                else if (number % 2 == 0 && number != 0)
                {
                    Console.WriteLine($"{number} Is An Even Number");
                }
            } while (number != 0);
            Console.ReadLine();
        }//End of FindOddOrEvenOrZero()
         //*************************************************************************************
         //*************************************************************************************

        static void CalculateInterest()
        {
            double principalAmount;
            double finalAmount, powerCalculation, power;
            float annualNominalInterestRate, numberOfTimesCompoundedPerYear, baseFinder, numberOfYears;

            Console.WriteLine("\nPleace Enter Principal Amount :");
            principalAmount = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\nPleace Enter Number Of Years Required:");
            numberOfYears = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\nPleace Enter Annual Nominal Interest Rate (as a decimal) :");
            annualNominalInterestRate = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\nPleace Enter Number Of Times The Interest Is Compounded Per Year:");
            numberOfTimesCompoundedPerYear = Convert.ToSingle(Console.ReadLine());

            annualNominalInterestRate = annualNominalInterestRate / 100;
            power = numberOfTimesCompoundedPerYear * numberOfYears;
            baseFinder = 1 + (annualNominalInterestRate / numberOfTimesCompoundedPerYear);
            powerCalculation = Math.Pow(baseFinder, power); //Mathematical Power Calculation
            finalAmount = principalAmount * powerCalculation;
            Console.WriteLine($"\n Final Amount is :{Math.Round(finalAmount, 2)}");
            Console.ReadLine();
        }//End of CalculateInterest()
         //*************************************************************************************
         //*************************************************************************************

        static void ConvertAsciiToItsEquivalentCharacter()
        {
            int ascii;
            char correspondent;

            Console.WriteLine("\nPleace Enter ASCII code between 0 and 122");
            ascii = Convert.ToInt32(Console.ReadLine());
            correspondent = Convert.ToChar(ascii);
            Console.WriteLine($"\nASCII Of {ascii} Is : {correspondent} ");
            Console.ReadLine();
        } //End Of ConvertAsciiToItsEquivalentCharacter()
          //*************************************************************************************
          //*************************************************************************************

        static void FindSumOfAllDigitsInToSingleDigit()
        {
            int digit, sum, remainder;

            sum = 0;
            Console.WriteLine("\nEnter A Digit");
            digit = Convert.ToInt32(Console.ReadLine());

            while (digit > 0)
            {
                remainder = digit % 10;
                sum = sum + remainder;
                digit = digit / 10;
            }
            Console.WriteLine($"\nSum Is : {sum}");
            Console.ReadLine();
        }//End Of FindSumOfAllDigitsInToSingleDigit()
         //*************************************************************************************
         //*************************************************************************************

        static void PrintInReverceOrder()
        {
            int reverse, reminder;
            string number;

            reverse = 0;
            Console.WriteLine("\nEnter Number");
            number = (Console.ReadLine());
            reverse = number.Reverse();

            ////while (number > 0)
            ////{
            ////    reminder = number % 10;
            ////    reverse = (reverse * 10) + reminder;
            ////    number = number / 10;
            ////}
            Console.WriteLine($"\nReverse Order is : {reverse} ");
            Console.ReadLine();
        }//End Of PrintInReverceOrder()
         //*************************************************************************************
         //*************************************************************************************

        static void CheckAlphabeticOrNot()
        {
            string chain;

            Console.WriteLine("\nEnter A String : ");
            chain = Convert.ToString(Console.ReadLine());

            if (chain.All(char.IsLetterOrDigit) || chain.All(char.IsPunctuation))
            {
                Console.WriteLine($"\n {chain} Is Alphabetic");
            }
            else
            {
                Console.WriteLine($"\n {chain} Is Not Alphabetic");
            }
            Console.ReadLine();
        }//End Of CheckAlphabeticOrNot()
         //*************************************************************************************
         //*************************************************************************************

        static void ConvertsNumberIntoItsHexaDecimalFormat()
        {
            int number, remainder, i;

            remainder = 0;
            i = 0;
            string hexadecimaNumber = "";
            Console.WriteLine("\nEnter A Decimal Number");
            number = Convert.ToInt32(Console.ReadLine());

            while (number != 0)
            {
                remainder = number % 16;
                if (remainder < 10)
                {
                    remainder = remainder + 48;
                }
                else
                {
                    remainder = remainder + 55;
                }
                hexadecimaNumber = hexadecimaNumber + Convert.ToChar(remainder);
                number = number / 16;
            }
            Console.WriteLine("\nHexadecimal Number Is :");

            for (i = hexadecimaNumber.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{hexadecimaNumber[i]}");
            }
            Console.ReadLine();
        }//End Of ConvertsNumberIntoItsHexaDecimalFormat()
         //*************************************************************************************
         //*************************************************************************************

        static void ConvertsNumberIntoItsBinaryFormat()
        {
            int number, remainder;

            string result = "";
            remainder = 0;
            Console.WriteLine("\nEnter A Decimal Number");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBinary is :");

            while (number != 0)
            {
                remainder = number % 2;
                number = number / 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine($"{result}");
            Console.ReadLine();
        }//End Of ConvertsNumberIntoItsBinaryFormat()
         //*************************************************************************************
         //*************************************************************************************
        static void CountNumberOfWordsAndCharacter()
        {
            string sentance;
            int word, length, charact = 1;

            word = 1;
            charact = 1;
            Console.WriteLine("\nEnter Sentance");
            sentance = Console.ReadLine();

            for (length = 0; length <= sentance.Length - 1; length++)
            {
                if (sentance[length] == ' ' || sentance[length] == '\n' || sentance[length] == '\t')
                {
                    word++;
                }
                else if (sentance[length] >= 'a' && sentance[length] <= 'z' || sentance[length] >= 'A' || +
                    sentance[length] <= 'Z')
                {
                    charact++;
                }
            }
            Console.WriteLine($"\nTotal Number Of Words In The Sentance Is : { word }");
            Console.WriteLine($"\nTotal Number Of Character In The Sentance Is : { charact }");
            Console.ReadLine();
        }//End Of CountNumberOfWordsAndCharacter()
         //*************************************************************************************
         //*************************************************************************************

        static void PrintVowels()
        {
            string sentence;
            int j, length, cons;
            int a, e, i, o, u;

            Console.WriteLine("\nEnter Sentance");
            sentence = Console.ReadLine();
            a = 0;
            e = 0;
            i = 0;
            o = 0;
            u = 0;
            cons = 0;
            length = sentence.Length;

            for (j = 0; j < length; j++)
            {
                if (sentence[j] == 'a' || sentence[j] == 'A' || sentence[j] == 'E' || sentence[j] == 'e' || +
                   sentence[j] == 'i' || sentence[j] == 'I' || sentence[j] == 'O' || sentence[j] == 'o' || +
                   sentence[j] == 'u' || sentence[j] == 'u' || sentence[j] == 'U')
                {
                    if (sentence[j] == 'a' || sentence[j] == 'A')
                    {
                        a = a + 1;
                    }
                    if (sentence[j] == 'e' || sentence[j] == 'E')
                    {
                        e = e + 1;
                    }
                    if (sentence[j] == 'i' || sentence[j] == 'I')
                    {
                        i = i + 1;
                    }
                    if (sentence[j] == 'o' || sentence[j] == 'O')
                    {
                        o = o + 1;
                    }
                    if (sentence[j] == 'u' || sentence[j] == 'U')
                    {
                        u = u + 1;
                    }
                    else
                    {
                        cons = cons + 1;
                    }
                }
            }        
            Console.WriteLine($"\nTotal Number Of Vowel ( a )  In The Sentance Is : {a}");
            Console.WriteLine($"\nTotal Number Of Vowel ( e )  In The Sentance Is : {e}");
            Console.WriteLine($"\nTotal Number Of Vowel ( i )  In The Sentance Is : {i}");
            Console.WriteLine($"\nTotal Number Of Vowel ( o )  In The Sentance Is : {o}");
            Console.WriteLine($"\nTotal Number Of Vowel ( u )  In The Sentance Is : {u}");
            Console.WriteLine($"\nTotal Number Of Contants In The Sentance Is : { cons }");
            Console.ReadLine();
        }//End Of PrintVowels()
         //*************************************************************************************
         //*************************************************************************************

        static void GenerateRandomNumbers()
        {

            int i, firstNumber, secondNumber, limit;
            Random rand = new Random();
            
            Console.WriteLine("\nEnter Value of N");
            limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter First Number");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Secont Number");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nRandom Number Between are :");

            for ( i = 0; i < limit; i++)
            {
                Console.WriteLine($"{rand.Next(firstNumber, secondNumber)}");
            }
        }//End Of GenerateRandomNumbers()
         //*************************************************************************************
         //*************************************************************************************

        static void RepleAllCharacters()
        {
            string sequenceOfCharacters;

            Console.WriteLine("Enter A string");
            sequenceOfCharacters = Console.ReadLine();

            var length = sequenceOfCharacters.Length;
            var result = new string('*', length - 1) + sequenceOfCharacters.Substring(length - 1);
            result.Trim();
            Console.WriteLine(result);
            Console.ReadLine();
        }//End Of RepleAllCharacters()
         //*************************************************************************************
         //*************************************************************************************

        static void PrintThePattern()
        {
            int i, j, n;

            Console.WriteLine("\nEnter Limit");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1;i <= n; i++)
            {
                for (j = 1;j <= i; j++)
                {
                    if (j == 1 || j == i)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }//End Of PrintThePattern()
         //*************************************************************************************
         //*************************************************************************************

        static void PrintFibonacciSequence()
        {

            int first = 0, second = 1, third, n, i;

            Console.WriteLine("Enter Limit");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine($"{first}");
            }
            else
            {
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine($"\t{ second }");
                    third = first + second;
                    first = second;
                    second = third;
                }
            }
            Console.ReadLine();
        }//End of PrintFibonacciSequence()
        //*************************************************************************************
        //*************************************************************************************
        static void ConverNumberinTowords()
        {
            string[] part = new string[] { "ONE ", "TWO ", "THREE ", "FOUR ", "FIVE ", "SIX ", "SEVEN ", "EIGHT " +
                "NINE ", "TEN ", "ELEVEN ", "TWELEVE ", "THIRTEEN ", "FOURTEEN ", "FIFTEEN ", "SIXTEEN " +
                "SEVENTEEN ", "EIGHTEEN ", "NINTEEN " };
            string[] tens = new string[] { "TEN ", "TWENTY ", "THIRTY ", "FOURTY ", "FIFTY " +
                "SIXTY ", "SEVENTY ", "EIGHTY ", "NINTY " };

            int denom, number;

            string result = "";

            Console.Write("Enter Number Between 0 to 999 : ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            if (number > 99 && number < 1000)
            {
                denom = number / 100;
                result = part[denom - 1] + "HUNDRED ";
                number = number % 100;
            }
            if (number > 19 && number < 100)
            {
                denom = number / 10;
                result = result + tens[denom - 1];
                number = number % 10;
            }
            if (number < 20 && number > 0)
            {
                result += part[number - 1];
            }
            Console.WriteLine($"The number you entered: {result}");
            Console.ReadLine();
        }//End of ConverNumberinTowords()
         //*************************************************************************************
         //*************************************************************************************
        static void FindSumOfNnUmbers()
        {
            int number, i, sum;
            int term ;

            term = 1;
            sum = 0;
            Console.Write("Calculate the Sum of  N number Of Terms:\n");
            Console.Write("Input the Limit: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= number; i++)
            {
                Console.Write($" {term}");
                sum = sum + term;
                term = (term * 10) + 1;
            }
            Console.Write($"\nThe Sum is :  {sum}");
            Console.ReadLine();
        }//End of FindSumOfNnUmbers()
         //*************************************************************************************
         //*************************************************************************************
    }
}

