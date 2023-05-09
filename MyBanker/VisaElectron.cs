using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal class VisaElectron : Card, IMaxUse
    {
        private List<int> prefix = new List<int>
            {
                4026,
                417500,
                4508,
                4844,
                4913,
                4917
            };

        public int maxUsed { get; set; }


        public VisaElectron(string cardHolderName, int age) : base(cardHolderName, age)
        {
            maxUsed = 10000;
            this.cardPrefix = GetCardPrefix(prefix);
            this.cardnumber = GetCardNumber();
            this.accountNumber = GetAccountNumber();
        }

        public override string ToString()
        {

            return $"Card type: {GetType().Name}\n" +
                $"Name: {cardHolderName}\n" +
                $"Age: {age}\n" +
                $"Account number: {accountNumber}\n" +
                $"Card number: {cardnumber}\n" +
                $"Max usage: {maxUsed} kr";

        }
    }
}
