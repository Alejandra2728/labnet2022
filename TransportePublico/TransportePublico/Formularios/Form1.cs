using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportePublico.Clases;

namespace TransportePublico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarPasajeros_Click(object sender, EventArgs e)
        {
            if (txtTaxi.Text == "")
            {
                error1.SetError(txtTaxi, "Debe ingresar un numero");
                txtTaxi.Focus();
                return;
            }
            error1.SetError(txtTaxi, "");

            if (txtOmnibus.Text == "")
            {
                error1.SetError(txtOmnibus, "Debe ingresar un numero");
                txtOmnibus.Focus();
                return;
            }
            error1.SetError(txtOmnibus, "");

            int pasajeroOmnibus;
            if (!int.TryParse(txtOmnibus.Text, out pasajeroOmnibus))
            {
                error1.SetError(txtOmnibus, "Debe ingresar un numero, no acepta letra");
                txtOmnibus.Focus();
                return;
            }
            error1.SetError(txtOmnibus, "");

            int pasajeroTaxi;
            if (!int.TryParse(txtTaxi.Text, out pasajeroTaxi))
            {
                error1.SetError(txtTaxi, "Debe ingresar un numero, no acepta letra");
                txtTaxi.Focus();
                return;
            }
            error1.SetError(txtTaxi, "");

            if (int.Parse(txtOmnibus.Text) > 80)
            {
                error1.SetError(txtOmnibus, "Ingrese un numero menor tantos pasajeros no pueden ir");
                txtOmnibus.Focus();
                return;
            }
            error1.SetError(txtOmnibus, "");

            if (int.Parse(txtTaxi.Text) > 4)
            {
                error1.SetError(txtTaxi, "Ingrese un numero menor tantos pasajeros no pueden ir");
                txtOmnibus.Focus();
                return;
            }
            error1.SetError(txtTaxi, "");

            int pasajerosOmnibus = int.Parse(this.txtOmnibus.Text);
            Omnibus objOmnibus = new Omnibus(pasajerosOmnibus);
            int pasajerosTaxi = int.Parse(this.txtTaxi.Text);
            Taxi objTaxi = new Taxi(pasajerosTaxi);

            int indice = 0;
            indice = dgvDatosPasajeros.Rows.Add();
            if (indice < 5)
            {
                dgvDatosPasajeros.Rows[indice].Cells[0].Value = $"Omnibus: {indice + 1} {objOmnibus.Pasajero} pasajeros";
                dgvDatosPasajeros.Rows[indice].Cells[1].Value = objOmnibus.Detenerse();
                dgvDatosPasajeros.Rows[indice].Cells[2].Value = objOmnibus.Avanzar();
                dgvDatosPasajeros.Rows[indice].Cells[3].Value = $"Taxi: {indice + 1} {objTaxi.Pasajero} pasajeros";
                dgvDatosPasajeros.Rows[indice].Cells[4].Value = objTaxi.Detenerse();
                dgvDatosPasajeros.Rows[indice].Cells[5].Value = objTaxi.Avanzar();
                indice++;
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("Ya ingresaste todos los pasajeros", "Terminar", MessageBoxButtons.OK);
                if (respuesta == DialogResult.OK)
                {
                    Close();
                }
            }
            txtOmnibus.Text = "";
            txtTaxi.Text = "";
        }

    }
}

