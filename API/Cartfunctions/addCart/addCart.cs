using System;
using API.Cartfunctions;
using System.Data.SQLite;

namespace TTCatering.Cartfunctions.addCart
{
    public class addCart : iAddCart
    {
        public void addCartItem(int id, cart value)
        {
            string cs = @"URI=/Users/katherine/Documents/TTCatering/API/Cartfunctions/cart.db";
            using var con = new SQLiteConnection(cs);
            con.Open();
            
            var newQ = value.quantity +1;

            string stm = @"UPDATE cart set quantity = '" + newQ + "' WHERE cartid = @id";
            using var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            //con.Close();

            // string css = @"URI=/Users/katherine/Documents/TTCatering/API/Cartfunctions/cart.db";
            // using var cons = new SQLiteConnection(css);
            // cons.Open();
            
            var newP = value.price * newQ;
            Console.WriteLine(value.price + " "+ newQ);

            string stms = @"UPDATE cart set price = '" + newP + "' WHERE cartid = @id";
            using var cmds = new SQLiteCommand(stms, con);
            cmds.Parameters.AddWithValue("@id", id);
            cmds.Prepare();
            cmds.ExecuteNonQuery();
            con.Close();
        }
    }
}
