using System;
using API.Cartfunctions;
using System.Data.SQLite;
using API.TotalCartFunctions;

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
            var newP = (value.price / value.quantity) * newQ;
            Console.WriteLine(value.price + " "+ newQ);

            string stm = @$"UPDATE cart set quantity = {newQ}, price = {newP} WHERE cartid = @id";
            using var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
            int orderID = pushData.orderID;
            addChickenParm.Add(orderID, value);
        }
    }
}
