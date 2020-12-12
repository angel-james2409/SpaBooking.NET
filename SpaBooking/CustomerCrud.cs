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
    class CustomerCrud
    {

        SqlConnection con = null;
        SqlCommand cmd = null;

        public SqlConnection ConnectionEstablish()
        {
            string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            con = new SqlConnection(cs);
            return con;
        }

        public Boolean Readdata()
        {
            bool successflag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand("SELECT customerId,customerName,pass ,walletAmt ,phoneNo ,addres FROM Customer", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine("                CUSTOMER DETAILS       ");
            Console.WriteLine("                                 ");
            while (rdr.Read())
            {

                Console.WriteLine(rdr[0] + "   " + rdr[1] + "  " + rdr[2] + "    " + rdr[3] + "    " + rdr[4] + "    " + rdr[5]);
                successflag = true;
            }
            con.Close();
            return successflag;
        }



        public Boolean CreateData(Customer c)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand("INSERT INTO Customer (customerId,customerName,pass ,walletAmt ,phoneNo ,addres ) VALUES (06,'Nethu','ner#45',2000,89090898,'chennai')", con);

            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
                return successFlag;
            }
            return true;

        }

        public Boolean UpdateData()
        {
            Boolean Flag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand("UPDATE  Customer SET customerName='Pushpa' WHERE customerId=06", con);

            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                Flag = true;
                return Flag;
            }
            return true;

        }
        public Boolean DeleteData()
        {
            Boolean Flag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand("DELETE  FROM  Customer WHERE  customerId=06", con);

            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                Flag = true;
                return Flag;
            }
            return true;

        }



        public Boolean CustomerData(int id)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from dbo.Customer where customerId=  @id ";
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                
                Console.WriteLine("CustomerId : " + rdr[0] + " CustomerName :  " + rdr[1] + " Password : " + rdr[2] + " Walletamt : " + rdr[3] + " Phoneno : " + rdr[4] + " Address : " + rdr[5]);
                
                successFlag = true;
            }
            return successFlag;
        }




        public Boolean InsertData(Customer c)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into dbo.customer values (@cid ,@cname,@pwd,@cwamt,@phno,@add)";
            cmd.Parameters.AddWithValue("@cid", c.CustomerId);
            cmd.Parameters.AddWithValue("@cname", c.CustomerName);
            cmd.Parameters.AddWithValue("@pwd", c.Password);
            cmd.Parameters.AddWithValue("@cwamt", c.WalletAmt);
            cmd.Parameters.AddWithValue("@phno", c.PhoneNo);
            cmd.Parameters.AddWithValue("@add", c.Address);
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
            cmd.CommandText = " Delete dbo.Customer where ustomerId = @id";
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
