using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppBuses
{
    public partial class FormDriver : Form
    {
        // crear Lista de objetos TouristCompany
        public List<Driver> drivers = new List<Driver>();
        //TouristCompany[] tc = new TouristCompany[100];
        public FormDriver()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Método para limpar campos de conductor
        public void DeleteFieldsDriver()
        {
            // borrar campos de conductor
            txtDriverIdentification.Clear();
            txtDriverName.Clear();
            txtDriverLastName.Clear();
            txtDriverPhone.Clear();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            // Crear conductor ingresando atributos del conductor del formulario
            string driverIdentification = txtDriverIdentification.Text;
            string driverName = txtDriverName.Text;
            string driverLastName = txtDriverLastName.Text;
            string driverPhone = txtDriverPhone.Text;

            // Crear nuevo conductor
            Driver objDriver = new Driver
            {
                Identification = driverIdentification,
                Name = driverName,
                LastName = driverLastName,
                Phone = driverPhone
            };
            bool bandera = false;
            for (int i = 0; i < drivers.Count; i++)
            {
                if (drivers[i].Identification.Equals(driverIdentification))
                {
                    bandera = true;
                }
            }
            if (bandera)
            {
                MessageBox.Show("El conductor con el numero de identificación: " + driverIdentification + " ya se encuentra en el sistema");
            }
            else
            {
                drivers.Add(objDriver);
                MessageBox.Show("Conductor añadido correctamente");
            }

            // Limpiar campos
            DeleteFieldsDriver();
        }

        private void btnDriverList_Click(object sender, EventArgs e)
        {
            // Limpiar lista
            dataGridConductor.Columns.Clear();
            dataGridConductor.Rows.Clear();

            // Crear columnas con datos de los conductores
            dataGridConductor.Columns.Add("Identification", "Identificación");
            dataGridConductor.Columns.Add("Name", "Nombre");
            dataGridConductor.Columns.Add("LastName", "Apellido");
            dataGridConductor.Columns.Add("Phone", "Teléfono");

            // Recorrer vector para mostrar conductores de la empresa
            for (int i = 0; i < drivers.Count; i++)
            {
                dataGridConductor.Rows.Add(drivers[i].Identification, drivers[i].Name, drivers[i].LastName, drivers[i].Phone);

            }
        }

        private void btnUpdateDriver_Click(object sender, EventArgs e)
        {
            // Actualizar datos del conductor tomando el número de identificación y nit empresa
            string driverIdentification1 = txtDriverIdentification.Text;
            bool bandera = false;

            for (int i = 0; i < drivers.Count; i++)
            {
                if (drivers[i].Identification.Equals(driverIdentification1))
                {
                    drivers[i].Name = txtDriverName.Text;
                    drivers[i].LastName = txtDriverLastName.Text;
                    drivers[i].Phone = txtDriverPhone.Text;
                    bandera = true;
                    break;
                }
            }
            if (bandera)
            {
                MessageBox.Show("Los datos se actualizaron correctamente");
            }
            else
            {
                MessageBox.Show("No se encontro la persona con la identifiación: " + driverIdentification1);
            }

            // Borrar campos
            DeleteFieldsDriver();
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            // Eliminar conductor ingresando el número de identificación por inputBox
            string driverIdentification1 = Interaction.InputBox("Ingrese el numero de identificación del conductor a eliminar", "", "", -1, -1);

            // Recorrer Lista para eliminar el conductor con el número de identificación y el nit ingresado
            for (int i = 0; i < drivers.Count; i++)
            {
                if (drivers[i].Identification.Equals(driverIdentification1))
                {
                    drivers.RemoveAt(i);
                    MessageBox.Show("Se ha eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar");
                }
            }
        }

        private void FormDriver_Load(object sender, EventArgs e)
        {

        }
    }
}
