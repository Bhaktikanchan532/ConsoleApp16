using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
  {
        static void Main(string[] args)
        {

            //pass array combination of even odd make addition of even and odd seperate print it and find max addition n print that addition
            //    int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //    int i, a = 0, b = 0;
            //    for(i=0;i<arr1.Length;i++)
            //    {
            //        if (arr1[i]%2==0)
            //        {
            //            Console.WriteLine($"Even number{arr1[i]}");
            //            a = a + arr1[i];
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Odd number {arr1[i]}");
            //            b = b + arr1[i];
            //        }
            //        Console.WriteLine(" ");
            //    }
            //    Console.WriteLine($"a is{a}");
            //    Console.WriteLine($"b is {b}");
            //    Console.WriteLine(" ");
            //    if(a>b)
            //    {
            //        Console.WriteLine($"Additiob of even{a}is greater than addition odd b{b}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"addition of odd{b} is greater than addition of even{a}");
            //    }





            //Accept string from user and print it is palindron or not
            //string n, reverse=String.Empty;
            //Console.WriteLine("Enter your string");
            //n = Console.ReadLine();
            //if(n!=null)
            //{
            //    for(int i=n.Length-1;i>=0;i--)
            //    {
            //        reverse += n[i].ToString();
            //    }
            //    if(reverse==n)
            //    {
            //        Console.WriteLine("palindrome ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not Palindrome");
            //    }

            //}




            //Accept string from user and print in reverse order
            //string s, s1 = "";
            //int i, n;
            //Console.Write("Input String:");
            //s = Console.ReadLine();
            //n = s.Length - 1;
            //for (i = n; i >= 0; i--)
            //{
            //    s1 = s1 + s[i];
            //}
            //Console.WriteLine("Reverse order string: {0}", s1);





            //Accept 2 string from user and check wheather they are anagram of each other or not
            //string s1,s2;
            //Console.WriteLine("Enter first String:");
            //s1 = Console.ReadLine();
            //Console.WriteLine("Enter second string:");
            //s2 = Console.ReadLine();
            //char[] a1=s1.ToLower().ToCharArray();
            //char[] a2 = s2.ToLower().ToCharArray();
            //Array.Sort(a1);
            //Array.Sort(a2);
            //string res1 = new string(a1); 
            //string res2= new string(a2);    
            //if(res1==res2)
            //{
            //    Console.WriteLine("String is Anagram....");
            //}
            //else
            //{
            //    Console.WriteLine("String ois not Anagram....");
            //}
            //Console.ReadLine();


            //1. WAP TO SPLIT STRING INTO 2 TOKANS WHERE STRING IS HELLO$WORLD

            //string text = "HELLO$WORLD";
            //string[] separators = { "$" };
            //string[] result=text.Split(separators,StringSplitOptions.None);
            //foreach(string str in result)
            //{
            //    Console.WriteLine(str);
            //}
            //Console.WriteLine();  //9output is HELLO   WORLD


            //2.WAPIN C# TO FIND FIRST OCCURANCE OF A CHARACTER IN A GIVEN STRING

            //    public class Program
            //{
            //static int max = 250;
            //static void calculate(String s, int[] cal)
            //{
            //    for (int i = 0; i < s.Length; i++)
            //        cal[s[i]]++;
            //}
            //    static void Main(string[] args)
            //    {
            //        string s = "mynameisbhakti";
            //    int[] cal = new int[max];
            //    calculate(s, cal);
            //    for (int i = 0; i < max; i++)
            //    {
            //        if (cal[i] > 1)
            //        {
            //            Console.WriteLine("Character:" + (char)i);
            //            Console.WriteLine("Occurance:" + cal[i] + "Times");
            //        }
            //        if (cal[i] == 1)
            //        {
            //            Console.WriteLine("Character:" + (char)i);
            //            Console.WriteLine("Occurance:" + cal[i] + "Times");
            //        }
            //    }





            //4.WAP C# TO TRIM LEADING WHITE SPACE CHARACTERS IN A STRING
            //string hello = "  hello";
            //Console.WriteLine(hello.Trim());
            //string someString = "........My name is Bhakti Kanchan***";
            //char[] charsToTrim = { '*', '.' };
            //string cleanString=someString.Trim(charsToTrim);
            //Console.WriteLine(cleanString);


            //5.WAP C# TO COUNT TOTAL NUMBER OF WORDS IN A STRING
            //int a = 0, myword = 1;
            //string str = "Hello To All";
            //while (a <= str.Length - 1)
            //{
            //    if (str[a]==' ' || str[a] == ' '|| str[a]=='\t')
            //    {
            //        myword++;
            //    }
            //    a++;
            //}

            //Console.WriteLine("nmber of words in string is:{0}", myword);





            //6.WAP IN C# TO REMOVE ALL OCCURANCES OF A CHAR FROM STRING
            //string text = "ABC ABC ABC";
            //string replacement = " ";
            //string result = text.Replace("C", "A", "B", replacement);
            //Console.WriteLine(result);
            

        }    
    }
}
