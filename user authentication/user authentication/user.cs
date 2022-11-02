using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace user_authentication
{
  public class user
    {
        string _name;
        int _age;
        DateTime _dob;
        string _username;
        string _password;
        string _emailadd;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    

        public string Emailadd
        {
            get { return _emailadd; }
            set { _emailadd = value; }
        }


        public string Username
        {
            get { return _username; }
            set {
                int n = value.Length;
                if (n < 5 || n > 15)
                {
                    throw new Exception("Name max'15' and min '5'");
                }
                else if (n >= 5 && n <= 15)
                {
                   
                    _name = value;
                } _username = value;
            }
        }
        public DateTime Dob
        {
            get { return _dob; }
            set {
                 
                _dob = value; }
        }
        public  string Name
        {

            get {return _name; }
            set
            {
                  
                    int n = value.Length;
                    if (n < 3 || n > 15)
                    {
                        throw new Exception("Name max'15' and min '3'");
                    }
                    else if(n>=3&&n<=15)
                    {
                        _name = value;
                    }
                   
            }
             
        }
     

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                if (value >= 18 && value <= 60)
                {
 
                }
                else
                {
                    throw new Exception("Age should above '18' and below '60'");
                }
            }
        }

        public static void passcodeconvertor(string password)
        {
            var data = Encoding.ASCII.GetBytes(password);
            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(data);

            Console.WriteLine(sha1data);
        }
        public override string ToString()
        {
            return "Name: " + Name + "\n" + "Age: " + Age + "\n" + "DOB: " + Dob + "\n" + "Username: " + Username + "\n" + "password: " + Password + "\n" + "Emailaddress: " + Emailadd;
        }
    }


}

