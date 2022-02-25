namespace FactoryDesignPattern.Banks
{
    public class BankB : IBank
    {
        public string Pay()
        {
            return "Payment Done with BankB!";
        }

        public string Void()
        {
            return "Void Done with BankB!";
        }

        public string Refund()
        {
            return "Refund Done with BankB!";
        }
    }
}