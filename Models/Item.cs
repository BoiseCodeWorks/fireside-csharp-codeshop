namespace codeshop.Models
{
  class Item
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public bool IsOnSale { get; set; }

    public Item(string n, decimal p, int q, bool sale)
    {
      Name = n;
      Price = p;
      Quantity = q;
      IsOnSale = sale;
    }
  }
}