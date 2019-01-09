using System;
using System.Collections.Generic;
using codeshop.Models;

namespace codeshop
{
  class Program
  {
    static void Main(string[] args)
    {
      //Initialize data for my store
      Console.Clear();
      Item rope = new Item("BD Rope", 195.99m, 14, false);

      List<Item> items = new List<Item>() { rope,
      new Item("Quick Draw", 49.99m, 16, true),
      new Item("ATC", 47.99m, 6, true),
      new Item("Cams", 89.99m, 12, false)
       };
      Store store = new Store("ClimbOn", items);

      //Draw store to console and menu navigation
      while (true)
      {
        Console.Clear();
        System.Console.WriteLine($"Welcome to the {store.Name}");
        store.PrintItems();
        System.Console.WriteLine(); // really hacky space
        if (!store.DrawCommands()) break;
      }

    }
  }
}
