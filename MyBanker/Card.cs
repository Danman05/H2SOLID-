using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal abstract class Card
    {
        protected const int BankPrefix = 3520; // + xxxx xxxx xx;

        protected string cardHolderName;
        protected int age;

        protected string cardnumber;
        protected string accountNumber;
        protected int cardPrefix;

        private Random random = new Random();

        private string cardNumberString = "";

        private string accountNumberString = "";


        public Card(string cardHolderName, int age)
        {
            this.cardHolderName = cardHolderName;
            this.age = age;
        }

        protected virtual string GetCardNumber()
        {
            cardNumberString += $"{cardPrefix}-";

            for (int i = 0; i < 16 - cardPrefix.ToString().Length; i++)
            {
                cardNumberString += random.Next(0, 10);
            }

            return cardNumberString;
        }
        protected virtual string GetAccountNumber()
        {
            accountNumberString += $"{BankPrefix}-";

            for (int i = 0; i < 10; i++)
            {
                accountNumberString += random.Next(0, 10);
            }

            return accountNumberString;
        }
        protected virtual int GetCardPrefix(List<int> prefix)
        {
            return prefix[random.Next(0, prefix.Count)];
        }



    }
}
