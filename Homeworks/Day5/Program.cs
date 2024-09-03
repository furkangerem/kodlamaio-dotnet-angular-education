using Day5.Concrete;
using Day5.Entities;

Console.WriteLine("Customer Methods");
Customer customer = new Customer() { id = 1, firstName = "Furkan", lastName = "Gerem", yearOfBirth = 1998, identityNumber = 11111111111 };
CustomerManager customerManager = new CustomerManager(new MernisManager());
customerManager.Add(customer);
customerManager.Update(customer);
customerManager.Remove(customer);
Console.WriteLine("Customer Methods");

Console.WriteLine("Campaign Methods");
Campaign campaign = new Campaign() { id = 1, name = "Riot -Best Seller- Campaign" };
CampaignManager campaignManager = new CampaignManager();
campaignManager.Add(campaign);
campaignManager.Update(campaign);
campaignManager.Remove(campaign);
Console.WriteLine("Campaign Methods");

Console.WriteLine("Game Methods");
Game game = new Game() { id = 1, name = "League of Legends", price = 100 };
GameManager gameManager = new GameManager();
gameManager.Buy(customer, game, campaign);
Console.WriteLine("Game Methods");