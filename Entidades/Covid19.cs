using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Covid19 : Microrganismo
    {
        public override long IndiceDeContagios
        {
            get { return base.contador * 5; }
        }

        public Covid19(string nombre) : base(nombre)
        {
        }
    }
}
