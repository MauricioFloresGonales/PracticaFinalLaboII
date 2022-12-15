using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void AvanceInfectados(CancellationToken ct, int dia, long infectados);
    public delegate void FinInfectacion(CancellationToken ct);
    public static class GrupoDePrueba<T> where T : Microrganismo
    {
        public static event AvanceInfectados InformeDeAvance;
        public static event FinInfectacion FinalizaSimulacion;

        public static T enfermedad;
        public static long poblacion;

        public static long Poblacion
        {
            get { return poblacion = poblacion - enfermedad.IndiceDeContagios; }
            set { poblacion = value; }
        }

        static GrupoDePrueba()
        {
            poblacion = 10000000;
        }
        public static void InfectarPoblacion(CancellationToken ct, object obj)
        {
            if (obj.GetType() == typeof(T))
            {
                enfermedad = (T)obj;
                int i = 1;
                if (!ReferenceEquals(InformeDeAvance, null))
                {
                    while (poblacion >= enfermedad.IndiceDeContagios)
                    {
                        InformeDeAvance.Invoke(ct, i, enfermedad.IndiceDeContagios);
                        Thread.Sleep(75);
                        i++;
                    }
                }
                if (!ReferenceEquals(FinalizaSimulacion, null))
                {
                    FinalizaSimulacion.Invoke(ct);
                }
            }
        }
    }
}
