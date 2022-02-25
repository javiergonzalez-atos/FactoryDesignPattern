using FactoryDesignPattern.Factory;
using FactoryDesignPattern.Banks;
using System;

namespace FactoryDesignPattern.Services
{
    public class BankService : IBankService
    {
        private readonly BankFactory _bankFactory;

        public BankService(BankFactory bankFactory)
        {
            _bankFactory = bankFactory;
        }
        
        public string MakePayment()
        {
            var bankType = GetRandomBankType();
            
            IBank bank = _bankFactory.CreateBank(bankType);

            return bank.Pay();
        }

        public string MakeVoid()
        {
            var bankType = GetRandomBankType();

            IBank bank = _bankFactory.CreateBank(bankType);

            return bank.Void();
        }

        public string MakeRefund()
        {
            var bankType = GetRandomBankType();

            IBank bank = _bankFactory.CreateBank(bankType);

            return bank.Refund();
        }
        
        private static BankType GetRandomBankType()
        {
            var banks = Enum.GetValues(typeof(BankType));
            var random = new Random();
            
            var bankType = (BankType?)banks.GetValue(random.Next(banks.Length));

            return bankType ?? BankType.BankA;

        }
    }
}