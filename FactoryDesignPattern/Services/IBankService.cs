namespace FactoryDesignPattern.Services
{
    public interface IBankService
    {
        public string MakePayment();
        public string MakeVoid();
        public string MakeRefund();

    }
}
