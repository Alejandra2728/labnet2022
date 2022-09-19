using Calculadora.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDivisionPorCero_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = int.Parse(txtNumero.Text);

                var resu = Division.Dividir(num1) / 0;
                Text = $"La división de {num1} respecto con cero es {resu}";
            }
            catch (FormatException ex)
            {
                Text = "Debe ingresar números enteros.";
                MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Text = "Como vas a dividir algo que no tenes, en tal caso pedi prestado, esto pasa por mamon";
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
                Text = "";
                MessageBox.Show("Aca termino la division, no me hago responsable de como termine");
            }
            txtNumero.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = int.Parse(txtNum1.Text);
                var num2 = int.Parse(txtNum2.Text);

                var resu = Division.DividirPorDosNumeros(num1, num2);
               MessageBox.Show($"La división de {num1} con {num2} es {resu}");
            }
            catch (FormatException ex)
            {
                Text = "Seguro ingreso una letra o no ingreso nada.";
                MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Text = "Solo Chuk Norris divide por cero";
                MessageBox.Show(ex.Message);
            }
            finally
            {

                Text = "";
                MessageBox.Show("Aca termino la division, no me hago responsable de como termine");
            }
            txtNum1.Text = "";
            txtNum2.Text = "";
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            Logic miEmpleado = new Logic();
            try
            {
                miEmpleado.Edad = int.Parse(txtEdad.Text);
                MessageBox.Show($"Edad del empleado {miEmpleado.Edad}");
            }
            catch (IndexOutOfRangeException x)
            {
                MessageBox.Show(x.Message);
                MessageBox.Show(x.StackTrace);
                return;
            }
            txtEdad.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCapturaExcepcion_Click(object sender, EventArgs e)
        {
            Logic excep = new Logic();
            try
            {
               excep.CapturoExcepcionPersonalizada();
            }
            catch (Exception ejemplo)
            {

                MessageBox.Show($"Se capturo la excepcion {ejemplo.Message}");
            }
        }
    }
}

