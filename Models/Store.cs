using System;
using System.Collections.Generic;

namespace codeshop.Models
{
  class Store
  {
    public string Name { get; set; }
    public List<Item> Items { get; set; }

    public Store(string name, List<Item> items)
    {
      Name = name;
      Items = items;
    }

    public void PrintItems()
    {
      var ogColor = Console.ForegroundColor;
      for (int i = 0; i < Items.Count; i++)
      {
        Item item = Items[i];
        if (item.IsOnSale) Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine($"{i + 1}. {item.Name} - {item.Quantity}. ${item.Price}");
        Console.ForegroundColor = ogColor;
      }
    }

    internal bool DrawCommands()
    {
      System.Console.WriteLine("Enter:\n1. Buy Product \n2. Add Product \n3. Edit Product \n 4. Exit");
      int choice;
      while (!Int32.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 4))
      {
        System.Console.WriteLine("Please enter a valid number.");
      }
      bool stayShopping = true;
      switch (choice)
      {
        case 1:
          Purchase();
          break;
        case 2:
          Add();
          break;
        case 3:
          Edit();
          break;
        default:
          stayShopping = false;
          break;
      }
      return stayShopping;
    }

    public void Edit()
    {
      System.Console.WriteLine("youre in the edit");
    }

    public void Add()
    {
      System.Console.WriteLine("youre in the add");
    }

    public void Purchase()
    {
      Console.Clear();
      PrintItems();
      System.Console.WriteLine("What item to you want to purchase?");
      int choice;
      while (!Int32.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > Items.Count))
      {
        System.Console.WriteLine("Please enter a valid number.");
      }
      Item item = Items[choice - 1];
      System.Console.WriteLine($"How many {item.Name}s would you like to buy?");
      while (!Int32.TryParse(Console.ReadLine(), out choice))
      {
        System.Console.WriteLine("enter a valid number");
      }
      if (choice <= item.Quantity)
      {
        item.Quantity -= choice;
        System.Console.WriteLine($"Your bill is {item.Price * choice}. Thanks!");
        Console.ReadLine();
      }
    }
  }
}