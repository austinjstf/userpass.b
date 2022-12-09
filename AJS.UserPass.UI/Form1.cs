namespace AJS.UserPass.UI;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void InsertIntoDataBase()
    {
        var dbCon = dbConnection.Instance();
        dbCon.Server = "127.0.0.1";
        dbCon.DatabaseName = "login";
        dbCon.UserName = "root";
        dbCon.Password = "Asteffes2004";
        if (dbCon.IsConnect())
        {
            Console.WriteLine("Holy shit it worked");
            //suppose col0 and col1 are defined as VARCHAR in the DB
            //string query = "CREATE TABLE test(testID INT NOT NULL)";
            //string query = "INSERT INTO test VALUES (1)";
            string query = "SELECT * FROM login";
            //string query = "SELECT User,Pass FROM UserPassTable";
            var cmd = new MySqlCommand(query, dbCon.Connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string someStringFromColumnZero = reader.GetString(0);
                string someStringFromColumnOne = reader.GetString(1);
                Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
            }
            dbCon.Close();
        }
    }

    public void CreatePerson(string Username, string Password, string Email)
    {


        try
        {
            //This is my connection string i have assigned the database file address path
            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=Asteffes2004";
            //This is my insert query in which i am taking input from the user through windows forms
            string Query = "insert into login.login(Usern,Passw,Email) values('" + Username + "','" + Password + "','" + Email + "');";
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            MessageBox.Show("Successfully created an account!");
            while (MyReader2.Read())
            {
            }
            MyConn2.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
        String Username = txtCreateUser.Text;
        String Password = txtCreatePass.Text;
        String Email = txtCreateEmail.Text;

        if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Email))
        {
            MessageBox.Show("Make sure all fields are filled in correctly");
        }
        else if (!Email.Contains("@"))
        { 
            MessageBox.Show("Email Error Include @ Symbol");
        }
        else
        CreatePerson(Username, Password, Email);
        txtCreateUser.Text = "";
        txtCreatePass.Text = "";
        txtCreateEmail.Text = "";


    }

    private void btnCloseApp_Click(object sender, EventArgs e)
    {
        Close();
    }


    private void btnLogin_Click(object sender, EventArgs e)
    {
        Form2 form2 = new Form2();
        form2.ShowDialog();
    }



    private void btnGeneratePass_Click(object sender, EventArgs e)
    {
        
        
    }
}