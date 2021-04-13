using System;
using System.data.SQLite;
namespace TTCatering.Cartfunctions
{
    public class saveData : iReadAllData, iGetCart
    {
        public void SeedData()
        {
            string cs = @"URI=/Users/katherine/Documents/TitleTownCatering/Cartfunctions/cart.db";
            using var con = new SQLiteConnection(cs);
            con.Open(); 

            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DROP TABLE IF EXISTS cart";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE cart(itemid INTEGER PRIMARY KEY, itemName TEXT, price DOUBLE, quantity INTEGER)";
            cmd.ExecuteNonQuery();
        }
        public List<cart> GetAllItems()
        {
            List<cart> allItems = new List<cart>();

            string cs = @"URI=/Users/katherine/Documents/TitleTownCatering/Cartfunctions/cart.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM cart";
            using var cmd = new SQLiteCommand(stm, con);

            using SQLiteDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                cart temp = new cart(){cartid = rdr.GetInt32(0), itemName = rdr.GetString(1), price = rdr.GetDouble(2), quantity = rdr.GetInt32(3)};
                allItems.Add(temp);
            }

            return allItems;
        }
    }
}
