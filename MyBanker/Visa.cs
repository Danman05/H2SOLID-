using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal class Visa : Card, IMaxDraft, IMaxUse
    {
        private List<int> prefix = new List<int>
            {
                4
            };
        public int maxUsed { get; set; }
        public int maxMonthly { get; set; }

        public Visa(string cardHolderName, int age) : base(cardHolderName, age)
        {
            maxUsed = 20000;
            maxMonthly = 25000;

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
                $"Card number: {cardnumber}\n";
        }

    }
}
