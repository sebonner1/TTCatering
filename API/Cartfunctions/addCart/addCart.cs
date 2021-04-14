using System;
using API.Cartfunctions;
using System.Data.SQLite;

namespace TTCatering.Cartfunctions.addCart
{
    public class addCart : iAddCart
    {
        public void addCartItem(int id, string value)
        {
            string cs = @"URI=/Users/katherine/Documents/TTCatering/API/Cartfunctions/cart.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            string stm = @"UPDATE cart set number = '" + value + "' WHERE cartid = @id";
            using var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}
