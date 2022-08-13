using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Models
{
    internal class Account
    {
        public int Number { get; set; }
        public string Titular { get; set; }
        public decimal FirstDeposit { get; set; }
        public decimal Deposit { get; set; }

        public Account(int number, string titular, decimal firstDeposit, decimal deposit)
        {
            this.Number = number;
            this.Titular = titular;
            this.FirstDeposit = firstDeposit;
            this.Deposit = deposit;
        }

        public Account(int number, string titular)
        {
            this.Number = number;
            this.Titular = titular;
        }

        public Account() {}
    }
}
