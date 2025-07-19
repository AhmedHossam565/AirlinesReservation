using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airlines_Reservation
{
    public partial class Summary : Form
    {
        public Summary(string name,string phoneNumber ,string companyName, string type, string departial,string destination, DateTime date)
        {
            InitializeComponent();
            nameField.Text = name;
            noField.Text=phoneNumber;
            compField.Text = companyName;
            typeField.Text = type;
            depField.Text=departial;
            destField.Text=destination;
            dateField.Text=date.ToString("MMMM dd, yyyy");
            if (typeField.Text.Equals("Economy"))
            {
                priceField.Text="3500";

            }
            else if (typeField.Text=="Business")
            {
                priceField.Text="4500";

            }
            else if (typeField.Text=="First Class")
            {
                priceField.Text="5500";

            }
            IdField.Text=Ticket.generateID();



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceField_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void IdField_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Last x = new Last(nameField.Text, noField.Text,priceField.Text,IdField.Text, typeField.Text, compField.Text, depField.Text, destField.Text, dateField.Text);
            x.Visible = true;
            this.Visible = false;
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Book x = new Book();
            this.Visible = false;
            x.Visible=true;
            
        }

        private void dateField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
