﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Visa : Card, IMaxDraft, IMaxUse, IExpire
    {
        // Card prefix
        private List<int> prefix = new List<int>
            {
                4
            };

        // Valueables from implemented interfaces
        public int MaxUsed { get; set; }
        public int MaxMonthly { get; set; }
        public DateTime ExpiryDate { get; set; }

        // Constructor
        public Visa(string cardHolderName, int age) : base(cardHolderName, age)
        {
            MaxUsed = 20000;
            MaxMonthly = 25000;
            ExpiryDate = DateTime.Now.AddYears(5);
            this.cardPrefix = GetCardPrefix(prefix);
            this.cardnumber = GetCardNumber();
            this.accountNumber = GetAccountNumber();
        }

        // String override for output
        public override string ToString()
        {

            return $"Card type: {GetType().Name}\n" +
                $"Name: {cardHolderName}\n" +
                $"Age: {age}\n" +
                $"Account number: {accountNumber}\n" +
                $"Card number: {cardnumber}\n" +
                $"Monthly spending limit: {MaxUsed} kr\n" +
                $"Max Monthly Withdraw Limit {MaxMonthly} kr\n" +
                $"Expiry date: {ExpiryDate.Month}-{ExpiryDate.Year}\n";

        }

    }
}
