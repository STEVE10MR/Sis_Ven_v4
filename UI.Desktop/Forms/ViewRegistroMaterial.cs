using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.AplicationController;
using UI.Desktop.ViewModel;

namespace UI.Desktop.Forms
{
    public partial class ViewRegistroMaterial : Form
    {
        private RegistroMaterialesViewModel RegistroMaterialesModel = new RegistroMaterialesViewModel();
        readonly MaterialController MaterialController;
        public ViewRegistroMaterial()
        {
            InitializeComponent();
            MaterialController = new MaterialController();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //string mat_id = Convert.ToString(txtID.Text);
            if (!String.IsNullOrEmpty(txtID.Text))
            {
                //int mat_id = Convert.ToInt32(txtID.Text);
                BuscarMaterial(txtID.Text);
            }
            else
            {
                MessageBox.Show("Ingrese el ID del Material");
                txtID.Clear();
            }
        }

        private void BuscarMaterial(String mat_id)
        {
            
        }
        private void Mostrar()
        {
            txtID.Text = Convert.ToString(RegistroMaterialesModel.LimiteVenta.Material.ID_Material);
            txtNombre.Text = RegistroMaterialesModel.LimiteVenta.Material.Nombre;

            txtDescripcion.Text = RegistroMaterialesModel.LimiteVenta.Material.Descripcion;
            txtUnidad.Text = Convert.ToString(RegistroMaterialesModel.LimiteVenta.Material.Unidad);
            txtPrecio.Text = Convert.ToString(RegistroMaterialesModel.LimiteVenta.Material.PrecioUnit);
            txtStock.Text = Convert.ToString(RegistroMaterialesModel.LimiteVenta.Material.Stock);
        }
    }
}
