using LabEF.Entities;
using LabEF.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEF.UI
{
    public partial class Form1 : Form
    {
        SupplierLogic supLogic = new SupplierLogic();
        BindingList<SupplierDto> supplierDtos = new BindingList<SupplierDto>();
        List<SupplierDto> TempInsertar = new List<SupplierDto>();
        List<SupplierDto> TempEditar = new List<SupplierDto>();
        List<SupplierDto> TempEliminar = new List<SupplierDto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void shipperToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            supplierDtos.AddNew();
            dtvMostrarDato.Rows[dtvMostrarDato.Rows.Count -1].Cells["_RegType"].Value = "Temp";
        }
        void CargarGrilla()
        {
            supplierDtos = supLogic.GetAll();
            dtvMostrarDato.DataSource = supplierDtos;

            foreach (DataGridViewRow fila in dtvMostrarDato.Rows)
            {
                fila.Cells["_RegType"].Value = "NoTemp";
            }
        }

        private void dtvMostrarDato_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (dtvMostrarDato.Rows[e.RowIndex].Cells["_RegType"].Value!=null)
                {
                    dtvMostrarDato.Rows[e.RowIndex].Cells["_RegStatus"].Value = "Editado";
                }
            }
        }
        void LLenarTemporales()
        {
            foreach (DataGridViewRow fila in dtvMostrarDato.Rows) 
            {
                if (fila.Cells["_RegStatus"].Value != null && fila.Cells["_RegStatus"].Value.ToString() == "Editado")
                {
                    SupplierDto supplierTemp = new SupplierDto();
                    switch (fila.Cells["_RegType"].Value.ToString())
                    {
                        case "NoTemp":
                            supplierTemp.SupplierID = int.Parse(fila.Cells["supplierID"].Value.ToString());
                            supplierTemp.CompanyName = fila.Cells["CompanyName"].Value != null ? fila.Cells["CompanyName"].Value.ToString() : null;
                            supplierTemp.ContactName = fila.Cells["ContactName"].Value != null ? fila.Cells["ContactName"].Value.ToString() : null;
                            supplierTemp.ContactTitle= fila.Cells["ContactTitle"].Value != null ? fila.Cells["ContactTitle"].Value.ToString() : null;
                            TempEditar.Add(supplierTemp);
                            break;
                        case "Temp":
                            supplierTemp.SupplierID = int.Parse(fila.Cells["supplierID"].Value.ToString());
                            supplierTemp.CompanyName = fila.Cells["CompanyName"].Value != null ? fila.Cells["CompanyName"].Value.ToString() : null;
                            supplierTemp.ContactName = fila.Cells["ContactName"].Value != null ? fila.Cells["ContactName"].Value.ToString() : null;
                            supplierTemp.ContactTitle = fila.Cells["ContactTitle"].Value != null ? fila.Cells["ContactTitle"].Value.ToString() : null;
                            TempInsertar.Add(supplierTemp);
                            break;
                    }

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dtvMostrarDato.SelectedRows.Count != 0)
            {
                if (dtvMostrarDato.Rows[dtvMostrarDato.SelectedRows[0].Index].Cells["_RegType"].Value.ToString() == "NoTemp")
                {
                    SupplierDto supplierDto = new SupplierDto();
                    supplierDto.SupplierID = int.Parse(dtvMostrarDato.Rows[dtvMostrarDato.SelectedRows[0].Index].Cells["supplierID"].Value.ToString());
                    TempEliminar.Add(supplierDto);
                    dtvMostrarDato.Rows.Remove(dtvMostrarDato.Rows[dtvMostrarDato.SelectedRows[0].Index]);

                }
                else
                {
                    dtvMostrarDato.Rows.Remove(dtvMostrarDato.Rows[dtvMostrarDato.SelectedRows[0].Index]);
                }
            }
         }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LLenarTemporales();
            supLogic.ActualizarAlumno(TempInsertar, TempEditar, TempEliminar);
            CargarGrilla();

            TempInsertar = new List<SupplierDto>();
            TempEditar = new List<SupplierDto>();
            TempEliminar= new List<SupplierDto>();

        }
    }
}
