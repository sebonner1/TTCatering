using System;

namespace TTCatering.Cartfunctions.addCart
{
    public class addCart : iAddCart
    {
        public void addCartItem(int value)
        {
            string cs = "placeholder";
            using var con = new SQLiteConnection(cs);
            con.open();

            string stm = @"UPDATE cart set number = '" + value + "' WHERE cartid = @id";
            using var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            return value;
        }
    }
}
