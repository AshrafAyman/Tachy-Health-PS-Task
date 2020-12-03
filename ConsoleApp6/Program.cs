using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static string SumDigits(string num1, string num2)  
        {  
            if (num1.Length > num2.Length){  
                string t = num1; 
                num1 = num2; 
                num2 = t; 
            } 
            string str = "";  
            int fNum = num1.Length, sNum = num2.Length;  

            char[] arr1 = num1.ToCharArray(); 
            Array.Reverse( arr1 ); 
            num1 = new string( arr1 );
            
            char[] arr2 = num2.ToCharArray(); 
            Array.Reverse( arr2 ); 
            num2 = new string( arr2 ); 
          
            int carry = 0;  
            for (int i = 0; i < fNum; i++)  
            {  
                int sum = ((int)(num1[i] - '0') +  
                        (int)(num2[i] - '0') + carry);  
                str += (char)(sum % 10 + '0');  
                carry = sum/10;  
            }  

            for (int i = fNum; i < sNum; i++)  
            {  
                int sum = ((int)(num2[i] - '0') + carry);  
                str += (char)(sum % 10 + '0');  
                carry = sum/10;  
            }   

            if (carry > 0)  
                str += (char)(carry + '0');  
            char[] ch2 = str.ToCharArray(); 
            Array.Reverse( ch2 ); 
            str = new string( ch2 ); 
          
            return str;  
        }  
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string num1 = Console.ReadLine();  
            Console.WriteLine("Enter the second number");
            string num2 = Console.ReadLine();

            Console.WriteLine(SumDigits(num1, num2));
            Console.ReadLine();
        }

    }
}
