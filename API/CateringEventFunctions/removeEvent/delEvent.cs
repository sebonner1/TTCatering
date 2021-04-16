using System;
using API.CateringEventFunctions;
using System.Data.SQLite;

namespace API.CateringEventFunctions.removeEvent
{
    public class delEvent : iDelEvent
    {
        public void DeleteOrderEvent(int value)
        {
            string cs = @"URI=file:../OrderEvent.db";
            using var con = new SQLiteConnection(cs);
            con.Open(); 

            string stm = @"DELETE FROM OrderEvent WHERE OrderID =@id";
            using var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("@id",value);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}
