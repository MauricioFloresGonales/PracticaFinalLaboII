using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gripe : Microrganismo
    {
        public override long IndiceDeContagios
        {
            get {
                long total = base.contador * 2;
                base.contador = total;
                return total; 
            }
        }
        public Gripe(EContagiosidad contagiosidad, string nombre, ETipo tipo) : base(contagiosidad, nombre, tipo)
        {
        }
    }
}
