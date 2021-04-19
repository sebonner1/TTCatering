using System;
using API.Cartfunctions;
using System.Data.SQLite;
using API.TotalCartFunctions;

namespace TTCatering.Cartfunctions.removeCart
{
    public class delCart : iDelCart
    {
        public void DeleteCartItem(int value)
        {
            string cs = @"URI=file:../cart.db";
            using var con = new SQLiteConnection(cs);
            con.Open(); 

            string stm = @"DELETE FROM cart WHERE cartid =@id";
            using var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("@id",value);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            deleteChickenParm.Delete(value);
        }
    }
}
