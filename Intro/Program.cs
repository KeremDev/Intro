// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

stonesmanager stonesmanager = new();
Stones[] stoneses2 = stonesmanager.GetAll();

for (int i = 0; i < stoneses2.Length; i++)
{
    Console.WriteLine("Taş İsmi: " + stoneses2[i].Name + " / " + "Taş Rengi: " + stoneses2[i].Color + " / " + "Fiyatı: " + stoneses2[i].Price);
}

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "1234123322";
customer1.FirstName = "Kerem";
customer1.LastName = "Kayalar";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "2134423434";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "1231244351";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "1231244352";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

foreach (BaseCustomer customer in customers)
{       
    Console.WriteLine(customer.CustomerNumber);
}