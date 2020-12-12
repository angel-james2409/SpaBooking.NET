using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaBooking
{
    class Booking
    {
        private int _bookingId;
        private int _serviceNumber;
        private int _offerNumber;
        private String _location;
        private String _date;
        private String _time;
        private String _status;

        




        public Booking(int bookingId, int serviceNumber, int offerNumber, String location, String date, String time,String status)
        {
            _bookingId = bookingId;
            _serviceNumber = serviceNumber;
            _offerNumber = offerNumber;
            _location = location;
            _date = date;
            _time = time;
            _status = status;

        }



        public int BookingId
        {
            get { return this._bookingId; }
            set { this._bookingId = value; }
        }
        public int ServicaNumber
        {
            get { return this._serviceNumber; }
            set { this._serviceNumber = value; }
        }
        public int OfferNumber
        {
            get { return this._offerNumber; }
            set { this._offerNumber = value; }
        }


        public String Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        public String Date

        {
            get { return this._date; }
            set { this._date = value; }
        }
        public String Time

        {
            get { return this._time; }
            set { this._time = value; }
        }
        public String Status

        {
            get { return this._status; }
            set { this._status = value; }
        }
    }
}
