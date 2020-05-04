using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatOOP
{
    interface IRank
    {
        void Promocija();
        void Ispis();
    }
    interface ISenior
    {
        void PovecanjePlate(int projekti,int extrahours);
        void Promocija(int projekti);
    }
}
