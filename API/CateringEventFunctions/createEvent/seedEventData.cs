using System;
using System.Data.SQLite;
using API.Cartfunctions;

namespace API.CateringEventFunctions.createEvent
{
    public class seedEventData : iSeedEvent
    {
        public void SeedEventData()
        {
            string cs = @"URI=file:../OrderEvent.db";
            using var con = new SQLiteConnection(cs);
            con.Open(); 

            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DROP TABLE IF EXISTS OrderEvent";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE cart(orderID INTEGER PRIMARY KEY, orderPlaced DATETIME, orderDate DATETIME, fulfilledStatus BOOL, orderEventMethod INTEGER, orderDescription TEXT)";
            cmd.ExecuteNonQuery();
        }
    }
}
