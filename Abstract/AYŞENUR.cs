using Aysenur_Krcy.Concrete;
using System;


namespace Aysenur_Krcy.Abstract
{
    class Program
    {
        private static readonly IEmployee barista;

        static void Main()
        {
            WorkPool workPool = new WorkPool();
            IEmployee cashier1 = new Cashier { Id = 1, Name = "Cashier 1" };
            IEmployee cashier2 = new Cashier { Id = 2, Name = "Cashier 2" };
            IEmployee barista = new Barista { Id = 3, Name = "Barista 1" };

            workPool.AddEmployee(cashier1);
            workPool.AddEmployee(cashier2);
            workPool.AddEmployee(barista);

            cashier1.TakeOrder(workPool);
            cashier2.TakeOrder(workPool);
            barista.TakeOrder(workPool);
        }
    }
}
