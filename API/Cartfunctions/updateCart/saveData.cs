using System;
using API.Cartfunctions;
using System.Data.SQLite;

namespace TTCatering.Cartfunctions.updateCart
{
    public class saveData : iPostCart
    {
        public void UpdateCart(string value, double price)
        {
            string cs = @"URI=/Users/katherine/Documents/TTCatering/API/Cartfunctions/cart.db";
            using var con = new SQLiteConnection(cs);
            con.Open(); 
            Console.WriteLine("I made it to the price and it is " + price);
            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = @"INSERT INTO cart(itemName, quantity, price) VALUES(@itemName, @quantity, @price)";
            cmd.Parameters.AddWithValue("@itemName", value);
            cmd.Parameters.AddWithValue("@quantity", 1);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}
