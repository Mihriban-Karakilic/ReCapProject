using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ReCap
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManagers = new CarManager(new InMemoryCarDal());
            foreach (var carManager in carManagers.GetAll())
            {
                Console.WriteLine(carManager.Id+ " "+carManager.ModelYear+" "+carManager.Description);
            }
            Console.Read();
        }
    }
}