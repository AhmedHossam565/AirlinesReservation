using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines_Reservation
{
    internal class Economy:Ticket
    {
        private string x = "Economy";
        
        public Economy(string name, string phoneNumber, string type, string companyName, string departial, string destination,DateTime date,string id) : base(name, phoneNumber, companyName, departial, destination,date,id)
        {
            
        }
     
        public override string getType()
        {
            return x;
        }
        
    }
}
