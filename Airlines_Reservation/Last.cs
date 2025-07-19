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
    public partial class Last : Form
    {
        public Last(string name,string phoneNumber,string price,string ID,string type,string company,string departial,string destination , string date)
        {
            InitializeComponent();
            gateField.Text=Ticket.getGate();
            nameField.Text = name; 
            typeField.Text = type;
            depField.Text=departial;
            destField.Text=destination;
            dateField.Text=date;
            IdField.Text=ID;
        }

        private void Last_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TY x = new TY();
            x.Visible = true;
            this.Visible = false;
        }

        private void typeField_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
