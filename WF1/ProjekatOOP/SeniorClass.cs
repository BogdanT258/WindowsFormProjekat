using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatOOP
{
    class SeniorClass : Informacije,ISenior
    {
        private int salary = 1100;        
        private string corpRank;
        private int annualLeave = 20;

        public SeniorClass(string ime, string prezime, string poz) : base(ime, prezime, poz)
        {

        }
        public string CorporationRank
        {
            get { return corpRank; }
            set
            {                
                if (value == "Software Engineer" || value == "Quality Analysts" || value == "Project Managers" || value == "Project Head")
                {
                    corpRank = value;
                }
                else
                {
                    MessageBox.Show("You didnt choose your Corporation rank!");
                }
                   
            }
        }        
        public void PovecanjePlate(int projekti,int extrahours)
        {           
            if (projekti == 1 &&  extrahours <= 15)
            {
                salary += 300;
                MessageBox.Show("Your salary has been increased by 300$");
            }
            else
                if (projekti == 1 && extrahours <= 25)
            {
                salary += 450;
                MessageBox.Show("Your salary has been increased by 450$");
            }
            else
                if (projekti == 2 && extrahours <= 15)
            {
                salary += 350;
                MessageBox.Show("Your salary has been increased by 350$");
            }
            else
                if (projekti == 2 && extrahours <= 25)
            {
                salary += 550;
                MessageBox.Show("Your salary has been increased by 550$");
            }
            else
                if (projekti == 3 && extrahours <= 15 || projekti == 3 && extrahours <= 24)
            {
                salary += 450;
                MessageBox.Show("Your salary has been increased by 450$");
            }
            else
                if (projekti == 3 && extrahours >= 25)
            {
                salary += 650;
                MessageBox.Show("Your salary has been increased by 650$");
            }
            else
                if (projekti == 4 && extrahours >= 25)
            {
                salary += 850;
                annualLeave += 5;
                MessageBox.Show("Your salary has been increased by 700$ and you got 5 extra annual leaves!");
            }
            else
                MessageBox.Show("Sorry you do not meet requeriments for salary promotion.") ;
        }
        public void PrintInformation()
        {
            MessageBox.Show(String.Format("INFORMATION  :  |First name : {0} || Last name : {1} || Rank : {2}/{3} || Salary : {4}|| Annual Leave (Days) : {5}", _firstName, _lastName, _pozicija, corpRank, salary, annualLeave));
        }
        public void Promocija(int projekti)
        {
            if (projekti >= 3)
            {
                if (corpRank == "Software Engineer")
                {
                    corpRank = "Quality Analyst";
                    MessageBox.Show("You got promoted to Quality Analyst");
                }
                else
                    if (corpRank == "Quality Analysts")
                {
                    corpRank = "Project Manager";
                    MessageBox.Show("You got promoted to Project Manager");
                }
                else
                    if (corpRank == "Project Managers")
                {
                    corpRank = "Project Head";
                    MessageBox.Show("You got promoted to Project Head");
                }
                else
                    if (corpRank == "Project Head")
                {
                    MessageBox.Show("You have already reached max corporate rank.");
                }
            }
            else
            {
                MessageBox.Show("Sorry you do not meet requeriments for rank promotion.");
            }
        }
        public static class Questions
        {
            public static string Question1()
            {
                return "How many projects have you been part of in this year?";
            }
            public static string Question2()
            {
                return "How many extra hours have you worked this month?";
            }
        }
    }
}
