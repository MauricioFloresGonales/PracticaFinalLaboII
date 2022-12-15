using System;
using System.Text;

namespace Entidades
{
    public enum EContagiosidad
    {
        Baja,
        Moneda, 
        Alta
    }
    public enum ETipo
    {
        Virus,
        Bacteria
    }
    public abstract class Microrganismo
    {
        protected long contador;
        EContagiosidad contagiosidad;
        string nombre;
        ETipo tipo;

        public Microrganismo(string nombre)
        {
            this.nombre = nombre;
        }
        public Microrganismo(EContagiosidad contagiosidad, string nombre, ETipo tipo): this(nombre)
        {
            this.contador = 1;
            this.contagiosidad = contagiosidad;
            this.tipo = tipo;
        }

        public abstract long IndiceDeContagios { get; }

        public string Informe()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El {this.tipo} lleva el nombre de {this.nombre} y ");
            sb.AppendLine($"tiene una contagiosidad {this.contagiosidad} ");
            sb.AppendLine($"Su impacto de contagios se calcula en {this.IndiceDeContagios}.");
            return sb.ToString();
        }
        
    }
}
