using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class BankMizrahi:Bank
    {
        private int _clubMembersCount;

        public int clubMembersCount
        {
            get { return _clubMembersCount; }
            set { _clubMembersCount = value; }
        }

        public BankMizrahi(string name, string number, string code, string address, string city, string phone) : base(name, number, code, address, city, phone)
        {
            
        }
    }
}
