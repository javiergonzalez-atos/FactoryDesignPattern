namespace FactoryDesignPattern.Banks
{
    public class NeoBankA : IBank
    {
        public string Pay()
        {
            return "Payment Done with NeoBankA!";
        }

        public string Void()
        {
            return "Void Done with NeoBankA!";
        }

        public string Refund()
        {
            return "Refund Done with NeoBankA!";
        }
    }
}