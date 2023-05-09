using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal class Mastercard : Card, IMaxDraft, IDraftDaily
    {
        private List<int> prefix = new List<int>
            {
                51,
                52,
                53,
                54, 
                55
            };
        public int maxMonthly { get ; set; }
        public int maxDaily { get ; set; }
        public Mastercard(string cardHolderName, int age) : base(cardHolderName, age)
        {
            maxDaily = 5000;
            maxMonthly = 30000;
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
