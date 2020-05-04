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
    public partial class Medior : Form
    {
        public Medior(string name, string surname, string age, string pozicija)
        {
            InitializeComponent();
            fname.Text = name;
            lname.Text = surname;
            ageinfo.Text = age;
            ranklabel.Text = pozicija;
        }
        private void Medior_Load(object sender, EventArgs e)
        {
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            MediorClass m1 = new MediorClass(Convert.ToInt32(workexp.Value), Convert.ToInt32(radufirmi.Value), fname.Text, lname.Text, ranklabel.Text);
            m1.Promocija();
            if (m1.Prom == true)
            {
                m1.Ispis();
                MonthWorker d1 = new MonthWorker();
                m1.WorkerOfMonth = d1.Worker(m1);
                m1.Congratulations();
            }
        }
    }
}
