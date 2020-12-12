using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaBooking
{
    class EmployeeRecords
    {
        List<Admin> emplist = null;

        public EmployeeRecords()
        {
            emplist = new List<Admin>();
            emplist.Add(new Admin(10, "CharanAdmin", "password","fire cut", 1234));
            emplist.Add(new Admin(20, "ytfytvuyv", "password","thai massage" ,4321));
        }

        public void add(Admin employee)
        {
            emplist.Add(employee);
        }

        public Admin getEmployee(int EmployeeId)
        {
            return emplist.Find(E => E.AdminId == EmployeeId);
        }

    }
}
