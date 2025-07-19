using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines_Reservation
{
    internal class Database
    {
        string myfile = @"Tickets.txt";
        public void addToDataBase(Ticket ticket)
        {
            //StreamWriter sw = new StreamWriter("Tickets.txt", true);


            using (StreamWriter sw = File.AppendText(myfile)) //pollymorphism
            {
                sw.WriteLine(ticket.Name);
                sw.WriteLine(ticket.id);
                sw.WriteLine(ticket.getType());
                sw.WriteLine(ticket.PhoneNumber);
                sw.WriteLine(ticket.CompanyName);
                sw.WriteLine(ticket.departial);
                sw.WriteLine(ticket.destination);
                sw.WriteLine(ticket.date.ToString());
                sw.WriteLine("______________________________");
                sw.Close();
            }
        }
    }
}
