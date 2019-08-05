using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //method to refresh datagridview after every button click
        private void gridRefresh()
        {
            String str = @"server=DESKTOP-P9O6C2J\SQLEXPRESS01;database=Employee_log;UID=sa;password=password";
            String query = "SELECT * FROM [dbo].[Table];";
            SqlConnection con = new SqlConnection(str);
            SqlCommand com = new SqlCommand(query, con);

            SqlDataReader dbr;
            try
            {
                con.Open();
                dbr = com.ExecuteReader();
                while (dbr.Read()) { }
            } catch (Exception es) { MessageBox.Show(es.Message); }

            this.tableTableAdapter.Fill(this.employee_logDataSet.Table);

            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_logDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.employee_logDataSet.Table);
        }

        //this prompts the database by invoking the INSERT command when the "New" button is clicked.
        private void newButton_Click(object sender, EventArgs e)
        {
            try
            {
                //storing connection details into a string
                String str = @"server=DESKTOP-P9O6C2J\SQLEXPRESS01;database=Employee_log;UID=sa;password=password";
                //storing command into a string
                String query = "INSERT INTO [dbo].[Table] (firstName,lastName,dateOfBirth,addressOne,addressTwo,zipCodeOne,zipCodeTwo,homePhone,email,ssn) VALUES " +
                    "('" + this.firstName.Text + "'," +
                    "'" + this.lastName.Text + "'," +
                    "'" + this.dateOfBirth.Text + "'," +
                    "'" + this.addressOne.Text + "'," +
                    "'" + this.addressTwo.Text + "'," +
                    "'" + this.zipCodeOne.Text + "'," +
                    "'" + this.zipCodeTwo.Text + "'," +
                    "'" + this.phoneNumber.Text + "'," +
                    "'" + this.email.Text + "'," +
                    "'" + this.ssn.Text + "')";

                //list of banned words stored into a string for input validation (protects from sql injection)
                string[] bannedWords = { "Select", "Update", "Insert", "Into", "Create", "Alter", "Drop", "Delete", "Where", "From" };
                //converts input into a string and stores it in input for evaluation
                string input = Convert.ToString(this.firstName + " " + this.lastName.Text + " " + this.dateOfBirth.Text + " " + this.addressOne.Text + " " + this.addressTwo.Text +
                                                " " + this.zipCodeOne.Text + " " + this.zipCodeTwo + " " + this.phoneNumber.Text + " " + this.email.Text + this.ssn.Text);
                
                //takes input variable and used the foreach loop to evaluate if a banned word was used.
                foreach(string word in bannedWords)
                {
                    
                    if (Regex.IsMatch(input, @"\b" + word + @"\b", RegexOptions.IgnoreCase))
                    {
                        throw new ArgumentException("Banned word used in input.", "original");
                        
                    }
                }

                //invoking connection object and passing the string "str" into the object with gives the connection details
                SqlConnection con = new SqlConnection(str);
                //invoking command object and passing both connectinon and command strings into it, so it knows what to place in the query and where to place it to.
                SqlCommand com = new SqlCommand(query, con);

                //reads command
                SqlDataReader dbr;
                
                //opens the connection to the SQL server
                con.Open();

                
                dbr = com.ExecuteReader();
                MessageBox.Show("Saved");

                //executes until command is done
                while (dbr.Read()) { }

                con.Close();

                this.gridRefresh();
            } 
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {

                //storing connection details into a string
                String str = @"server=DESKTOP-P9O6C2J\SQLEXPRESS01;database=Employee_log;UID=sa;password=password";
                //storing command into a string
                String query = "UPDATE [dbo].[Table] SET " +
                    "firstName='" + this.firstName.Text + "'," +
                    "lastName='" + this.lastName.Text + "'," +
                    "dateOfBirth='" + this.dateOfBirth.Text + "'," +
                    "addressOne='" + this.addressOne.Text + "'," +
                    "addressTwo='" + this.addressTwo.Text + "'," +
                    "zipCodeOne='" + this.zipCodeOne.Text + "'," +
                    "zipCodeTwo='" + this.zipCodeTwo.Text + "'," +
                    "homePhone='" + this.phoneNumber.Text + "'," +
                    "email='" + this.email.Text + "'," +
                    "ssn='" + this.ssn.Text + "' WHERE firstName='" + this.firstName.Text + "' AND lastName='" + this.lastName.Text + "'";


                //list of banned words stored into a string for input validation (protects from sql injection)
                string[] bannedWords = { "Select", "Update", "Insert", "Into", "Create", "Alter", "Drop", "Delete", "Where", "From" };
                //converts input into a string and stores it in input for evaluation
                string input = Convert.ToString(this.firstName + " " + this.lastName.Text + " " + this.dateOfBirth.Text + " " + this.addressOne.Text + " " + this.addressTwo.Text +
                                                " " + this.zipCodeOne.Text + " " + this.zipCodeTwo + " " + this.phoneNumber.Text + " " + this.email.Text + this.ssn.Text);

                //takes input variable and used the foreach loop to evaluate if a banned word was used.
                foreach (string word in bannedWords)
                {

                    if (Regex.IsMatch(input, @"\b" + word + @"\b", RegexOptions.IgnoreCase))
                    {
                        throw new ArgumentException("Banned word used in input.", "original");

                    }
                }

                //invoking connection object and passing the string "str" into the object with gives the connection details
                SqlConnection con = new SqlConnection(str);
                //invoking command object and passing both connectinon and command strings into it, so it knows what to place in the query and where to place it to.
                SqlCommand com = new SqlCommand(query, con);

                //reads command
                SqlDataReader dbr;
                
                //opens the connection
                con.Open();

                
                dbr = com.ExecuteReader();
                MessageBox.Show("Updated");
                while (dbr.Read()) { }

                

                con.Close();
                this.gridRefresh();
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);

            }
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            //This is getting changed, as opposed to letting them enter something to delete make them click on row to delete
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to delete this employee?", "Wait!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)  
            {
                try
                {
                    //storing connection details into a string
                    String str = @"server=DESKTOP-P9O6C2J\SQLEXPRESS01;database=Employee_log;UID=sa;password=password";
                    //storing command into a string
                    String query = "DELETE FROM [dbo].[Table] WHERE firstName='" + this.firstName.Text + "' AND lastName='" + this.lastName.Text + "'";
                    
                    //list of banned words stored into a string for input validation (protects from sql injection)
                    string[] bannedWords = { "Select", "Update", "Insert", "Into", "Create", "Alter", "Drop", "Delete", "Where", "From" };
                    //converts input into a string and stores it in input for evaluation
                    string input = Convert.ToString(this.firstName + " " + this.lastName.Text + " " + this.dateOfBirth.Text + " " + this.addressOne.Text + " " + this.addressTwo.Text +
                                                    " " + this.zipCodeOne.Text + " " + this.zipCodeTwo + " " + this.phoneNumber.Text + " " + this.email.Text + this.ssn.Text);

                    //takes input variable and used the foreach loop to evaluate if a banned word was used.
                    foreach (string word in bannedWords)
                    {

                        if (Regex.IsMatch(input, @"\b" + word + @"\b", RegexOptions.IgnoreCase))
                        {
                            throw new ArgumentException("Banned word used in input.", "original");

                        }
                    }
                    
                    //invoking connection object and passing the string "str" into the object with gives the connection details
                    SqlConnection con = new SqlConnection(str);
                    //invoking command object and passing both connectinon and command strings into it, so it knows what to place in the query and where to place it to.
                    SqlCommand com = new SqlCommand(query, con);

                    SqlDataReader dbr;
                    
                    con.Open();
                    dbr = com.ExecuteReader();
                    while (dbr.Read()) { }
                    con.Close();
                }

                catch(Exception es)
                {
                    MessageBox.Show(es.Message);
                }
                MessageBox.Show("Deletion Successful");
            }

            else
            {
                MessageBox.Show("Deletion Aborted");
            }

            this.gridRefresh();
        }
    }
}