using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace user_authentication
{
    class Program
    {
        public static int a = 0;
        public static string username;
        public static string password;
        static void Main(string[] args)
        {
            user u = new user();
            Console.WriteLine("Press '1' for Register page"+"\n"+"Press '2' for Login page");
             a = int.Parse(Console.ReadLine());
             if (a == 1)
             {
                 Console.WriteLine("Enter your name :");
                 u.Name = Console.ReadLine();
                 Console.WriteLine("Your age :");
                 u.Age = int.Parse(Console.ReadLine());
                 Console.WriteLine("DOB: (DD-MM-YYYY)");
                 u.Dob = DateTime.Parse(Console.ReadLine());
                 Console.WriteLine("Username :");
                 u.Username = Console.ReadLine();
                 Console.WriteLine("Password :");
                 u.Password = Console.ReadLine();
                 Console.WriteLine("Email address :");
                 u.Emailadd = Console.ReadLine();
                 string name = u.Name;
                 int age = u.Age;
                 DateTime dob = u.Dob;
                 username = u.Username;
                 password = u.Password;
                 string email = u.Emailadd;
                 Console.WriteLine(u.ToString());
                 SqlConnection con = new SqlConnection();
                 con.ConnectionString = "SERVER=DESKTOP-3MUST40\\SQLEXPRESS;database=userauthentication;integrated security=true;";
                 con.Open();
                 SqlCommand comm = new SqlCommand();
                 comm.Connection = con;
                 //comm.CommandText = "insert into register values('" + username + "','" + password + "')";
                 //comm.ExecuteNonQuery();
                 comm.CommandText = "insert into Regdb values('" + name + "','" + age + "','" + dob + "','" + username + "','" + password + "','" + email + "')";
                 comm.ExecuteNonQuery();
                 Console.WriteLine("Registered successfully");
              
               
             }
            if (a == 2)
            {
                Console.WriteLine("Username: ");
                string Username = Console.ReadLine();
                Console.WriteLine("Password");
                string Password = Console.ReadLine();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "SERVER=DESKTOP-3MUST40\\SQLEXPRESS;database=userauthentication;integrated security=true;";
                con.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandText = "select passcode from Regdb where username='" + Username + "'";
                string dbpasscode = (string)comm.ExecuteScalar();
                if (dbpasscode == Password)
                {
                    Console.WriteLine("Login successfull");
                }
                else
                {
                    Console.WriteLine("Incorrect Username or password");
                }


            }
            //passcodeconvertor("Logesh");
            //var today = DateTime.Today;
            //var age = today.Year - cal.Year;
            //Console.WriteLine(age);
            //DateTime dob = new DateTime(2002,08,02);
            //TimeSpan ans = DateTime.Now - dob;
            //Console.WriteLine(ans.Days);
            

        }
      
     
        
    }
}
