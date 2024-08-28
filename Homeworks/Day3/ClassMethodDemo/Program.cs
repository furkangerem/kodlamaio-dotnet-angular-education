using ClassMethodDemo;

Customer customer = new Customer("Furkan", "Gerem", 26);
Customer customer1 = new Customer("Muhammed", "Gerem", 13);

CustomerManager customerManager = new CustomerManager();
customerManager.addCustomer(customer);
customerManager.addCustomer(customer1);

Customer[] customers = new Customer[] { customer, customer1 };
customerManager.getWholeCustomers(customers);

customerManager.deleteCustomer(customer);
customerManager.deleteCustomer(customer1);