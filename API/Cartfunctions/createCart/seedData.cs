using System;
using System.Data.SQLite;
using API.Cartfunctions;
namespace TTCatering.Cartfunctions
{
    public class seedData : iSeedCart
    {
        public void SeedData()
        {
            string cs = @"URI=/Users/katherine/Documents/TTCatering/API/Cartfunctions/cart.db";
            using var con = new SQLiteConnection(cs);
            con.Open(); 

            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DROP TABLE IF EXISTS cart";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE cart(cartid INTEGER PRIMARY KEY, itemName TEXT, price DOUBLE, quantity INTEGER)";
            cmd.ExecuteNonQuery();
        }
    }
}
