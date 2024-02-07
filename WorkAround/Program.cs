using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;

namespace WorkAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Person person1 = new Person();
            //person1.FirstName = "Çağdaş";
            //person1.LastName = "Özer";
            //person1.DateOfBirth = 1997;
            //person1.NationalIdentity = 12345678901;

            //Foreign person2 = new Foreign();
            //person2.FirstName = "Alex";
            //person2.LastName = "Souza";
            //person2.DateOfBirth = 1997;
            //person2.ForeignNationalIdentity = 1234;

            //PttManager pttManager = new PttManager(new PersonManager());
            //pttManager.GiveMask(person1);

            //PttManager pttManager1 = new PttManager(new PersonManager());
            //pttManager1.GiveMask(person2);



            ISupplierService<Person> supplierservice1 = new PttManager<Person>(new PersonManager());

            supplierservice1.GiveMask(new Person()
            {
                NationalIdentity = 24243234,
                FirstName = "Çağdaş",
                LastName = "Özer",
                DateOfBirth = 1997
            });

            ISupplierService<Foreign> supplierservice2 = new PttManager<Foreign>(new ForeignerManager());

            supplierservice2.GiveMask(new Foreign()
            {
                NationalIdentity = 1234,
                FirstName = "Ulaş",
                LastName = "Özer",
                DateOfBirth = 1997
            });


        }
    }
}
