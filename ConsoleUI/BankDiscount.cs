using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class BankDiscount:Bank
    {
        private bool _isTeacher;
        public static BankDiscount[] snifimList;
        public bool isTeacher
        {
            get { return _isTeacher; }
            set { _isTeacher = value; }
        }

        public BankDiscount(string name, string number, string code, string address, string city, string phone) : base(name, number, code, address, city, phone)
        {

        }

        public static void import(Bank[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] is BankDiscount)
                {
                    snifimList[i] = (BankDiscount)list[i];
                }
            }
        }
    }
}
