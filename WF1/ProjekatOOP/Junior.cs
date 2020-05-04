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
    public partial class Junior : Form
    {     
        public Junior(string name,string surname,string age,string pozicija)
        {
            InitializeComponent();            
            fname.Text = name;
            lname.Text = surname;
            ageinfo.Text = age;
            ranklabel.Text = pozicija;
        }

        private void Junior_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            JuniorClass j1 = new JuniorClass(Convert.ToInt32(workexp.Value), Convert.ToInt32(radufirmi.Value),fname.Text,lname.Text,ranklabel.Text);
            j1.Promocija();
            if (j1.Prom == true)
            {
                j1.Ispis();
                MonthWorker d1 = new MonthWorker();
                j1.WorkerOfMonth = d1.Worker(j1);
                j1.Congratulations();
            }                                    
        }
    }
}
