using System.Collections.Generic;
using API.CateringEventFunctions;
using System;
using System.Data.SQLite;
using System.IO;

namespace API.CateringEventFunctions.getEvents
{
    public class readEventData : iReadAllEventData
    {
        public List<CateringEvent> GetAllItems()
        {
            List<CateringEvent> allCateringEvents = new List<CateringEvent>();

            string cs = @"URI=file:../OrderEvent.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM OrderEvent";
            using var cmd = new SQLiteCommand(stm, con);

            using SQLiteDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                CateringEvent temp = new CateringEvent(){orderID = rdr.GetInt32(0), orderPlaced = rdr.GetDateTime(10), fulfilledStatus = rdr.GetBoolean(5), orderEventMethod = rdr.GetInt32(2), orderDescription = rdr.GetString(32)};
                allCateringEvents.Add(temp);
            }

            return allCateringEvents;
        }
    }
}