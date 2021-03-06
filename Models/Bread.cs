namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price { get; set; }
    public int Amount {get; set; }

    public int Total { get; set; }

    public Bread(int price, int amount, int total)
    {
      Price = price;
      Amount = amount;
      Total = total;
    }

    public void breadBag()
    {
      calculateBreadPrice();
    }

    private void calculateBreadPrice()
    {
      if (Amount % 2 == 0)
      {
        Total = (Price * Amount);
        Amount ++;
      }
      else
      {
        Total = (Price * Amount);
      }
    }
  }
}