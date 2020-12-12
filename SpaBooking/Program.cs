using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaBooking
{
 
   class Program
    {
        CustomerRecords c = new CustomerRecords();
        EmployeeRecords e = new EmployeeRecords();
        BookingRecords bo = new BookingRecords();

        CustomerCrud cc = new CustomerCrud();
        EmployeeCrud ec = new EmployeeCrud();
        BookingCrud bc = new BookingCrud();

        private void mainMenu()
        {
            Console.WriteLine("welcome to onlineSpabooking");


            Console.WriteLine("1.login as admin");
            Console.WriteLine("2.login as customer");
            Console.WriteLine("3.exit");
            mainMenuDetails();
        }
        private void mainMenuDetails()
        {
            Console.WriteLine("enter your choice...");

            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    AdminLogin();
                    break;
                case 2:
                    CustomerLogin();
                    break;
                case 3:
                    AcceptReject();
                    break;

                case 4:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("choose either 1 or 2 or 3");
                    break;
            }
        }


        public void AdminLogin()
        {
            Console.WriteLine("Please enter your PhoneNumber");
            long phno = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Please enter your Password");
            string pwd = Console.ReadLine();
            adminMenu();
            // bool flag = al.ALoginCheck(phno,pwd);
            //Boolean flag = ac.LoginCheck(phno, pwd); if (flag == true) 
            //
            //{
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Thanks for logging");
            //Console.ResetColor(); 
            //adminMenu(); } 
            //else { 

            //Console.WriteLine("Invalid Credentials");

            //mainMenu();
        }
        private void adminMenu()
        {


            Console.WriteLine("1. customer Details");
            Console.WriteLine("2. add customer");
            Console.WriteLine("3. Delete Customer");
            Console.WriteLine("4. employee Details");
            Console.WriteLine("5. add employee");
            Console.WriteLine("6. Delete Customer"); 
            Console.WriteLine("7. View Booking Details");
            Console.WriteLine("8. Accept/ Reject Booking");
            Console.WriteLine("9. exit");
            Console.WriteLine("enter your choice");
            int j = Convert.ToInt32(Console.ReadLine());
            switch (j)
            {
                case 1:
           
                     cc.Readdata();
                    
                    break;
                case 2:
                    addCustomer();
                    break;
                case 3:
                    DeleteCustomer();
                    break;
                case 4:
                    ec.ReadData();
                    break;
                case 5:
                    addEmployee();
                    break;
                case 6:
                    DeleteEmployee();
                    break;


                case 7:
                    bc.DisplayBooking();
                    break;
                case 8:
                    UpdateBooking();
                    break;
                case 9:
                    mainMenu();
                        
                    //System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("choose either 1 or 2 or 3");
                    break;
            }
            adminMenu();

        }
        private void getCustomer()
        {
            Console.WriteLine("Enter the CusID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Boolean Customer = cc.CustomerData(id);

            if(!Customer)
            {
                Console.WriteLine("no data");
            }
               
        }
        private void DeleteCustomer()
        {
            Console.WriteLine("Enter the CusID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Boolean Customer = cc.DeleteData(id);

            if (!Customer)
            {
                Console.WriteLine("no data");
            }

        }

        private void addCustomer()
        {
            Console.WriteLine("addCustomer:");
            Console.WriteLine("Enter Id:");
            int customerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            String customerName = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            String customerPassword = Console.ReadLine();
            Console.WriteLine("WalletAmount:");
            double walletAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("phone:");
            long phone = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Address:");
            String address = Console.ReadLine();
            Customer c2 = new Customer(customerId, customerName, customerPassword, walletAmount, phone, address);
            cc.InsertData(c2);
            Console.WriteLine("                                                                ");
            Console.WriteLine("         New Customer Added          ");
            
            Console.WriteLine("Id = {0}, Name = {1},Password = {2}, WalletAmount = {3}, Phone = {4}, Address = {5}", c2.CustomerId , c2.CustomerName ,c2.Password ,c2.WalletAmt ,c2.PhoneNo ,c2.Address);
            
           

        }



        private void DeleteEmployee()
        {
            Console.WriteLine("Enter the EmpID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Boolean Admin = ec.DeleteData(id);

            if (!Admin)
            {
                Console.WriteLine("no data");
            }

        }


        private void getEmployee()
        {
            Console.WriteLine("Enter the EmpId:");
            int id = Convert.ToInt32(Console.ReadLine());
            
            Admin a = e.getEmployee(id);
            if (e == null)
            {
                Console.WriteLine("The empId{0} is Correct");
            }
            else
            {
                Console.WriteLine("Id = {0},Name = {1},password = {2},specilist = {3},phone: {4}", a.AdminId, a.AdminName, a.Password,a.Specilist, a.PhoneNo);
            }
        }

        private void addEmployee()
        {
            Console.WriteLine("addEmployee:");
            Console.WriteLine("id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("name:");
            String name = Console.ReadLine();
            Console.WriteLine("password:");
            String password = Console.ReadLine();
            Console.WriteLine("Specilist:");
            String Specilist = Console.ReadLine();
            
            Console.WriteLine("phone:");

            long phone = Convert.ToInt64(Console.ReadLine());
            Admin a2 = new Admin(id, name, password, Specilist,phone);
            ec.InsertData(a2);
            Console.WriteLine("                                                                ");
            Console.WriteLine("         New Customer Added          ");

            Console.WriteLine("Id = {0}, Name = {1},Password = {2}, specilist = {3}, Phone = {4}", a2.AdminId, a2.AdminName, a2.Password, a2.Specilist, a2.PhoneNo);


        }







        private void CustomerMenu()
        {


            Console.WriteLine("1. Services");
            Console.WriteLine("2. Offers");
            
            Console.WriteLine("3.New Booking");
            Console.WriteLine("4.BookingDetails");

            Console.WriteLine("5. Exit");
            Console.WriteLine("enter your choice");
            int j = Convert.ToInt32(Console.ReadLine());
            switch (j)
            {
                case 1:
                    services();
                    break;
               
                case 2:
                    comboOffers();
                    break;
                case 3:
                    addBooking();


                    break;
                case 4:

                    getBooking();
                   

                    break;
                case 5:
                    Console.WriteLine("ThankYou Visit Again");

                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("choose either 1 or 2 or 3");
                    break;
            }
            Console.WriteLine("                                  ");

            Console.WriteLine("MENU");

            CustomerMenu();





        }

        private void services()
        {
            Console.WriteLine("RS.2000 ONLY");
            Console.WriteLine("                       ");
            Console.WriteLine("1.head massage");
            Console.WriteLine("2.hair cuts");
            Console.WriteLine("3.thai massage");
            Console.WriteLine("4.full body massage ");

        }
       
        private void comboOffers()
        {
            Console.WriteLine("1.Massage + Facials");
            Console.WriteLine("2.Massage + haircuts");
            Console.WriteLine("3.Esthetician + pedicure");
            Console.WriteLine("4.Esthetician + massage ");

        }
        private void addBooking()
        {
            Console.Write("\n Enter Booking Id : ");

            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter Service Number : ");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter offer Number : ");
            int o = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter location : ");
            string l = Convert.ToString(Console.ReadLine());

            Console.Write("\n Enter date  : ");
            String d = Convert.ToString(Console.ReadLine());
            Console.Write("\n Enter time  : ");
            String t = Convert.ToString(Console.ReadLine());
            Console.Write("\n Confrim: ");
            String t1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("    BOOKING SUCESSFUL    ");

            bo.add(new Booking(b, j, o, l, d, t,t1));

            //Console.WriteLine( "    BOOKING SUCESSFUL    ");
           

          
            


        }



        private void getBooking()
        {
            Console.WriteLine("Enter the BookingID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Boolean Booking = bc.BookingData(id);

            if (!Booking)
            {
                Console.WriteLine("no data");
            }

        }
        private void BookingDetails()
        {
            Console.WriteLine("Enter the BookingID:");
            int id = Convert.ToInt32(Console.ReadLine());

            Booking e = bo.getBooking(id);
            if (e == null)
            {
                Console.WriteLine("No Booking with id: {0} exists!", id);
            }
            else
            {
                Console.WriteLine("--------Booking Details--------");
                Console.WriteLine("Id = {0} ,Service = {1}, offer = {2}, location = {3}, date = {4}, time = {5}", e.BookingId,
                    e.ServicaNumber, e.OfferNumber, e.Location, e.Date, e.Time);
            }
        }



       





        private void UpdateBooking()
        {
            Console.Write("\n Enter Booking Id : ");


            int b = Convert.ToInt32(Console.ReadLine());
            String y = "Accepted";
            String n = "Rejected";
            Console.WriteLine("do you want to accept");
            string s = Convert.ToString(Console.ReadLine());
            if (s == ("y"))
            {



                bc.UpdateData(b, y);
                Console.WriteLine("sucessful");
            }
            else
            {
                bc.UpdateData(b, n);
                Console.WriteLine("Rejectd");
            }
            
           


            

           


        }




        public void CustomerLogin()
        {
            Console.WriteLine("Please enter your PhoneNumber");
            long phno = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Please enter your Password");
            string pwd = Console.ReadLine();
            CustomerMenu();

            // bool flag = cl.LoginCheck(phno, pwd); Boolean flag = cc.LoginCheck(phno, pwd); if (flag == true) { Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Thanks for logging"); Console.ResetColor(); customerMenu(); } else { Console.ForegroundColor = ConsoleColor.Red;
            // Console.WriteLine("Invalid Credentials"); Console.ResetColor(); 
            //  mainMenu(); }
        }
        public void AcceptReject()
        {
            // private void acceptRejectResponse()

            // showOrders();
            int ordId;
            int cusId;
            Console.WriteLine("enter booking Id");
            ordId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customer Id");
            cusId = Convert.ToInt32(Console.ReadLine());
            String y = "Accepted";
            String n = "Rejected";
            Console.WriteLine("do you want to accept");
            string response = Convert.ToString(Console.ReadLine());
            if (response == ("y"))
            {
                Console.WriteLine(" accepted");
                // AcceptRejectFactory.acceptOrder(ordId, cusId, y);
            }
            else
            {
                Console.WriteLine(" denied");
                //   AcceptRejectFactory.acceptOrder(ordId, cusId, n);
            }

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.mainMenu();

          //  CustomerCrud cc = new CustomerCrud();
           // cc.CreateData();
           //  cc.Readdata();
           // cc.UpdateData();
            //cc.Readdata();
            //cc.DeleteData();
           // cc.Readdata();

            Console.ReadLine();
        
        }

    }
}
