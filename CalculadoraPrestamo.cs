using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPrestamo
{
    public partial class CalculadoraPrestamo : Form
    {
        double montoPrestamo = 0;
        double tasaDeInteres = 0;
        int noCuotas = 0;
        public CalculadoraPrestamo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!parametrosValidos())
            
                return;
                limpiarResultado();
                calcularPrestamo();
            
        }

        private bool parametrosValidos()
        {
            try
            {
                montoPrestamo = double.Parse(txtMontoPrestamo.Text);
                tasaDeInteres = double.Parse(txtTasaInteres.Text);
                noCuotas = (int) nudNoCuotas.Value;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existen Paramentos Incorrectos: " + ex.Message);
                return false;
            }            
        }

        private void calcularPrestamo()
        {
            try 
            {
                double capitalCuota    = montoPrestamo / noCuotas;
                double interesCuota    = montoPrestamo * (tasaDeInteres / 12 / 100);
                double montoCuota      = capitalCuota + interesCuota;
                double capitalPagado   = 0;
                double capitalRestante = 0;

                for(int cuota = 1; cuota <= noCuotas; cuota++)
                {
                    capitalPagado += capitalCuota;
                    capitalRestante = montoPrestamo - capitalPagado;


                    ListNoCuotas.Items.Add(cuota);
                    ListCapitalCuota.Items.Add(capitalCuota.ToString("c"));
                    ListInteresCuota.Items.Add(interesCuota.ToString("###,###,##0.00"));
                    ListMontoCuota.Items.Add(montoCuota.ToString("c"));
                    ListCaCuota.Items.Add(capitalPagado.ToString("c"));
                    ListCapRestante.Items.Add(capitalRestante.ToString("c"));
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al calcular prestamo: " + ex.Message);           
            }
        }

        private void limpiarResultado()
        {
            ListNoCuotas.Items.Clear();
            ListInteresCuota.Items.Clear();
            ListMontoCuota.Items.Clear();
            ListCapitalCuota.Items.Clear();
            ListCapRestante.Items.Clear();
            ListCaCuota.Items.Clear();
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculadoraPrestamo_Load(object sender, EventArgs e)
        {

        }
    }
}
