using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace SimuladorForm
{
    public partial class SimulacionForm : Form
    {
        static CancellationTokenSource cts;
        string textoInforme;

        CancellationToken ct;
        public static CancellationTokenSource Cts
        {
            get
            {
                if (cts is null || cts.IsCancellationRequested)
                {
                    cts = new CancellationTokenSource();
                }

                return cts;
            }
        }
        public SimulacionForm()
        {
            InitializeComponent();
            ct = SimulacionForm.Cts.Token;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            Gripe gripe = new Gripe(EContagiosidad.Alta, "PIPOCA", ETipo.Virus);
            Task.Run(() => Ejecutar<Gripe>(ct, gripe));
            textoInforme = gripe.Informe();
        }
        public void Informe(CancellationToken ct, int dia, long infectados)
        {
            string text = $"Dia {dia}: {infectados} infectados de la poblacion total.\n";
            while (!ct.IsCancellationRequested)
            {
                if (this.rtxEvolucion.InvokeRequired)
                {
                    this.rtxEvolucion.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.rtxEvolucion.AppendText(text);
                    });
                    break;
                } else
                {
                    this.rtxEvolucion.AppendText(text);
                }
            }
        }
        public void InformeFinal(CancellationToken ct)
        {
            string text = textoInforme;
            while (!ct.IsCancellationRequested)
            {
                if (this.rtxEvolucion.InvokeRequired)
                {
                    this.rtxEvolucion.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.rtxEvolucion.AppendText(text);
                    });
                    break;
                }
                else
                {
                    this.rtxEvolucion.AppendText(text);
                }
            }
        }
        private void Final(CancellationToken ct)
        {
            this.InformeFinal(ct);
            SimulacionForm.Cts.Cancel();
            ct = SimulacionForm.Cts.Token;
        }
        private void Ejecutar<T>(CancellationToken ct, T enfermedad)
        {
            GrupoDePrueba<Gripe>.InformeDeAvance += this.Informe;
            GrupoDePrueba<Gripe>.FinalizaSimulacion += this.Final;

            GrupoDePrueba<Gripe>.InfectarPoblacion(ct, enfermedad);
        }
    }
}
