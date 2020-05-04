using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatOOP
{
    public class MediorClass : Informacije,IRank
    {
        private int godIskustva { get; set; }
        private int _radUFirmi; 
        private int _plata = 800;
        private bool prom = false;
        private bool _workerOfMonth = false;
       
        public MediorClass(int godisk, int rad, string ime, string prezime, string poz) : base(ime, prezime, poz)
        {
            this.godIskustva = godisk;
            this._radUFirmi = rad;
        }
        public bool WorkerOfMonth
        {
            get { return _workerOfMonth; }
            set
            {
                _workerOfMonth = value;
            }
        }
        public int RadUFirmi
        {
            get { return _radUFirmi; }
            set
            {
                if (value < 1)
                {
                    MessageBox.Show("Incorrect input!");
                }
                else
                {
                    _radUFirmi = value;
                }
            }
        }
        public bool Prom
        {
            get { return prom; }
        }
        public void Promocija()
        {
            if (godIskustva > 4 && _radUFirmi >= 2)
            {
                _pozicija = "senior";
                _plata += 300;
                prom = true;
            }
            else
                MessageBox.Show("Sorry you do not meet requirements for promotion.");
        }
        public void Ispis()
        {
            MessageBox.Show(String.Format("INFORMATION  :  |First name : {0} || Last name : {1} || Rank : {2} || Salary : {3}|", _firstName, _lastName, _pozicija, _plata));
        }
        public void Congratulations()
        {
            if (_workerOfMonth == true)
            {
                MessageBox.Show("Congratilations you are the best growing individual this month!" + MessageBoxButtons.OK);
            }
        }
    }
}
