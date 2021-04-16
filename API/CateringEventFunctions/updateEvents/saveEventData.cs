using System;
using API.Cartfunctions;
using System.Data.SQLite;
using API.CateringEventFunctions.removeEvent;

namespace API.CateringEventFunctions.updateEvents
{
    public class saveEventData : iPostEvent
    {
        public void UpdateEvent(int orderID, DateTime orderPlaced, bool fulfilledStatus, int orderEventMethod, string orderDescription)
        {
            string cs = @"URI=file:../OrderEvent.db"; // make this a static class!!
            using var con = new SQLiteConnection(cs);
            con.Open(); 
            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = @"INSERT INTO OrderEvent(orderID, orderPlaced, fulfilledStatus, orderEventMethod, orderDescription) VALUES(@orderID, @orderPlaced, @fulfilledStatus, @orderEventMethod, @orderDescription)";
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@orderPlaced", DateTime.Now);
            cmd.Parameters.AddWithValue("@fulfilledStatus", fulfilledStatus);
            cmd.Parameters.AddWithValue("@orderEventMethod", orderEventMethod);
            cmd.Parameters.AddWithValue("@orderDescription", orderDescription);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}
