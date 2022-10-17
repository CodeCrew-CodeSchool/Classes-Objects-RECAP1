

// Remember this guy? 
namespace PizzaStore.Classes
{

    // This is pretty cool.. Here we can make a method that has predefined values
    // depending on the type the guest wants. We use conditionals to check!
  public class Pizza
  {
    // just settings our props .. nothing out of the ordinary 
    public string Name { get; set; }
    public string[] Ingredients { get; set; }
    public decimal Price { get; set; }
    // default value here!
    public string Dough { get; set; } = "Hand Tossed";
    public string Sauce { get; set; }
    public int Slices { get; set; }

    public Pizza(string type)
    {
// if a guest gets a philly pizza
      if (type == "philly")
      {
        // these values will be set for the pizza
        Name = "Cheese";
        Ingredients = new string[] { "Mozzarella", "Romano" };
        Sauce = "Tomato";
        Price = 14.99m;
        Slices = 8;
      }
      // same with white
      else if (type == "white")
      {
        Name = "White";
        Ingredients = new string[] { "Mozzarella", "Ricotta", "Romano", "Roma Tomatoes" };
        Sauce = "Garlic and Oil";
        Price = 19.99m;
        Slices = 8;
      }

      // else ... for sicilian, yuppie, etc.
    // these will be run.. one at a time
        Prepare();
        Bake("standard");
        Cut(Slices);
        Deliver("Home");
    }
// these are the methods being called!
    public void Prepare()
    {
      Console.WriteLine("Assembling it!");
    }

    public void Bake(string baketype)
    {
      if (baketype == "wood fired")
      {
        Console.WriteLine("Putting it in the wood oven");
      }
      else
      {
        Console.WriteLine("Put it in the standard oven");
      }
    }

    public void Cut(int slices)
    {
      Console.WriteLine($"Pizza was cut into {slices}");
    }

    public void Deliver(string address)
    {
      Console.WriteLine($"Delivering the pizza to {address}");
    }

  }
}