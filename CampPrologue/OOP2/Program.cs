using OOP2;

IndividualCustomer individualCustomer = new IndividualCustomer();
individualCustomer.id = 1;
individualCustomer.firstName = "Furkan";
individualCustomer.lastName = "Gerem";
individualCustomer.customerNumber = "1234";
individualCustomer.identityNumber = "12345678910";

CorporateCustomer corporateCustomer = new CorporateCustomer();
corporateCustomer.id = 2;
corporateCustomer.customerNumber = "54321";
corporateCustomer.companyName = "Kodlama.io";
corporateCustomer.taxNumber = "1234567890";

Customer customer = new IndividualCustomer();
Customer customer1 = new CorporateCustomer();

// Inheritance
CustomerManager customerManager = new CustomerManager();
customerManager.Add(individualCustomer);
customerManager.Add(corporateCustomer);