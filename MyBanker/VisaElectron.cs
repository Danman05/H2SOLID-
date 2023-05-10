﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class VisaElectron : Card, IMaxUse, IExpire
    {
        // Card prefix

        private List<int> prefix = new List<int>
            {
                4026,
                417500,
                4508,
                4844,
                4913,
                4917
            };

       // Implentation from interfaces
        public int MaxUsed { get; set; }
        public DateTime ExpiryDate { get; set; }

        // Constructor
        public VisaElectron(string cardHolderName, int age) : base(cardHolderName, age)
        {
            MaxUsed = 10000;
            ExpiryDate = DateTime.Now.AddYears(5);
            this.cardPrefix = GetCardPrefix(prefix);
            this.cardnumber = GetCardNumber();
            this.accountNumber = GetAccountNumber();
        }

        // String override method for output

        public override string ToString()
        {

            return $"Card type: {GetType().Name}\n" +
                $"Name: {cardHolderName}\n" +
                $"Age: {age}\n" +
                $"Account number: {accountNumber}\n" +
                $"Card number: {cardnumber}\n" +
                $"Monthly spending limit: {MaxUsed} kr\n" +
                $"Expiry date: {ExpiryDate.Month}-{ExpiryDate.Year}\n";

        }
    }
}
