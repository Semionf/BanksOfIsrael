using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Bank
    {

        private int val = 0;
        private string _name;
        public string Name { get { return _name; } set { if(val == 0) _name = value; val++; } }
        public string number;
        public readonly string code;  
        public string address;
        public string city;
        public string phone;
       
        public Bank(string name, string number, string code, string address, string city, string phone)
        {
            this.Name = name;
            this.number = number;
            this.code = code;
            this.address = address;
            this.city = city;
            this.phone = phone;
        }
        public Bank()
        {

        }

    }
    public class Runner
    {

        public static void Run()
        {
            
            Console.OutputEncoding = Encoding.GetEncoding("Windows-1255");

            StreamReader sr = new StreamReader(fileName);
            int count = CountNumOfLines();
            int index = 0;
            int count2 = 0;
            Bank[] b = new Bank[count];
            sr.ReadLine();
            while (sr.ReadLine() is string s)
            {
                
                string[] details = s.Split(',');

                b[index] = new Bank(details[1], details[0], details[2], details[4], details[5], details[8]);
                index++;
            }
            for (int i = 0; i < count-1; i++)
            {
                if (b[i].city == "תל אביב -יפו" || b[i].city == "ירושלים")
                {
                    PrintDetails(b[i]);
                }
                if (b[i].Name.Contains("בנק הפועלים") && b[i].phone.Contains('8'))
                {
                    PrintDetails(b[i]);
                }

            }
            for (int i = 0; i < count - 1; i++)
            {
  
                if (b[i].Name.Contains("בנק הפועלים") && b[i].phone.Contains('8'))
                {
                    PrintDetails(b[i]);
                }

            }
            for (int i = 0; i < count-1; i++)
            {
                if (b[i].Name.Contains("בנק מזרחי"))
                {
                    count2++;
                }
            }
            Console.WriteLine("The number of times Bank mizrahi appears: " + count2);
            sr.Close();
            Console.ReadLine();
        }
        const string fileName = "snifim.txt";
        
        public static int CountNumOfLines()
        {
            int count = 0;
            StreamReader sr = new StreamReader(fileName);
            while (sr.ReadLine() is string s)
            {
                count++;
            }
            sr.Close();
            return count;
        }
        static void PrintDetails(Bank b)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bank details: " +b.Name + " " + b.number + " " + b.address + " "+ b.code + " " + b.city + " " + b.phone);
        }

        
    }

    
}
