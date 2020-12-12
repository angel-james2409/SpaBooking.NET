using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaBooking
{
    class Admin
    {
        private int _adminId;
        private string _adminName;
        private string _password;
        private string _specilist;
        private long _phoneNo;


        public Admin(int adminId, string adminName, string password,String  Specilist, long phoneNo)
        {
            _adminId = adminId;
            _adminName = adminName;
             _password = password;
            _specilist = Specilist;
            _phoneNo = phoneNo;

        }


        public int AdminId
        {
            get { return this._adminId; }
            set { this._adminId = value; }
        }
        public string AdminName
        {
            get { return this._adminName; }
            set { this._adminName = value; }
        }
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }
        public string Specilist
        {
            get { return this._specilist; }
            set { this._specilist = value; }
        }

        public long PhoneNo
        {
            get { return this._phoneNo; }
            set { this._phoneNo = value; }
        }

    }
}
