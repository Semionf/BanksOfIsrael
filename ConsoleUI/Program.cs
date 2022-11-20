using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = Runner.CountNumOfLines();
            const string fileName = "snifim.txt";
            StreamReader sr = new StreamReader(fileName);
            Bank[] b = new Bank[count];
            BankHapoalim[] bh = null;
            BankLeumi[] bl = null;
            int index = 0;
            Console.OutputEncoding = Encoding.GetEncoding("Windows-1255");
            Runner.Run();
            while (sr.ReadLine() is string s)
            {
                string[] details = s.Split(',');
                if (details[1].Contains("מזרחי"))
                {
                    b[index] = new BankMizrahi(details[1], details[0], details[2], details[4], details[5], details[8]);
                }
                else if (details[1].Contains("הפועלים"))
                {
                    b[index] = new BankHapoalim(details[1], details[0], details[2], details[4], details[5], details[8]);
                }
                else if (details[1].Contains("לאומי"))
                {
                    b[index] = new BankLeumi(details[1], details[0], details[2], details[4], details[5], details[8]);
                }
                else if (details[1].Contains("דיסקונט"))
                {
                    b[index] = new BankDiscount(details[1], details[0], details[2], details[4], details[5], details[8]);
                }
                else
                {
                    b[index] = new Default(details[1], details[0], details[2], details[4], details[5], details[8]);
                }
                index++;
            }
            for (int i = 0; i < count; i++)
            {
                if(b[i] is BankHapoalim)
                {
                    bh[i] = (BankHapoalim)b[i]; 
                }
                else if(b[i] is BankLeumi)
                {
                    bl[i] = (BankLeumi)b[i];
                }
            }

        }
    }
}