using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class BankHapoalim:Bank
    {
        private int _workerInSnif;
        public readonly int numberOfSnifim;
        public static BankHapoalim[] snifimList;
        private static int index = 0;
        public int workerInSnif
        {
            get { return _workerInSnif; }
            set { _workerInSnif = value; }
        }

        public BankHapoalim(string name, string number, string code, string address, string city, string phone) :base(name,number,code,address,city,phone)
        {

        }

        public BankHapoalim(int numberOfSnifim):base()
        {
            this.numberOfSnifim = numberOfSnifim;
        }

        

        public static void import(Bank[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] is BankHapoalim)
                {
                    snifimList[i] = (BankHapoalim)list[i];
                }
            }
        }
    }
}
