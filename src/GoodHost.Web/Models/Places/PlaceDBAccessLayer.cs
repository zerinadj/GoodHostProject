using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using GoodHost.Web.Models;
namespace GoodHost.Web.Models.Places
{
    public class PlaceDBAccessLayer
    {
        SqlConnection con = new SqlConnection("Data Source = 195.130.32.34, 1032; User ID = sa; Password=pmf911; Initial Catalog = GoodHostDB");
        public string AddPlaceRecord(Place places)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Place_Add", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", places.Name);
                cmd.Parameters.AddWithValue("@Kind", places.Kind);
                cmd.Parameters.AddWithValue("@MaxNum", places.MaxOfGuests);
                cmd.Parameters.AddWithValue("@RoomType", places.Rooms);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Data save Successfully");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }
        }
    }
}
