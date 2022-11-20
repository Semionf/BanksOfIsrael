using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class BankLeumi:Bank
    {
        private string _GiftForNewCostumers;

        public string GiftForNewCostumers
        {
            get { return _GiftForNewCostumers; }
            set { _GiftForNewCostumers = value; }
        }

        public BankLeumi(string name, string number, string code, string address, string city, string phone) : base(name, number, code, address, city, phone)
        {

        }
    }
}
