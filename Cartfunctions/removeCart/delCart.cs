using System;

namespace TTCatering.Cartfunctions.removeCart
{
    public class delCart : iDelCart
    {
        public void DeleteCartItem(int value)
        {
            string cs = @"placeholder";
            using var con = new SQLiteConnection(cs);
            con.Open(); 

            string stm = @"DELETE FROM posts WHERE postid =@id";
            using var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("@id",value);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}
