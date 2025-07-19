using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines_Reservation
{
    internal abstract class Ticket
    {
        private string name; 
        private string phoneNumber;
        public string id;
        private int price;
        private string companyName;
        public string departial;
        public string destination;
        public DateTime date;
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
       
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
            }
        }
       
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
        public string CompanyName
        {
            get { return companyName; }
            set
            {
                companyName = value;
            }

        }
        public Ticket(string name, string phoneNumber, string companyName, string departial, string destination, DateTime date,string id)
        {
            this.name = name;


            this.phoneNumber=phoneNumber;
            this.id = id;
            this.companyName=companyName;
            this.departial=departial;
            this.destination=destination;
            this.date=date;
        }
        public static string generateID()
        {
            StringBuilder builder = new StringBuilder();
            Enumerable
               .Range(65, 26)
                .Select(e => ((char)e).ToString())
                .Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
                .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
                .OrderBy(e => Guid.NewGuid())
                .Take(11)
                .ToList().ForEach(e => builder.Append(e));
            return builder.ToString();
        }
        public static string getGate()
        {
            Random rnd = new Random();
            string[] z = { "A1", "A2", "B1", "B2", "C1", "C2" };
            return z[rnd.Next(0,5)];



        }
        public abstract string getType();
        

    }
   
}
