using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AppBuses
{
    public partial class FormCompany : Form
    {

        TouristCompany objTouristCompany = new TouristCompany();
        public FormCompany(String nit, String nombre, String direccion
            , String telefono)
        {
            InitializeComponent();
            // centrar formulario
            this.CenterToScreen();
            // inicializar objeto
            this.txtNit.Text = nit;
            this.txtNit.Enabled = false;
            this.txtCompanyName.Text = nombre;
            this.txtAddress.Text = direccion;
            this.txtPhone.Text = telefono;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Método para limpar campos de compañía
        public void DeleteFieldsCompany()
        {
            txtNit.Clear();
            txtCompanyName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }

        // Método para actualizar datos de la compañía
        private void btnUpdateCompany_Click(object sender, EventArgs e)
        {
            objTouristCompany.Address = txtAddress.Text;
            objTouristCompany.CompanyName = txtCompanyName.Text;
            objTouristCompany.Phone = txtPhone.Text;
            MessageBox.Show("Se actualizaron los datos correctamente");
        }
    }
}
