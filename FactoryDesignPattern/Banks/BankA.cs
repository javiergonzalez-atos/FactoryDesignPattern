namespace FactoryDesignPattern.Banks
{
    public class BankA : IBank
    {

        public string Pay()
        {
            return "Payment Done with BankA!";
        }

        public string Void()
        {
            return "Void Done with BankA!";
        }

        public string Refund()
        {
            return "Refund Done with BankA!";
        }
    }
}