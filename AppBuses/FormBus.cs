using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppBuses
{
    public partial class FormBus : Form
    {
        // crear Lista de objetos TouristCompany
        public List<Bus> tc = new List<Bus>();
        List<Driver> drivers = new List<Driver>();
        int tamañoX;
        int tamañoY;
        int[,] Sillas;
        //TouristCompany[] tc = new TouristCompany[100];
        public FormBus()
        {
            InitializeComponent();
            dataGridViewGraficaBus.Visible = false;
            this.SetBounds(0, 0, 567, this.Size.Height);
            //this.SetBounds(0, 0, tamañoX, tamañoY);
            this.btnGraficarBus.Enabled = true;
        }

        public void LlenarLista(List<Driver> drive)
        {
            drivers = drive;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Método para limpar campos de bus
        public void DeleteFieldsBus()
        {
            // borrar campos de bus
            txtBusPlate.Clear();
            //comboBoxBusType.Items.Clear();
            txtBusRows.Clear();
            txtBusColumns.Clear();
            txtBusDriverIdentification.Clear();
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            // Leer atributos del bus del formulario
            string busPlate = txtBusPlate.Text;
            string busType = comboBoxBusType.Text;
            // Leer capacidad del bus como arreglo bidimensional del formulario con filas y columnas
            int busRows = Convert.ToInt32(txtBusRows.Text);
            int busColumns = Convert.ToInt32(txtBusColumns.Text);
            //int[,] busCapacity = new int[busRows, busColumns];
            int busCapacity1 = busRows * busColumns;

            Boolean bandera = false;
            Driver driver = null;

            for (int i = 0; i < drivers.Count; i++)
            {
                if (drivers[i].Identification.Equals(txtBusDriverIdentification.Text))
                {
                    driver = drivers[i];
                    bandera = true;
                }

            }

            if (bandera)
            {
                Bus objBus = new Bus
                {
                    BusPlate = busPlate,
                    BusType = busType,
                    BusCapacity = Sillas,
                    BusCapacity1 = busCapacity1,
                    Driver = driver
                };
                tc.Add(objBus);
                MessageBox.Show("Bus añadido");
            }
            else
            {
                MessageBox.Show("El conductor no existe");
            }

            // Limpar campos
            DeleteFieldsBus();
        }

        private void btnBusList_Click(object sender, EventArgs e)
        {
            // Limpiar lista
            dataGridBus.Columns.Clear();
            dataGridBus.Rows.Clear();

            // agregar columnas 
            dataGridBus.Columns.Add("BusPlate", "Placa");
            dataGridBus.Columns.Add("BusType", "Tipo");
            dataGridBus.Columns.Add("BusDriver", "Identificación");
            dataGridBus.Columns.Add("BusDriver", "Conductor");
            dataGridBus.Columns.Add("BusCapacity1", "Capacidad");


            // Agregar filas recorriendo lista tc
            for (int i = 0; i < tc.Count; i++)
            {
                dataGridBus.Rows.Add(tc[i].BusPlate, tc[i].BusType, tc[i].Driver.Identification, tc[i].Driver.Name, tc[i].BusCapacity1 + " Pasajeros");

            }
        }

        private void btnUpdateBus_Click(object sender, EventArgs e)
        {
            // Actualizar datos del bus tomando el número de placa y las filas y columnas
            string busPlate = txtBusPlate.Text;
            // filas y columnas
            int busRows = Convert.ToInt32(txtBusRows.Text);
            int busColumns = Convert.ToInt32(txtBusColumns.Text);
            int busCapacity1 = busRows * busColumns;

            bool bandera = false;

            for (int i = 0; i < drivers.Count; i++)
            {
                if (tc[i].BusPlate.Equals(busPlate))
                {
                    tc[i].BusType = comboBoxBusType.Text;
                    tc[i].BusPlate = txtBusPlate.Text;
                    tc[i].Driver = drivers[i];
                    // falta actualizar matriz de capacidad //// 

                    tc[i].BusCapacity1 = busCapacity1;
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
                MessageBox.Show("No se encontro el bus con la placa: " + busPlate);
            }

            // Limpiar campos
            DeleteFieldsBus();
        }

        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            // Eliminar bus ingresando el numero de placa y nit de la empresa del bus por inputBox
            string busPlate = Interaction.InputBox("Ingrese el numero de placa de la bus a eliminar", "Eliminar Bus", "", -1, -1);

            for (int i = 0; i < tc.Count; i++)
            {
                if (tc[i].BusPlate.Equals(busPlate))
                {
                    tc.RemoveAt(i);
                    MessageBox.Show("Se ha eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar");
                }
            }
        }

        private void FormBus_Load(object sender, EventArgs e)
        {

        }

        public void btnGraficarBus_Click(object sender, EventArgs e)
        {
            dataGridViewGraficaBus.Visible = true;
            string filas = txtBusRows.Text;
            string columnas = txtBusColumns.Text;
            if (!filas.Equals("") && !columnas.Equals(""))
            {
                int rows = Int32.Parse(filas);
                int columns = Int32.Parse(columnas);
                tamañoX = this.Size.Width;
                tamañoY = this.Size.Height;
                Sillas = new int[rows, columns];

                this.SetBounds(0, 0, (int)(tamañoX * 1.5), tamañoY);
                this.btnGraficarBus.Enabled = false;
                GraphicBus();
            }
            else
            {
                MessageBox.Show("Ingrese bien los datos de filas y columnas");
            }

        }

        public void GraphicBus()
        {
            dataGridViewGraficaBus.ColumnCount = Sillas.GetLength(1);
            dataGridViewGraficaBus.RowCount = Sillas.GetLength(0);
            for (int i = 0; i < Sillas.GetLength(0); i++)
            {
                for (int j = 0; j < Sillas.GetLength(1); j++)
                {
                    dataGridViewGraficaBus.Rows[i].Cells[j].Value = Sillas[i, j].ToString();
                }
            }
        }

        private void txtBusRows_TextChanged(object sender, EventArgs e)
        {
            string filas = txtBusRows.Text;
            string columnas = txtBusColumns.Text;
            if (!filas.Equals("") && !columnas.Equals(""))
            {
                int rows = Int32.Parse(filas);
                int columns = Int32.Parse(columnas);
                Sillas = new int[rows, columns];
                LlenarMatriz();
            }
        }

        private void txtBusColumns_TextChanged(object sender, EventArgs e)
        {
            string filas = txtBusRows.Text;
            string columnas = txtBusColumns.Text;
            if (!filas.Equals("") && !columnas.Equals(""))
            {
                int rows = Int32.Parse(filas);
                int columns = Int32.Parse(columnas);
                Sillas = new int[rows, columns];
                LlenarMatriz();
            }
        }

        public void LlenarMatriz()
        {
            for (int i = 0; i < Sillas.GetLength(0); i++)
            {
                for (int j = 0; j < Sillas.GetLength(1); j++)
                {
                    Sillas[i, j] = 0;
                }
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            string filaInhabilitada = txtInhabilitarFila.Text;
            string columnaInhabilitada = txtInhabilitarColumna.Text;
            if (!filaInhabilitada.Equals("") && !columnaInhabilitada.Equals(""))
            {
                Sillas[Int32.Parse(filaInhabilitada) - 1, Int32.Parse(columnaInhabilitada) - 1] = -1;
                GraphicBus();
            }
            else
            {
                MessageBox.Show("Ingrese bien los datos");
            }
        }
    }
}
