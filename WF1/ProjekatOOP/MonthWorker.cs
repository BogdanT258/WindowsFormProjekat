using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatOOP
{
    public class MonthWorker
    {               
        public int currentWorkerOfMonth = 2;       
            
        public bool Worker(JuniorClass obj)
        {
            bool a = false;
            if (obj.Prom == true)
            {
                if (obj.RadUFirmi>currentWorkerOfMonth)
                {
                    MessageBox.Show("Promocija!");
                    a = true;
                    currentWorkerOfMonth = obj.RadUFirmi;
                }
            }
            return a;
        }
        public bool Worker(MediorClass obj)
        {
            bool a = false;
            if (obj.Prom == true)
            {
                if (obj.RadUFirmi > currentWorkerOfMonth)
                {
                    MessageBox.Show("Promocija!");
                    a = true;
                    currentWorkerOfMonth = obj.RadUFirmi;
                }
            }
            return a;
        }
    }
}
