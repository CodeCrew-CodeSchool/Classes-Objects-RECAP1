// See https://aka.ms/new-console-template for more information


using System;

using PizzaStore.Classes;

namespace PizzaStore
{
  class Program
  {
    static void Main(string[] args)
    {
        
    CreateStore();
   
    
}

// Dynamically create store!
  static void CreateStore(){
        Console.WriteLine("Hello Potential Buyer! What would you like your store to be called?");

        string storeName = Console.ReadLine();
        Console.WriteLine("What is your store address?");
        string storeAddress = Console.ReadLine();
        Console.WriteLine("Phone number was set");

        Store store1 = new Store(){
        Name = storeName,
        Address = storeAddress,
        Phone = "215-555-1212"
        };
        Console.WriteLine($"Store details: {store1.Name}, {store1.Address}, {store1.Phone}");
        Console.WriteLine($"Thx friend, Opening Store...");
        store1.Open(); // opens store
        // Calls the method pizza, but with different orders!
        Pizza pizza = store1.Order("philly");
        Pizza pizza2 = store1.Order("vegan");

    }
    }


}