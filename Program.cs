using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    
    
        class Example
        {
            public static void ShowArray<T>(T[] arr)
            {
                for(int i=0; i<arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
            int[] Numbers = new int[3];
            Numbers[0] = 22;
            Numbers[1] = 27;
            Numbers[2] = 28;
            string[] Names = { "vandu", "Pakhi", "Tanu" };
            double[] d = { 45.5, 55.5, 44.4 };
            Example.ShowArray(Numbers);
            Example.ShowArray(Names);
            Example.ShowArray(d);
            Console.ReadLine();


        }
        }
        
    
}
