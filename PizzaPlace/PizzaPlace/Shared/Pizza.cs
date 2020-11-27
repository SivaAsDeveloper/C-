using System;
//Class to hold the Pizza base information
namespace PizzaPlace.Shared
{
    //Enum which holds the different spiciness of Pizza
    public enum Spiciness
    {
        None,
        Hot,
        Spicy
    }
    public class Pizza{
        //Properties of Pizza
        public int Id{get;}
        public string Name{get;}
        public decimal Price{get;}
        public Spiciness Spiciness{get;}

        public Pizza(int id,string name,decimal price,Spiciness spiciness)
        {
            this.Id=id;
            this.Name=name??
            throw new ArgumentNullException(nameof(name),
            "A Pizza needs a name");
            this.Price=price;
            this.Spiciness=spiciness;
        }
    }
}