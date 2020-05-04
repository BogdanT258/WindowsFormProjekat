using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatOOP
{
    public partial class information : Form
    {
        public information()
        {
            InitializeComponent();
            age.Controls.RemoveAt(0);
            komp.Text = Informacije._kompanija;
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
        }

        private void F1button_Click(object sender, EventArgs e)
        {
            Informacije i1 = new Informacije();           
            i1.Age = Decimal.ToInt32(age.Value);
            i1.FirstName = fname.Text;
            i1.LastName = lname.Text;
            i1.Pozicija = pozBox.Text;
            if (i1.Age == 0 || i1.FirstName == "" || i1.LastName == "" || i1.Pozicija == "")
            {
                MessageBox.Show("Some of input fields are either empty or not correct. Please input your information again!");
            }else
            {
                if (i1.Pozicija == "junior")
                {
                    this.Hide();
                    Junior p1 = new Junior(i1.FirstName, i1.LastName, i1.Age.ToString(),i1.Pozicija);
                    p1.Closed += (s, args) => this.Close();
                    p1.Show();
                }
                else
                    if (i1.Pozicija == "medior")
                {
                    this.Hide();
                    Medior p1 = new Medior(i1.FirstName, i1.LastName, i1.Age.ToString(), i1.Pozicija);
                    p1.Closed += (s, args) => this.Close();
                    p1.Show();
                }
                else
                    if (i1.Pozicija == "senior")
                    {
                    this.Hide();
                    Senior p1 = new Senior(i1.FirstName, i1.LastName, i1.Age.ToString(), i1.Pozicija);
                    p1.Closed += (s, args) => this.Close();
                    p1.Show();
                }
            }                                    
        }        
    }
}
