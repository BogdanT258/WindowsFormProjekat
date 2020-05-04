using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjekatOOP
{
    public class Informacije
    {
        protected string _firstName;
        protected string _lastName;
        protected string _pozicija;
        protected int _age;        
        public static readonly string _kompanija = "T Corporation";        
        
        public Informacije()
        {
            _firstName = "";
            _lastName = "";
            _pozicija = "";
            _age = 0;
        }
        public Informacije(string ime,string prezime,string poz)
        {
            _firstName = ime;
            _lastName = prezime;
            _pozicija = poz;
        }             
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length<2)
                {
                    MessageBox.Show("Please enter your first name!");
                }
                else
                    _firstName = value;
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    MessageBox.Show("Please enter your last name!");
                }
                else
                    _lastName = value;
            }
        }
        public string Pozicija
        {
            get { return _pozicija; }
            set
            {               
                var logFile = File.ReadAllLines(@"C:\Users\Bogisa\Desktop\C# 2020\WF\Pozicije.txt");
                var logList = new List<string>(logFile);                
                for (int i = 0; i < 3; i++)
                {
                     if (logList[i] == value)
                     {
                          _pozicija = value;
                     }
                }
                
                                             
            }
        }        
        public int Age
        {
            get { return _age; }
            set
            {                
                    if (value < 18)
                    {
                        MessageBox.Show("You have to be at least 18 to apply for this job!");
                    }
                    else
                        if (value > 59)
                    {
                        MessageBox.Show("We are sorry to inform you but we are only accepting people that are less then 60 years old.");
                    }
                    else
                        _age = value;               
            }
        }       
    }
}
