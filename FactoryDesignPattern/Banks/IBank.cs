namespace FactoryDesignPattern.Banks
{
    public interface IBank
    {
        public string Pay();
        public string Void();
        public string Refund();
    }
}