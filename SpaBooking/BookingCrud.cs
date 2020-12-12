using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SpaBooking
{
    class BookingCrud
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        public SqlConnection ConnectionEstablish()
        {
            string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            con = new SqlConnection(cs);
            return con;
        }

        public Boolean BookingData(int id)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from dbo.Booking where bookingId=  @id ";
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                
                Console.WriteLine("bookingId : " + rdr[0] + " serviceName :  " + rdr[1] + " offers : " + rdr[2] + " location : " + rdr[3] + " bdate : " + rdr[4] + " btime : " + rdr[5] +  "bstatus:" + rdr[6]);
              
                successFlag = true;
            }
            return successFlag;
        }


        public Boolean DisplayBooking()
        {
            bool successflag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand("SELECT* FROM Booking", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine("                Booking DETAILS       ");
            Console.WriteLine("                                 ");
            while (rdr.Read())
            {

                Console.WriteLine(rdr[0] + "   " + rdr[1] + "  " + rdr[2] + "    " + rdr[3] + "    " + rdr[4] + "    " + rdr[5] + "    " + rdr[6] );
                successflag = true;
            }
            con.Close();
            return successflag;
        }


        public Boolean UpdateData( int bid,string sname)
    {
        Boolean successFlag = false;
        con = ConnectionEstablish();
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Update dbo.Booking set Bstatus = @sname where bookingId = @bid";
        cmd.Parameters.AddWithValue("@sname", sname);
        cmd.Parameters.AddWithValue("@bid", bid);
        con.Open();
        int count = cmd.ExecuteNonQuery();
        if (count > 0)
        {
            successFlag = true;
        }
        return successFlag;

    }
}
}
