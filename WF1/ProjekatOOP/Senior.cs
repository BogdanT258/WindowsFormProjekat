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
    public partial class Senior : Form
    {        
        private static string[] ranks = new string[] { "Software Engineer", "Quality Analysts", "Project Managers", "Project Head" };
        public Senior(string name, string surname, string age, string pozicija)
        {
            InitializeComponent();
            fname.Text = name;
            lname.Text = surname;
            ageinfo.Text = age;
            ranklabel.Text = pozicija;           
            comboBox1.DataSource = ranks;
            label2.Text = SeniorClass.Questions.Question1();
            label3.Text = SeniorClass.Questions.Question2();
        }

        private void Senior_Load(object sender, EventArgs e)
        {
        }       
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }

        private void Button1_Click(object sender, EventArgs e)
        {           
            int projekti = 0;
            if (pr1.Checked)
            {
                projekti++;
            }
            if (pr2.Checked)
            {
                projekti++;
            }
            if (pr3.Checked)
            {
                projekti++;
            }
            if (pr4.Checked)
            {
                projekti++;
            }
            SeniorClass s1 = new SeniorClass(fname.Text, lname.Text, ranklabel.Text);
            s1.CorporationRank = comboBox1.SelectedItem.ToString();
            s1.Promocija(projekti);
            s1.PrintInformation();
        }

        private void Spromo_Click(object sender, EventArgs e)
        {
            int projekti = 0;
            if (pr1.Checked)
            {
                projekti++;
            }
            if (pr2.Checked)
            {
                projekti++;
            }
            if (pr3.Checked)
            {
                projekti++;
            }
            if (pr4.Checked)
            {
                projekti++;
            }
            MessageBox.Show("projekti:"+projekti);
            SeniorClass s1 = new SeniorClass(fname.Text, lname.Text, ranklabel.Text);
            s1.CorporationRank = comboBox1.SelectedItem.ToString();
            s1.PovecanjePlate(projekti, Convert.ToInt32(extrahours.Value));
            s1.PrintInformation();
        }
    }   
}
