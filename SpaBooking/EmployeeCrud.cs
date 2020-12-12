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
    class EmployeeCrud
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        public SqlConnection ConnectionEstablish()
        {
            string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            con = new SqlConnection(cs);
            return con;
        }

        public Boolean ReadData()
        {
            bool successflag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand("SELECT * FROM Admin", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine("                ADMIN DETAILS       ");
            Console.WriteLine("                                 ");
            while (rdr.Read())
            {

                Console.WriteLine(rdr[0] + "   " + rdr[1] + "  " + rdr[2] + "    " + rdr[3] + "    " + rdr[4]);
                successflag = true;
            }
            con.Close();
            return successflag;
        }

        public Boolean InsertData(Admin a)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into dbo.Admin values (@aid ,@aname,@pwd,@specil,@phno)";
            cmd.Parameters.AddWithValue("@aid", a.AdminId);
            cmd.Parameters.AddWithValue("@aname", a.AdminName);
            cmd.Parameters.AddWithValue("@pwd", a.Password);
            cmd.Parameters.AddWithValue("@specil", a.Specilist);
            cmd.Parameters.AddWithValue("@phno", a.PhoneNo);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;


        }
        public Boolean DeleteData(int id)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = " Delete dbo.Admin where AdminId = @id";
            cmd.Parameters.AddWithValue("@id", id);
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