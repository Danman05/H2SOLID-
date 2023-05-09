using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal class Maestro : Card
    {
        private List<int> prefix = new List<int>
            {
                5018, 
                5020,
                5038, 
                5893, 
                6304,
                6759, 
                6761,
                6762, 
                6763
            };

        public Maestro(string cardHolderName, int age) : base(cardHolderName, age)
        { 
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
