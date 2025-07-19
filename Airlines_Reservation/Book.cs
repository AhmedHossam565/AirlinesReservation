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
    public partial class Book : Form
    {
        
        
        public Book()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string dep = depField.Text;
            string dest = destField.Text;
            Ticket ticket=null;
            

            
            if (nameField.Text.Equals("") || noField.Text.Equals("") || typeField.Text.Equals("") || compField.SelectedItem.Equals("") || depField.SelectedItem.Equals("") || destField.SelectedItem.Equals(""))
            {
                MessageBox.Show("enter valid credentials.");
                
            }



            if (noField.Text.Length==noField.MaxLength && dep!=dest)
            {
                string id = Ticket.generateID();
                if (typeField.Text.Equals("Economy"))
                {
                    ticket= new Economy(nameField.Text, noField.Text, typeField.Text, compField.Text, depField.Text, destField.Text, dateField.Value,id);
                }

                if (typeField.Text.Equals("Business"))
                {
                    ticket= new Business(nameField.Text, noField.Text, typeField.Text, compField.Text, depField.Text, destField.Text,dateField.Value,id);
                }
                if (typeField.Text.Equals("First Class"))
                {
                    ticket= new FirstClass(nameField.Text, noField.Text, typeField.Text, compField.Text, depField.Text, destField.Text,dateField.Value,id);
                }
                
                Database database = new Database();
                database.addToDataBase(ticket);
                Summary x = new Summary(nameField.Text, noField.Text, compField.Text, typeField.Text, depField.Text, destField.Text,dateField.Value);
                x.Visible = true;
                this.Visible = false;               
            }
            
            if(noField.Text.Length<noField.MaxLength)
            {
                MessageBox.Show("put valid phone number.");
                
            }
            if(dep.Equals(dest))
            {
                MessageBox.Show("change Departial/Destination");

                destField.SelectedIndex = -1;
                depField.SelectedIndex = -1;


            }








        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            noField.MaxLength = 11;
           

            Int64 a;
            if (!Int64.TryParse(noField.Text, out a))
            {
                // If not int clear textbox text 

                noField.Clear();
            }
            
           
           
           foreach (char x in noField.Text )
            {
                if(!char.IsDigit(x))
                {

                    MessageBox.Show("Put a valid Phone Number !");

                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in nameField.Text)
            {// check for char only
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {

                    MessageBox.Show("Your name must contain letters only");
                    nameField.ResetText();

                }
            }
        }

        private void Book_Load(object sender, EventArgs e)
        {

        }

        private void destField_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
