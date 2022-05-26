using System;

namespace FactoryPattern
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }

    class MoneyBack: CreditCard
    {
        public string GetCardType(){
            return "MoneyBack";
        }

        public int GetCreditLimit(){
            return 100000;
        }

        public int GetAnnualCharge(){
            return 500;
        }
    }

    class Titanium : CreditCard
    {
        public string GetCardType(){
            return "Titanium";
        }

        public int GetCreditLimit(){
            return 1000000;
        }

        public int GetAnnualCharge(){
            return 800;
        }
    }

    class Platinum : CreditCard
    {
        public string GetCardType(){
            return "Platinum";
        }

        public int GetCreditLimit(){
            return 10000000;
        }

        public int GetAnnualCharge(){
            return 1000;
        }
    }


    class CreditCardFactory
    {
        public static CreditCard GetCreditCard(string cardType)
        {
            switch(cardType)
            {
                case "MoneyBack":
                    return new MoneyBack();
                    break;
                
                case "Titanium":
                    return new Titanium();
                    break;

                case "Platinum":
                    return new Platinum();
                    break;
                default:
                    return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CreditCard card = CreditCardFactory.GetCreditCard("MoneyBack");
            if(card != null){
                Console.WriteLine(card.GetCardType());
            }
        }
    }
}
