using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace LinqEx1
{
    class ClassInfo {
        private string id;
        private string name;

        public ClassInfo(string i, string c) {
            id = i; name = c;
        }

        public string ID { get { return id; } }
        public string Name { get { return name; } }

        public override string ToString()
        {
            return string.Format("{0}: '{1}'", id, name);
        }
    }

    class StudentInfo
    {
        private int id;
        private string name;

        public StudentInfo(int i, string n)
        {
            id = i; name = n;
        }

        public int ID { get { return id; } }
        public string Name { get { return name; } }

        public override string ToString()
        {
            return string.Format("{0}: '{1}'", id, name);
        }
    }

    class ClassRoster
    {
        private string idClass;
        private int idStudent;

        public ClassRoster(string idc, int ids)
        {
            idClass = idc;
            idStudent = ids;
        }

        public int StudentID
        { get { return idStudent; } }

        public string ClassID
        { get { return idClass; } }
    }

    [Table]
    class Customers
    {
        [Column(Name = "ID")]
        public int ID;
        [Column(Name = "Company")]
        public string Company;
        [Column(Name = "Last Name")]
        public string LastName;
        [Column(Name = "First Name")]
        public string FirstName;
        [Column(Name = "E-mail Address")]
        public string Email;
        [Column(Name = "Job Title")]
        public string JobTitle;
        [Column(Name = "Business Phone")]
        public string BusinessPhone;
        [Column(Name = "Home Phone")]
        public string HomePhone;
        [Column(Name = "Mobile Phone")]
        public string MobilePhone;
        [Column(Name = "Fax Number")]
        public string FaxNumber;
        [Column(Name = "Address")]
        public string Address;
        [Column(Name = "City")]
        public string City;
        [Column(Name = "State/Province")]
        public string State;
        [Column(Name = "ZIP/Postal Code")]
        public string Zip;
        [Column(Name = "Country/Region")]
        public string Country;
        [Column(Name = "Web Page")]
        public string WebPage;
        [Column(Name = "Notes")]
        public string Notes;
        [Column(Name = "Attachments")]
        public string Attachments;
        [Column(Name = "upsize_ts")]
        public DateTime UpsizeTS;
    }

    [Table]
    class Employees
    {
        [Column(Name = "ID")]
        public int ID;
        [Column(Name = "Company")]
        public string Company;
        [Column(Name = "Last Name")]
        public string LastName;
        [Column(Name = "First Name")]
        public string FirstName;
        [Column(Name = "E-mail Address")]
        public string Email;
        [Column(Name = "Job Title")]
        public string JobTitle;
        [Column(Name = "Business Phone")]
        public string BusinessPhone;
        [Column(Name = "Home Phone")]
        public string HomePhone;
        [Column(Name = "Mobile Phone")]
        public string MobilePhone;
        [Column(Name = "Fax Number")]
        public string FaxNumber;
        [Column(Name = "Address")]
        public string Address;
        [Column(Name = "City")]
        public string City;
        [Column(Name = "State/Province")]
        public string State;
        [Column(Name = "ZIP/Postal Code")]
        public string Zip;
        [Column(Name = "Country/Region")]
        public string Country;
        [Column(Name = "Web Page")]
        public string WebPage;
        [Column(Name = "Notes")]
        public string Notes;
        [Column(Name = "Attachments")]
        public string Attachments;
        [Column(Name = "upsize_ts")]
        public DateTime UpsizeTS;
    }

    [Table]
    class Orders
    {
        [Column (Name="ID")]
        public int ID;
        [Column(Name = "Employee ID")]
        public int EmployeeID;
        [Column(Name = "Customer ID")]
        public int CustomerID;
        [Column(Name = "Order Date")]
        public DateTime OrderDate;
        [Column(Name = "Shipped Date")]
        public DateTime ShippedDate;
        [Column(Name = "Shipper ID")]
        public int ShipperID;
        [Column(Name = "Ship Name")]
        public string ShipName;
        [Column(Name = "Ship Address")]
        public string ShipAddress;
        [Column(Name = "Ship City")]
        public string ShipCity;
        [Column(Name = "Ship State/Province")]
        public string ShipState;
        [Column(Name = "Ship Zip/Postal Code")]
        public string ShipZip;
        [Column(Name = "Ship Country/Region")]
        public string ShipCountry;
        [Column(Name = "Shipping Fee")]
        public Decimal ShippingFee;
        [Column(Name = "Taxes")]
        public Decimal Taxes;
        [Column(Name = "Payment Type")]
        public string PaymentType;
        [Column(Name = "Paid Date")]
        public DateTime PaidDate;
        [Column(Name = "Notes")]
        public string Notes;
        [Column(Name = "Tax Rate")]
        public float TaxRate;
        [Column(Name = "Tax Status")]
        public int TaxStatus;
        [Column(Name = "Status ID")]
        public int StatusID;
        [Column(Name = "upsize_ts")]
        public DateTime UpsizeTS;
    }

    [Table]
    class Products
    {
        [Column(Name = "Supplier IDs")]
        public int SuppID;
        [Column(Name = "ID")]
        public int ProdID;
        [Column(Name = "Product Code")]
        public string ProdCode;
        [Column(Name = "Product Name")]
        public string ProdName;
        [Column(Name = "Description")]
        public string Description;
        [Column(Name = "Standard Cost")]
        public int StandardCost;
        [Column(Name = "List Price")]
        public int ListPrice;
        [Column(Name = "Reorder Level")]
        public int ReoLevel;
        [Column(Name = "Target Level")]
        public int TargetLevel;
        [Column(Name = "Quantity Per Unit")]
        public string Quantity;
        [Column(Name = "Discontinued")]
        public bool Discontinued;
        [Column(Name = "Minimum Reorder Quanitity")]
        public int MinReorder;
        [Column(Name = "Category")]
        public string Category;
    }
      
    class NWindDatabase : DataContext
    {
        public Table<Customers> Customers;
        public Table<Employees> Employees;
        public Table<Orders> Orders;
        //public Table<Products> Products;

        public NWindDatabase() : base(@"Data Source=CS1;Initial Catalog=Northwind;Integrated Security=True")  { }
    }

    class Program
    {
        static void QueryOnStrings()
        {
            Random rnd = new Random();
            ClassInfo[] classlist = {new ClassInfo("CS171", "Computer Science I"),
                                     new ClassInfo("CS172", "Computer Science II"),
                                     new ClassInfo("CS273", "Data Structures"),
                                     new ClassInfo("CS278", "Comp Organiztn & Assemblr Prog"),
                                     new ClassInfo("CS313", "Networks"), 
                                     new ClassInfo("CS370", "Programming Languages"),
                                     new ClassInfo("CS374", "Database Management"),
                                     new ClassInfo("CS473", "Adv Algorithm Design & Analy"),
                                     new ClassInfo("CS499", "Research Methods")
                                    };
            StudentInfo[] students = {
                                         new StudentInfo(11111, "Kyle Edwards"),
                                         new StudentInfo(22222, "Mark Martin"),
                                         new StudentInfo(33333, "Jeff Gordon"),
                                         new StudentInfo(44444, "Juan Montoya"),
                                         new StudentInfo(55555, "Dale Earnhardt"),
                                         new StudentInfo(66666, "Tony Stewart"),
                                         new StudentInfo(77777, "Jimmie Johnson"),
                                     };

            List<ClassRoster> liRosters = new List<ClassRoster>();
            foreach (ClassInfo c in classlist)
            {
                for (int i = 0; i < 3; i++)
                {
                    liRosters.Add(new ClassRoster(c.ID, students[rnd.Next()%students.Length].ID));
                }
            }

            IEnumerable<ClassInfo> res = from ci in classlist
                                         where ci.ID.Substring(0, 3) == "CS3"
                                         orderby ci.ID
                                         select ci;
            foreach (ClassInfo ci in res)
                Console.WriteLine(ci);

            var rosters = from ci in classlist
                          from ros in liRosters
                          from stud in students
                          where ci.ID == ros.ClassID && ros.StudentID == stud.ID
                          orderby ci.ID
                          select new { StudentName = stud.Name, ClassName = ci.Name };
            foreach (var r in rosters)
                Console.WriteLine("{0} is taking {1}", r.StudentName, r.ClassName);
        }

        static void QueryOnNwind(int maxPrice)
        {
            NWindDatabase nwnddb = new NWindDatabase();

            var ordsCheap = from cust in nwnddb.Customers
                             from emp in nwnddb.Employees
                             from ord in nwnddb.Orders
                             where cust.ID==ord.CustomerID && emp.ID==ord.EmployeeID && ord.ShippingFee > new Decimal(maxPrice)
                             orderby ord.ShippingFee
                             select new { ELastName = emp.LastName, CLastName = cust.LastName };

            foreach (var o in ordsCheap)
                Console.WriteLine("{0} ordered from ${1}", o.CLastName, o.ELastName);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Fun with LINQ...");
            QueryOnNwind(20);
            Console.ReadLine();
        }
    }
}
