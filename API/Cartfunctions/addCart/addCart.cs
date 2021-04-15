using System;
using API.Cartfunctions;
using System.Data.SQLite;

namespace TTCatering.Cartfunctions.addCart
{
    public class addCart : iAddCart
    {
        public void addCartItem(int id, cart value)
        {
            string cs = @"URI=file:../cart.db";
            using var con = new SQLiteConnection(cs);
            con.Open();
            
            var newQ = value.quantity +1;

            string stm = @"UPDATE cart set quantity = '" + newQ + "' WHERE cartid = @id";
            using var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            string css = @"URI=file:../cart.db";
            using var cons = new SQLiteConnection(css);
            con.Open();
            
            var newP = value.price * newQ;

            string stms = @"UPDATE cart set price = '" + newP + "' WHERE cartid = @id";
            using var cmds = new SQLiteCommand(stms, cons);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}
