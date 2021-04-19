using System;
using System.Data.SQLite;
using API.TotalCartFunctions;
using API.Cartfunctions;

namespace API.TotalCartFunctions
{
    public class addChickenParm
    {
        public static void Add(int id, cart value)
        {
            string cs = @"URI=file:../carttotals.db";
            using var con = new SQLiteConnection(cs);
            con.Open();
            
            var newQ = value.quantity +1;
            var newP = (value.price / value.quantity) * newQ;
            Console.WriteLine(value.price + " "+ newQ);

            string stm = @$"UPDATE carttotals set qckparm = {newQ}, pckparm = {newP} WHERE orderID = @id";
            using var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}