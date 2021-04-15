using System;
using System.Data.SQLite;

namespace API.CateringEventFunctions.addEvent
{
    public class addEvent : iAddEvent
    {
        public void addOrderEvent(int orderID, DateTime orderPlaced, bool fulfilledStatus, int orderEventMethod, string orderDescription)
        {
            string cs = @"URI=file:../OrderEvents.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            string stm = @"UPDATE cart set quantity = '" + "' WHERE orderID = @id";
            using var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", orderID);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}