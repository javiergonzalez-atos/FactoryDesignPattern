using FactoryDesignPattern.Banks;
using System;

namespace FactoryDesignPattern.Factory
{
    public class BankFactory
    { 
        public IBank CreateBank(BankType bankType)
        {
            switch (bankType)
            {
                case BankType.BankA:
                    return new BankA();
                case BankType.BankB:
                    return new BankB();
                case BankType.NeoBankA:
                    return new NeoBankA();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}