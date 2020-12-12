using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpaBooking
{
    class BookingRecords
    {
        List<Booking> booklist = null;


        public BookingRecords()
        {
            booklist = new List<Booking>();
         
        }


        public void add(Booking booking)
        {
            booklist.Add(booking);
        }

        public Booking getBooking(int bookingid)
        {
            return booklist.Find(c => c.BookingId == bookingid);
        }
    }
}
